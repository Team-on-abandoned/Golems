using System;
using System.Windows;


namespace RobotsWindows {
	static class WindowsManager {
		static CinematicWindow cinematicWindow;
		static MenuWindow menuWindow;
		static CreditsWindow creditsWindow;
		static AchievementsWindow achievementsWindow;
		static SettingsWindow settingsWindow;
		static AllCampaniesWindow allCampaniesWindow;
		static CampanyWindow campanyWindow;
		static LobbyWindow lobbyWindow;
		static GameWindow gameWindow;

		static WindowsManager() {
			cinematicWindow = new CinematicWindow();
			menuWindow = new MenuWindow();
			creditsWindow = new CreditsWindow();
			achievementsWindow = new AchievementsWindow();
			settingsWindow = new SettingsWindow();
			allCampaniesWindow = new AllCampaniesWindow();
			campanyWindow = new CampanyWindow();
			lobbyWindow = new LobbyWindow();
			gameWindow = new GameWindow();
		}

		public static void CloseAll() {
			if (!cinematicWindow.IsClosed)
				cinematicWindow.Close();

			if (!menuWindow.IsClosed)
				menuWindow.Close();

			if (!creditsWindow.IsClosed)
				creditsWindow.Close();

			if (!achievementsWindow.IsClosed)
				achievementsWindow.Close();

			if (!settingsWindow.IsClosed)
				settingsWindow.Close();

			if (!allCampaniesWindow.IsClosed)
				allCampaniesWindow.Close();

			if (!campanyWindow.IsClosed)
				campanyWindow.Close();

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

		public static void ReopenWindow(Window opened, Window toOpen) {
			opened.WindowStyle = toOpen.WindowStyle;
			opened.ResizeMode = toOpen.ResizeMode;
			toOpen.WindowState = opened.WindowState;

			toOpen.Left = opened.Left;
			toOpen.Top = opened.Top;
			toOpen.Width = opened.ActualWidth;
			toOpen.Height = opened.ActualHeight;

			opened.Topmost = opened.Topmost;

			toOpen.Show();
			opened.Hide();
		}
	}
}
