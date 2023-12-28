using ElectronNET.API;
using Microsoft.AspNetCore;
using NoMercy.Server.Helpers;

namespace NoMercy.Server;

public abstract class Program
{
    public static void Main(string[] args)
    {
        var builder = CreateWebHostBuilder(args).Build();
        builder.Run();
    }

    private static IWebHostBuilder CreateWebHostBuilder(string[] args)
    {
        AppFiles.CreateAppFolders();
        Networking.Discover();
        Auth.Init();
        
        Task.Run(async () =>
        {
            await ApiInfo.RequestInfo();
            await Binaries.DownloadAll();
            await Register.Init();
        }).Wait();
        
        return WebHost.CreateDefaultBuilder()
            .ConfigureKestrel(Certificate.KestrelConfig)
            .UseElectron(args)
            .UseUrls("https://0.0.0.0:7626")
            .UseStartup<Startup>();
    }

}