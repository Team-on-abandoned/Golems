using System;
using System.Windows;


namespace RobotsWindows {
	static class WindowsManager {
		//static CinematicWindow cinematicWindow;
		static MenuWindow menuWindow;
		static Lazy<CreditsWindow> creditsWindow;
		static Lazy<AchievementsWindow> achievementsWindow;
		static Lazy<SettingsWindow> settingsWindow;
		static Lazy<AllCampaniesWindow> allCampaniesWindow;
		static Lazy<CampanyWindow> campany1Window;
		static Lazy<CampanyWindow> campany2Window;
		static Lazy<CampanyWindow> campany3Window;
		static LobbyWindow lobbyWindow;
		static GameWindow gameWindow;

		//public static CinematicWindow CinematicWindow { get => cinematicWindow; set => cinematicWindow = value; }
		public static MenuWindow MenuWindow => menuWindow;
		public static CreditsWindow CreditsWindow => creditsWindow.Value;
		public static AchievementsWindow AchievementsWindow => achievementsWindow.Value; 
		public static SettingsWindow SettingsWindow => settingsWindow.Value; 
		public static AllCampaniesWindow AllCampaniesWindow => allCampaniesWindow.Value;
		public static CampanyWindow Campany1Window => campany1Window.Value;
		public static CampanyWindow Campany2Window => campany2Window.Value;
		public static CampanyWindow Campany3Window => campany3Window.Value;
		public static LobbyWindow LobbyWindow => lobbyWindow;
		public static GameWindow GameWindow => gameWindow;

		static WindowsManager() {
			//cinematicWindow = new CinematicWindow();
			menuWindow = new MenuWindow();
			creditsWindow = new Lazy<CreditsWindow>();
			achievementsWindow = new Lazy<AchievementsWindow>();
			settingsWindow = new Lazy<SettingsWindow>();
			allCampaniesWindow = new Lazy<AllCampaniesWindow>();
			campany1Window = new Lazy<CampanyWindow>();
			campany2Window = new Lazy<CampanyWindow>();
			campany3Window = new Lazy<CampanyWindow>();
			lobbyWindow = new LobbyWindow();
			gameWindow = new GameWindow();
		}

		public static void CloseAll() {
			//if (!cinematicWindow.IsClosed)
			//	cinematicWindow.Close();

			if (!menuWindow.IsClosed)
				menuWindow.Close();

			if (creditsWindow.IsValueCreated && !creditsWindow.Value.IsClosed)
				creditsWindow.Value.Close();

			if (achievementsWindow.IsValueCreated && !achievementsWindow.Value.IsClosed)
				achievementsWindow.Value.Close();

			if (settingsWindow.IsValueCreated && !settingsWindow.Value.IsClosed)
				settingsWindow.Value.Close();

			if (allCampaniesWindow.IsValueCreated && !allCampaniesWindow.Value.IsClosed)
				allCampaniesWindow.Value.Close();

			if (campany1Window.IsValueCreated && !campany1Window.Value.IsClosed)
				campany1Window.Value.Close();

			if (campany2Window.IsValueCreated && !campany2Window.Value.IsClosed)
				campany2Window.Value.Close();

			if (campany3Window.IsValueCreated && !campany3Window.Value.IsClosed)
				campany3Window.Value.Close();

			if (!lobbyWindow.IsClosed)
				lobbyWindow.Close();

			if (!gameWindow.IsClosed)
				gameWindow.Close();
		}

		public static void OpenFullScreen(Window window) {
			window.WindowStyle = WindowStyle.None;
			window.ResizeMode = ResizeMode.NoResize;
			window.WindowState = WindowState.Maximized;

			window.Left = 0;
			window.Top = 0;
			window.Width = SystemParameters.VirtualScreenWidth;
			window.Height = SystemParameters.VirtualScreenHeight;

			window.Topmost = true;
		}

		public static void OpenNonFullScreen(Window window) {
			window.WindowStyle = WindowStyle.SingleBorderWindow;
			window.ResizeMode = ResizeMode.NoResize;
			window.WindowState = WindowState.Normal;

			window.Width = Properties.Settings.Default.WindowWidth;
			window.Height = Properties.Settings.Default.WindowHeight;
			window.Left = (SystemParameters.VirtualScreenWidth - window.Width) / 2;
			window.Top = (SystemParameters.VirtualScreenHeight - window.Height) / 2;

			window.Topmost = false;
		}

		public static void ReopenWindow(Window opened, Window toOpen) {
			toOpen.WindowStyle = opened.WindowStyle;
			toOpen.ResizeMode = opened.ResizeMode;
			toOpen.WindowState = opened.WindowState;

			//toOpen.Title = opened.Title;

			toOpen.Left = opened.Left;
			toOpen.Top = opened.Top;
			toOpen.Width = opened.ActualWidth;
			toOpen.Height = opened.ActualHeight;

			toOpen.Topmost = opened.Topmost;

			toOpen.Show();
			opened.Hide();
		}
	}
}
