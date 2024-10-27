using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _02_11_Smells_SimpleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public DispatcherTimer t;
        public bool r= false;
        public bool l = false;

        public int score = 0;


        public MainWindow()
        {
            InitializeComponent();
            t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60);

            t.Tick += GameLoop;
            t.Start();

            Game.Focus();
        }

        private void GameLoop(object sender, EventArgs e)
        {

            // moves objects 1,2,3 down the screen
            var y1 = Canvas.GetTop(Object1);
            Canvas.SetTop(Object1,y1 +10);

            var y2 = Canvas.GetTop(Object2);
            Canvas.SetTop(Object2, y2 + 10);

            var y3 = Canvas.GetTop(Object3);
            Canvas.SetTop(Object3, y3 + 10);



            // checks if objects are off screen and resets them
            if (y1 > 500)
            {
                Canvas.SetTop(Object1, 0);
            }

            if (y2 > 500)
            {
                Canvas.SetTop(Object2, 0);
            }

            if (y3 > 500)
            {
                Canvas.SetTop(Object3, 0);
            }


            // moves enemies down the screen
            var y4 = Canvas.GetTop(Enemy1);
            Canvas.SetTop(Enemy1, y4 + 10);

            var y5 = Canvas.GetTop(Enemy2);
            Canvas.SetTop(Enemy2, y5 + 10);

            var y6 = Canvas.GetTop(Enemy3);
            Canvas.SetTop(Enemy3, y6 + 10);

            // checks if enemies are off screen and resets them
            if (y4 > 500)
            {
                Canvas.SetTop(Enemy1, 0);
            }

            if (y5 > 500)
            {
                Canvas.SetTop(Enemy2, 0);
            }

            if (y6 > 500)
            {
                Canvas.SetTop(Enemy3, 0);
            }


            // Move Player right left 
            var x = Canvas.GetLeft(Player);

            if (r)
            {
                Canvas.SetLeft(Player, x + 10);
            }
            else if (l)
            {
                Canvas.SetLeft(Player, x - 10);
            }


            // Check for collision
            Rect rectPlayer1 = new Rect(Canvas.GetLeft(Player), Canvas.GetTop(Player), Player.Width, Player.Height);

            Rect rectEnemy2 = new Rect(Canvas.GetLeft(Enemy1), Canvas.GetTop(Enemy1), Enemy1.Width, Enemy1.Height);
            Rect rectEnemy3 = new Rect(Canvas.GetLeft(Enemy2), Canvas.GetTop(Enemy2), Enemy2.Width, Enemy2.Height);
            Rect rectEnemy4 = new Rect(Canvas.GetLeft(Enemy3), Canvas.GetTop(Enemy3), Enemy3.Width, Enemy3.Height);

            Rect rectObject1 = new Rect(Canvas.GetLeft(Object1), Canvas.GetTop(Object1), Object1.Width, Object1.Height);
            Rect rectObject2 = new Rect(Canvas.GetLeft(Object2), Canvas.GetTop(Object2), Object2.Width, Object2.Height);
            Rect rectObject3 = new Rect(Canvas.GetLeft(Object3), Canvas.GetTop(Object3), Object3.Width, Object3.Height);

            // respawn objects if they collide with player
            if (rectPlayer1.IntersectsWith(rectObject1))
            {
                Canvas.SetTop(Object1, 0);
                score++;
                Score.Text = "Score: " + score;
            }

            if (rectPlayer1.IntersectsWith(rectObject2))
            {
                Canvas.SetTop(Object2, 0);
                score++;
                Score.Text = "Score: " + score;
            }

            if (rectPlayer1.IntersectsWith(rectObject3))
            {
                Canvas.SetTop(Object3, 0);
                score++;
                Score.Text = "Score: " + score;
            }

            // respawn player if they collide with enemy
            if (rectPlayer1.IntersectsWith(rectEnemy2))
            {
                Canvas.SetTop(Enemy1, 0);
                score--;
                Score.Text = "Score: " + score;
            }

            if (rectPlayer1.IntersectsWith(rectEnemy3))
            {
                Canvas.SetTop(Enemy2, 0);
                score--;
                Score.Text = "Score: " + score;
            }

            if (rectPlayer1.IntersectsWith(rectEnemy4))
            {
                Canvas.SetTop(Enemy3, 0);
                score--;
                Score.Text = "Score: " + score;
            }

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Right)
            {
                r = true;
            }
            else if (e.Key == Key.Left)
            {
                l = true;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                r = false;
            }
            else if (e.Key == Key.Left)
            {
                l = false;
            }
        }
    }
}