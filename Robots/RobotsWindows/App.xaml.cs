using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GolemsWindows {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {
		public static List<CultureInfo> Languages => languages;

		private static List<CultureInfo> languages = new List<CultureInfo>();


		public App() {
			InitializeComponent();
			languages.Clear();
			languages.Add(new CultureInfo("en-US"));
			languages.Add(new CultureInfo("ru-RU"));

			Language = GolemsWindows.Properties.Settings.Default.DefaultLanguage;
		}

		public static CultureInfo Language {
			get {
				return System.Threading.Thread.CurrentThread.CurrentUICulture;
			}
			set {
				if (value == null)
					throw new ArgumentNullException("value");
				if (value == System.Threading.Thread.CurrentThread.CurrentUICulture)
					return;

				//1. Меняем язык приложения:
				System.Threading.Thread.CurrentThread.CurrentUICulture = value;

				//2. Создаём ResourceDictionary для новой культуры
				ResourceDictionary dict = new ResourceDictionary();
				switch (value.Name) {
					case "ru-RU":
						dict.Source = new Uri(String.Format("Strings/lang.{0}.xaml", value.Name), UriKind.Relative);
						break;
					default:
						dict.Source = new Uri("Strings/lang.xaml", UriKind.Relative);
						break;
				}

				//3. Находим старую ResourceDictionary и удаляем его и добавляем новую ResourceDictionary
				ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
											  where d.Source != null && d.Source.OriginalString.StartsWith("Strings/lang.")
											  select d).First();
				if (oldDict != null) {
					int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
					Application.Current.Resources.MergedDictionaries.Remove(oldDict);
					Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
				}
				else {
					Application.Current.Resources.MergedDictionaries.Add(dict);
				}

				GolemsWindows.Properties.Settings.Default.DefaultLanguage = value;
			}
		}

		private void OnExit(object sender, ExitEventArgs e) {
			GolemsWindows.Properties.Settings.Default.Save();
		}
	}
}
