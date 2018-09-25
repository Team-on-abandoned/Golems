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

namespace RobotsWindows {
	/// <summary>
	/// Interaction logic for Settings.xaml
	/// </summary>
	public partial class SettingsWindow : Window {
		public SettingsWindow() {
			InitializeComponent();
		}

		private void Window_Activated(object sender, EventArgs e) {
			if(Properties.Settings.Default.IsFullscreen) {
				foreach(var i in resolutinBox.Items) {
					string[] s = ((i as ComboBoxItem).Content as string).Split('x');
					int width = int.Parse(s[0]), height = int.Parse(s[1]);
					if(width == Properties.Settings.Default.WindowWidth && height == Properties.Settings.Default.WindowHeight) {
						resolutinBox.SelectedItem = i;
						break;
					}
				}
			}
			else{
				foreach(var i in resolutinBox.Items) {
					string[] s = ((i as ComboBoxItem).Content as string).Split('x');
					int width = int.Parse(s[0]), height = int.Parse(s[1]);
					if(width == Width && height == Height) {
						resolutinBox.SelectedItem = i;
						break;
					}
				}
			}

			isFullscreen.IsChecked = Properties.Settings.Default.IsFullscreen;
			resolutinBox.IsEnabled = !Properties.Settings.Default.IsFullscreen;
		}

		public bool IsClosed { get; private set; }
		protected override void OnClosed(EventArgs e) {
			base.OnClosed(e);
			IsClosed = true;
		}

		private void Window_Closed(object sender, EventArgs e) {
			WindowsManager.CloseAll();
		}

		private void Back_Click(object sender, RoutedEventArgs e) {
			RobotsWindows.Properties.Settings.Default.Save();
			WindowsManager.ReopenWindow(this, WindowsManager.MenuWindow);
		}

		private void resolutinBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			string[] s = ((e.AddedItems[0] as ComboBoxItem).Content as string).Split('x');
			int width = int.Parse(s[0]), height = int.Parse(s[1]);

			Width = RobotsWindows.Properties.Settings.Default.WindowWidth = width;
			Height = RobotsWindows.Properties.Settings.Default.WindowHeight = height;
		}

		private void isFullscreen_Checked(object sender, RoutedEventArgs e) {
			RobotsWindows.Properties.Settings.Default.IsFullscreen = true;
			WindowsManager.OpenFullScreen(this);
			resolutinBox.IsEnabled = false;
		}

		private void isFullscreen_Unchecked(object sender, RoutedEventArgs e) {
			RobotsWindows.Properties.Settings.Default.IsFullscreen = false;
			WindowsManager.OpenNonFullScreen(this);
			resolutinBox.IsEnabled = true;
		}
	}
}
