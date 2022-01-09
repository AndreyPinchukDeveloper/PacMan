using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace PacMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer();

        bool goLeft, goDown, goRight, goUP;
        bool noLeft, noDown, noRight, noUP;

        int seed = 8;

        Rect pacmanHitBox;

        int ghostSeed = 10;
        int ghostMoveStep = 130;
        int currentGhostStep;
        int score = 0;

        public MainWindow()
        {
            InitializeComponent();
            GameSetUp();
        }

        private void CanvasKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GameSetUp()
        {
            MyCanvas.Focus();

            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Start();
            currentGhostStep = ghostMoveStep;

            ImageBrush pacmanImage = new ImageBrush();
            pacmanImage.ImageSource = new BitmapImage(new Uri("pack://application:.../images/pacman.jpg"));
            pacman.Fill = pacmanImage;

            ImageBrush redGhost = new ImageBrush();
            redGhost.ImageSource = new BitmapImage(new Uri("pack://application:.../images/red.jpg"));
            redGuy.Fill = redGhost;

            ImageBrush orangeGhost = new ImageBrush();
            orangeGhost.ImageSource = new BitmapImage(new Uri("pack://application:.../images/orange.jpg"));
            orangeGuy.Fill = orangeGhost;

            ImageBrush pinkGhost = new ImageBrush();
            pinkGhost.ImageSource = new BitmapImage(new Uri("pack://application:.../images/pink.jpg"));
            pinkGuy.Fill = pinkGhost;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GameOver()
        {

        }
    }
}
