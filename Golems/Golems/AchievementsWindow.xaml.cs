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
	/// Interaction logic for AchievementsWindow.xaml
	/// </summary>
	public partial class AchievementsWindow : Window {
		public AchievementsWindow() {
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

		private void Back_Click(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.MenuWindow);
		}
	}
}
