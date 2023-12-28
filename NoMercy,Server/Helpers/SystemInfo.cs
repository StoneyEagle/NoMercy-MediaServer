using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using DeviceId;

namespace NoMercy.Server.Helpers;

public static class SystemInfo
{
    public static readonly string DeviceName = "VLIEGTUIG!";
    public static readonly string DeviceId = GetDeviceId();
    public static readonly string Platform = GetPlatform();
    public static readonly string ExecSuffix = Platform == "windows" ? ".exe" : "";

    
    private static string GetDeviceId()
    {
        string generatedId = new DeviceIdBuilder()
            .AddMachineName()
            .AddOsVersion()
            .OnWindows(windows => windows
                .AddProcessorId()
                .AddMotherboardSerialNumber()
                .AddSystemDriveSerialNumber())
            .OnLinux(linux => linux
                .AddMotherboardSerialNumber()
                .AddSystemDriveSerialNumber())
            .OnMac(mac => mac
                .AddSystemDriveSerialNumber()
                .AddPlatformSerialNumber())
            .ToString();

        byte[] hash = MD5.HashData(Encoding.UTF8.GetBytes(generatedId));

        return new Guid(hash).ToString();
    }
    private static string GetPlatform()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return "windows";
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return "mac";
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return "linux";
        
        throw new Exception("Unknown platform");
    }
}