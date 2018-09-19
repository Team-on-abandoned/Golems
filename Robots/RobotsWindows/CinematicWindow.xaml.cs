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
	/// Interaction logic for CinematicWindow.xaml
	/// </summary>
	public partial class CinematicWindow : Window {
		public CinematicWindow() {
			InitializeComponent();
		}

		public bool IsClosed { get; private set; }
		protected override void OnClosed(EventArgs e) {
			base.OnClosed(e);
			IsClosed = true;
		}

		private void Window_KeyDown(object sender, KeyEventArgs e) {
			switch (e.Key) {
				case Key.W:
					//RobotsWindows.Properties.Settings.Default.WindowHeight -= 10;
					this.Height -= 10;
					break;
				case Key.A:
					RobotsWindows.Properties.Settings.Default.WindowWidth -= 10;
					//this.Width -= 10;
					break;
				case Key.D:
					RobotsWindows.Properties.Settings.Default.WindowWidth += 10;
					//this.Width += 10;
					break;
				case Key.S:
					//RobotsWindows.Properties.Settings.Default.WindowHeight += 10;
					this.Height += 10;
					break;
				case Key.L:
					if(App.Languages[0].EnglishName == App.Language.EnglishName)
						App.Language = App.Languages[1];
					else
						App.Language = App.Languages[0];

					break;
			}
			//RobotsWindows.Properties.Settings.Default.Save();
		}
	}
}
