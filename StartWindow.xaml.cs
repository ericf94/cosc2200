/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is for the functionality of the Hearts game's start window.
 */
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
using System.Windows.Shapes;

namespace Hearts
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow(MainWindow mainWindow)
        {
            InitializeComponent();
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            MainWindow.PlayGame();
            //Close StartWindow
            this.Close();
        }

        private void ExitGame(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

            //Close MainWindow
            mainWindow.Close();

            //Close StartWindow
            this.Close();
        }
        private void GameRule(object sender, RoutedEventArgs e)
        {
            // Create an instance of the HeartsRules window
            HeartsRules rulesWindow = new HeartsRules();

            // Show the rules window
            rulesWindow.Show();
        }
    }
}
