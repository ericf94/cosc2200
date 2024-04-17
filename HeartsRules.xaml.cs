using System.Windows;

namespace Hearts
{
	/// <summary>
	/// Interaction logic for HeartsRules.xaml
	/// </summary>
	public partial class HeartsRules : Window
	{
		public HeartsRules()
		{
			InitializeComponent();
		}

		// Event handler for the Exit button
		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			Close(); // Close the window
		}
	}
}
