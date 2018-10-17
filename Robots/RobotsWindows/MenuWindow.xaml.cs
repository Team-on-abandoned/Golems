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
	/// Interaction logic for MenuWindow.xaml
	/// </summary>
	public partial class MenuWindow : Window {
		public MenuWindow() {
			InitializeComponent();
		}

		public bool IsClosed { get; private set; }
		protected override void OnClosed(EventArgs e) {
			base.OnClosed(e);
			IsClosed = true;
		}

		private void Window_Closed(object sender, EventArgs e) {
			WindowsManager.CloseAll();
		}

		private void Lobby_Click(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.LobbyWindow);
		}

		private void Campany_Click(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.AllCampaniesWindow);
		}

		private void Settings_Click(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.SettingsWindow);
		}

		private void Achievements_Click(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.AchievementsWindow);
		}

		private void Credits_Click(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.CreditsWindow);
		}

		private void Exit_Click(object sender, RoutedEventArgs e) {
			WindowsManager.CloseAll();
		}


		private void SetLanguageRu(object sender, RoutedEventArgs e) {
			App.Language = App.Languages[1];
		}

		private void SetLanguageEng(object sender, RoutedEventArgs e) {
			App.Language = App.Languages[0];
		}
	}
}
