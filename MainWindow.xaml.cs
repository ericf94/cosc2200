/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is for the functionality of the Hearts game's main window.
 */
using HeartsGame;
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

namespace Hearts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads StartWindow when MainWindow Loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_StartWindow(object sender, RoutedEventArgs e)
        {
            StartWindow window = new StartWindow(this);
            window.Show();
            window.Topmost = true;
        }

        /// <summary>
        /// Launch SettingsWindow when button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaunchSettings(object sender, RoutedEventArgs e)
        {
            SettingsWindow window = new SettingsWindow();
            window.Show();
            window.Topmost = true;
        }

        /// <summary>
        /// Main function for initializing the start of a new game
        /// </summary>
        public static void PlayGame()
        {
            //Instance of this game
            var thisGame = new Game();

            //Start game for current instance of game
            thisGame.PlayGame();
        }
    }
}