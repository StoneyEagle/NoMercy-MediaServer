using ElectronNET.API;
using ElectronNET.API.Entities;

namespace NoMercy.Server.Helpers;

public static class ElectronWindows
{
    private static BrowserWindow? _mainWindow;
    private static BrowserWindow? _splashScreen;
    
    private static async Task<BrowserWindow> MainWindow()
    {
        Electron.App.CommandLine.AppendSwitch("ignore-certificate-errors");
        Electron.App.CommandLine.AppendSwitch("disable-web-security");

        var width = Screen.GetScreenWidth();

        _mainWindow = await Electron.WindowManager.CreateWindowAsync(
            new BrowserWindowOptions
            {
                Width = (int)Math.Floor(width / 1.2),
                Height = (int)Math.Floor(width / 1.2 / (16 * 9)),
                MinWidth = 1320,
                MinHeight = 860,
                Show = false,
                Center = true,
                Resizable = true,
                Maximizable = true,
                AutoHideMenuBar = true,
                Icon = AppFiles.AppIcon,
                TitleBarStyle = TitleBarStyle.hiddenInset,
                WebPreferences = WebPreferences
            }
        );

        await _mainWindow.WebContents.Session.ClearCacheAsync();

        _mainWindow.LoadURL("https://vue-dev.nomercy.tv");

        _mainWindow.OnReadyToShow += () => _mainWindow.Show();

        _mainWindow.OnClose += () => _mainWindow.Hide();

        await Electron.IpcMain.On("hideToSystemTray", _ => { _mainWindow.Hide(); });

        return _mainWindow;
    }

    private static async Task<BrowserWindow?> SplashScreen()
    {
        _splashScreen = await Electron.WindowManager.CreateWindowAsync(
            new BrowserWindowOptions
            {
                Width = 600,
                Height = 300,
                Show = false,
                Center = true,
                Frame = false,
                Icon = AppFiles.AppIcon,
                WebPreferences = WebPreferences
            }
        );

        await _splashScreen.WebContents.Session.ClearCacheAsync();

        _splashScreen.LoadURL("https://cdn.nomercy.tv/splash.html");

        _splashScreen.OnReadyToShow += () => _splashScreen.Show();

        return _splashScreen;
    }

    private static async void TrayIcon()
    {
        var menu = new[]
        {
            new MenuItem
            {
                Label = "HomePage",
                Click = () =>
                    Electron
                        .WindowManager.BrowserWindows.First()
                        .LoadURL("https://nomercy.tv")
            },
            new MenuItem
            {
                Label = "Show Window",
                Click = () => _mainWindow?.Show()
            },
            new MenuItem
            {
                Label = "Exit",
                Click = () => Electron.App.Exit()
            }
        };

        await Electron.Tray.Show(AppFiles.AppIcon, menu);
        await Electron.Tray.SetToolTip("NoMercy MediaServer C#");

        // Electron.Tray.On("click", () => {
        //     mainWindow?.Show();
        // });
    }
    
    public static async Task Start()
    {
        if (!HybridSupport.IsElectronActive) return;

        var splashScreen = await SplashScreen();
        TrayIcon();

        if (splashScreen != null)
            splashScreen.OnReadyToShow += () =>
            {
                Task.Run(async () =>
                {
                    // await Task.Delay(5000);
                    var mainWindow = await MainWindow();
                    mainWindow.OnReadyToShow += () => { splashScreen?.Destroy(); };
                });
            };
    }
    
    private static WebPreferences WebPreferences =>
        new()
        {
            NodeIntegration = true,
            ContextIsolation = true,
            Webgl = true,
            Sandbox = false,
            WebSecurity = false,
            ScrollBounce = true
        };

}