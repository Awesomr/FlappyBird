using System;
using System.Windows;

namespace FlappyBird
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int gravity = 5;
        int pipeSpeed = 8;
        int score = 0;

        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(20);
            dispatcherTimer.Start();
            dispatcherTimer.IsEnabled = true;

            picBird.Width = 60;
            picBird.Height = 60;
            picBird.Margin = new Thickness(320, 248, 60, 262);



        }
                     
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            picBird.Margin = new Thickness(gravity);
        }

        private void gameKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                gravity = -5;
            }
        }

        private void gameKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                gravity = 5;
            }
        }
    }
}
