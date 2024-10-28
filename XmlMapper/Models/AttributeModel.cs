using System.Xml.Serialization;

namespace XmlMapper.Models
{
    [XmlRoot("Attribute")]
    public class AttributeModel
    {
        [XmlElement("Approved_By")]
        public string ApprovedBy { get; set; }

        [XmlElement("Approved_At")]
        public string ApprovedAt { get; set; }

        [XmlElement("Revision")]
        public string Revision { get; set; }

        [XmlElement("ArticleNo")]
        public string ArticleNo { get; set; }

        [XmlElement("Custom_Comment")]
        public string CustomComment { get; set; }

        [XmlElement("Customer_DrawingNo")]
        public string CustomerDrawingNo { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("Description_EN")]
        public string DescriptionEN { get; set; }

        [XmlElement("Description2")]
        public string Description2 { get; set; }

        [XmlElement("DrawingNo")]
        public string DrawingNo { get; set; }

        [XmlElement("Einheit")]
        public string Einheit { get; set; }

        [XmlElement("Material")]
        public string Material { get; set; }

        [XmlElement("State")]
        public string State { get; set; }

        [XmlElement("Surface")]
        public double Surface { get; set; }

        [XmlElement("Weight")]
        public double Weight { get; set; }

        [XmlElement("Surface_finish_2")]
        public string SurfaceFinish2 { get; set; }

        [XmlElement("Surface_Destiniation_1")]
        public string SurfaceDestiniation1 { get; set; }

        [XmlElement("Surface_Destiniation_2")]
        public string SurfaceDestiniation2 { get; set; }

        [XmlElement("Surface_finish_1")]
        public string SurfaceFinish1 { get; set; }

        [XmlElement("Thickness")]
        public string Thickness { get; set; }

        [XmlElement("Beschreibung")]
        public string Beschreibung { get; set; }

        [XmlElement("PDM-Vorlage")]
        public string PdmVorlage { get; set; }

        [XmlElement("Länge")]
        public string Länge { get; set; }

        [XmlElement("Rahmenbreite")]
        public string Rahmenbreite { get; set; }

        [XmlElement("Rahmenlänge")]
        public string Rahmenlänge { get; set; }

        [XmlElement("WINKEL1")]
        public string Winkel1 { get; set; }

        [XmlElement("WINKEL2")]
        public string Winkel2 { get; set; }

        [XmlElement("Certificate")]
        public string Certificate { get; set; }

        [XmlElement("Normung")]
        public string Normung { get; set; }

        [XmlElement("Surface_Destiniation_3")]
        public string SurfaceDestiniation3 { get; set; }

        [XmlElement("Surface_finish_3")]
        public string SurfaceFinish3 { get; set; }

        [XmlElement("Anzahl_Referenzen")]
        public double AnzahlReferenzen { get; set; }
    }
}
