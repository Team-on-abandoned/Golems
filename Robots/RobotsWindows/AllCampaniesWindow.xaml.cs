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
	/// Interaction logic for AllCampaniesWindow.xaml
	/// </summary>
	public partial class AllCampaniesWindow : Window {
		public AllCampaniesWindow() {
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

		private void Button_OpenCampany1(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.Campany1Window);
		}

		private void Button_OpenCampany2(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.Campany2Window);
		}

		private void Button_OpenCampany3(object sender, RoutedEventArgs e) {
			WindowsManager.ReopenWindow(this, WindowsManager.Campany3Window);
		}
	}
}
