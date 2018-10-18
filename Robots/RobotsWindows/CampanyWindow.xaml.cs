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
	/// Interaction logic for CompanyWindow.xaml
	/// </summary>
	public partial class CampanyWindow : Window {
		public CampanyWindow() {
			InitializeComponent();
		}

        public void ChooseCampany(int campanyNumber){
			stackPanelActs.Children.Clear();
			switch (campanyNumber) {
				case 1:
					for (byte i = 1; i <= 3; ++i) {
						Button b = new Button() { };
						b.SetResourceReference(Button.ContentProperty, $"Campany{campanyNumber}Act{i}");
						stackPanelActs.Children.Add(b);
					}
					break;
				case 2:
					for (byte i = 1; i <= 6; ++i) {
						Button b = new Button() { };
						b.SetResourceReference(Button.ContentProperty, $"Campany{campanyNumber}Act{i}");
						stackPanelActs.Children.Add(b);
					}
					break;
				case 3:
					for (byte i = 1; i <= 7; ++i) {
						Button b = new Button() { };
						b.SetResourceReference(Button.ContentProperty, $"Campany{campanyNumber}Act{i}");
						stackPanelActs.Children.Add(b);
					}
					break;
			}
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
			WindowsManager.ReopenWindow(this, WindowsManager.AllCampaniesWindow);
		}
	}
}
