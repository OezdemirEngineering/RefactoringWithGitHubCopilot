using System.IO;
using System.Printing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Xml.Serialization;
using XmlMapper.Models;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ControlzEx.Theming;

namespace XmlMapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            BrowseForFolder();
        }

        public void BrowseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            BrowseForFolder();
        }

        public void BrowseForFolder()
        {
            var dialog = new OpenFolderDialog()
            {
                Title = "Select the directory containing XML files",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                
            };

            if (dialog.ShowDialog() == true)
            {
                InputDirectoryTextBox.Text = dialog.FolderName;
            }
        }

        public async void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            var controller = await ((MetroWindow)this).ShowProgressAsync("Please wait...", "Mapping...");
            controller.SetIndeterminate();

            string inputPath = InputDirectoryTextBox.Text;

            if (string.IsNullOrWhiteSpace(inputPath) || !Directory.Exists(inputPath))
            {
                await ((MetroWindow)this).ShowMessageAsync("Error", "Please select a valid input directory.");
                await controller.CloseAsync();
                return;
            }

            var artikelFiles = Directory.GetFiles(inputPath, "*.xml").ToList();
            var artikels = artikelFiles.Select(DeserializeXml).ToList();
            var mainArtikelFile = FindMainArtikelFile(artikels);

            if (mainArtikelFile == null)
            {
                await ((MetroWindow)this).ShowMessageAsync("Error", "No main article found.");
                await controller.CloseAsync();
                return;
            }

            var removeList = new List<PositionModel>();
            var expandedPositions = ExpandPositions(mainArtikelFile, artikels, removeList).Where(p => p.State != null).ToList();

            foreach (var item in removeList)
            {
                expandedPositions.Remove(item);
            }

            var mergedPositions = MergePositions(expandedPositions).Where(p => p.State != null).ToList();
            mainArtikelFile.Stückliste = mergedPositions;

            string outputPath = Path.Combine(inputPath, "Output");

            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);

            string outputFile = Path.Combine(outputPath, $"Merged_{DateTime.Now:yyyyMMdd}.xml");
            SerializeXml(mainArtikelFile, outputFile);

            OutputTextBox.Text = $"Conversion completed successfully.\nOutput file: {outputFile}";

            await controller.CloseAsync();
            await ((MetroWindow)this).ShowMessageAsync("Success", "Conversion completed successfully.");
        }


        public void InfoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var infoWindow = new InfoWindow();
            infoWindow.ShowDialog();
        }

        public void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        public static ArtikelModel FindMainArtikelFile(List<ArtikelModel> artikels)
        {
            var referencedArticleNos = new HashSet<string>();

            foreach (var artikel in artikels)
            {
                foreach (var position in artikel.Stückliste)
                {
                    referencedArticleNos.Add(position.ArticleNo);
                }
            }

            foreach (var artikel in artikels)
            {
                var articleNo = artikel.Attribute.ArticleNo;
                if (!referencedArticleNos.Contains(articleNo))
                {
                    return artikel;
                }
            }

            return null;
        }

        public static List<PositionModel> ExpandPositions(ArtikelModel artikel, List<ArtikelModel> artikels, List<PositionModel> removeList)
        {
            var expandedPositions = new List<PositionModel>();

            foreach (var position in artikel.Stückliste)
            {
                expandedPositions.Add(position);

                var foundArtikel = artikels.FirstOrDefault(a => a.Attribute.ArticleNo == position.ArticleNo);
                if (foundArtikel != null)
                {

                    var subPositions = ExpandPositions(foundArtikel, artikels, removeList).Where(p=>p.State is not null).ToList();
                    if(subPositions.Count!=0)
                    {
                        expandedPositions.AddRange(subPositions);
                        removeList.Add(position);
                    }

                }
            }

            return expandedPositions;
        }

        public static List<PositionModel> MergePositions(List<PositionModel> positions)
        {


            var groupedPositions = positions
                                           .GroupBy(p => p.ArticleNo)
                                           .Select(g => new PositionModel
                                           {
                                               ApprovedBy = g.First().ApprovedBy,
                                               ApprovedAt = g.First().ApprovedAt,
                                               Revision = g.First().Revision,
                                               ArticleNo = g.Key,
                                               CustomComment = g.First().CustomComment,
                                               CustomerDrawingNo = g.First().CustomerDrawingNo,
                                               Description = g.First().Description,
                                               DescriptionEN = g.First().DescriptionEN,
                                               Description2 = g.First().Description2,
                                               DrawingNo = g.First().DrawingNo,
                                               Einheit = g.First().Einheit,
                                               Material = g.First().Material,
                                               State = g.First().State,
                                               Surface = g.First().Surface,
                                               Weight = g.First().Weight,
                                               SurfaceFinish2 = g.First().SurfaceFinish2,
                                               SurfaceDestiniation1 = g.First().SurfaceDestiniation1,
                                               SurfaceDestiniation2 = g.First().SurfaceDestiniation2,
                                               SurfaceFinish1 = g.First().SurfaceFinish1,
                                               Thickness = g.First().Thickness,
                                               Beschreibung = g.First().Beschreibung,
                                               PdmVorlage = g.First().PdmVorlage,
                                               Länge = g.First().Länge,
                                               Rahmenbreite = g.First().Rahmenbreite,
                                               Rahmenlänge = g.First().Rahmenlänge,
                                               Winkel1 = g.First().Winkel1,
                                               Winkel2 = g.First().Winkel2,
                                               Certificate = g.First().Certificate,
                                               Normung = g.First().Normung,
                                               SurfaceDestiniation3 = g.First().SurfaceDestiniation3,
                                               SurfaceFinish3 = g.First().SurfaceFinish3,
                                               AnzahlReferenzen = g.Sum(p => p.AnzahlReferenzen),
                                               Pos = g.First().Pos,
                                               Unit = g.First().Unit
                                           }).ToList();


            return groupedPositions;
        }

        public static ArtikelModel DeserializeXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ArtikelModel));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (ArtikelModel)serializer.Deserialize(fileStream);
            }
        }

        public static void SerializeXml(ArtikelModel artikel, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ArtikelModel));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, artikel);
            }
        }
    }
}