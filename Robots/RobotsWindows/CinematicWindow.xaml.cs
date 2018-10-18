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

namespace GolemsWindows {
	/// <summary>
	/// Interaction logic for CinematicWindow.xaml
	/// </summary>
	public partial class CinematicWindow : Window {
		public CinematicWindow() {
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e) {
			ShowIntro();

			if(Properties.Settings.Default.IsFullscreen)
				WindowsManager.OpenFullScreen(this);
			else
				WindowsManager.OpenNonFullScreen(this);

			WindowsManager.ReopenWindow(this, WindowsManager.MenuWindow);
			this.Close();
		}

		void ShowIntro() {

		}

		//public bool IsClosed { get; private set; }
		//protected override void OnClosed(EventArgs e) {
		//	base.OnClosed(e);
		//	IsClosed = true;
		//}

		//private void Window_KeyDown(object sender, KeyEventArgs e) {
		//	switch (e.Key) {
		//		case Key.W:
		//			this.Height -= 10;
		//			break;
		//		case Key.A:
		//			this.Width -= 10;
		//			break;
		//		case Key.D:
		//			this.Width += 10;
		//			break;
		//		case Key.S:
		//			this.Height += 10;
		//			break;
		//		case Key.L:
		//			if(App.Languages[0].EnglishName == App.Language.EnglishName)
		//				App.Language = App.Languages[1];
		//			else
		//				App.Language = App.Languages[0];
		//			break;
		//	}
		//}

		//private void Window_SizeChanged(object sender, SizeChangedEventArgs e) {
		//	RobotsWindows.Properties.Settings.Default.WindowWidth = (int)e.NewSize.Width;
		//	RobotsWindows.Properties.Settings.Default.WindowHeight = (int)e.NewSize.Height;
		//	RobotsWindows.Properties.Settings.Default.Save();
		//}
	}
}
