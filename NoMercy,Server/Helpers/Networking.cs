using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore;
using Mono.Nat;

namespace NoMercy.Server.Helpers;

public abstract class Networking
{
    private static INatDevice? _device;

    public static void Discover()
    {
        NatUtility.DeviceFound += DeviceFound;

        NatUtility.StartDiscovery();
    }

    public static string InternalIp => GetInternalIp() ?? "";
    private static string ExternalIp { get; set; } = "";
    public static int InternalServerPort { get; set; } = 7626;
    public static int ExternalServerPort { get; set; } = 7626;
    
    public static string InternalAddress { get; set; } = $@"https://{Regex.Replace(InternalIp, @"\.", "-")}.{SystemInfo.DeviceId}.nomercy.tv:7626";
    
    public static string ExternalAddress { get; set; } = $@"https://{Regex.Replace(ExternalIp ?? "", @"\.", "-")}.{SystemInfo.DeviceId}.nomercy.tv:7626";

    private static string? GetInternalIp()
    {
        using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0);

        socket.Connect("1.1.1.1", 65530);

        var endPoint = socket.LocalEndPoint as IPEndPoint;

        var localIp = endPoint?.Address.ToString();

        return localIp;
    }

    private static string GetExternalIp()
    {
        var client = new HttpClient();

        var externalIp = client.GetStringAsync("https://api-dev2.nomercy.tv/server/ip").Result;

        return externalIp;
    }

    private static void DeviceFound(object? sender, DeviceEventArgs args)
    {
        _device = args.Device;

        _device.CreatePortMap(new Mapping(Protocol.Tcp, 7626, 7626, 9999999, "NoMercy MediaServer (TCP)"));
        _device.CreatePortMap(new Mapping(Protocol.Udp, 7626, 7626, 9999999, "NoMercy MediaServer (UDP)"));

        ExternalIp = _device.GetExternalIP().ToString();
        if (ExternalIp == "") ExternalIp = GetExternalIp();

        Console.WriteLine(@"External IP discovered: " + ExternalIp);
    }
    
    public static IWebHost TempServer()
    {
        return WebHost.CreateDefaultBuilder()
            .UseUrls("http://0.0.0.0:" + InternalServerPort)
            .Configure(app =>
        {
            app.Run(async context =>
            {
                var code = context.Request.Query["code"].ToString();
                
                Auth.GetTokenByAuthorizationCode(code);
                
                context.Response.Headers.Append("Content-Type", "text/html");
                await context.Response.WriteAsync("<script>window.close();</script>");
            });
        }).Build();
    }
}