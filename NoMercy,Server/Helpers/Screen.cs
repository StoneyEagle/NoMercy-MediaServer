using System.Runtime.InteropServices;

namespace NoMercy.Server.Helpers;

public static class Screen
{
    public static int GetScreenWidth()
    {
        return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? GetScreenWidthWindows() : 1666;
    }

    [DllImport("user32.dll")]
    private static extern int GetSystemMetrics(int nIndex);

    private static int GetScreenWidthWindows(int screenIndex = 0)
    {
        return GetSystemMetrics(screenIndex);
    }
}