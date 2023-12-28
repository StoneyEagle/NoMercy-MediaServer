using System.IO.Compression;
using System.Runtime.InteropServices;

namespace NoMercy.Server.Helpers;

public static class Binaries
{
    private static List<Download> Downloads { get; }
    
    private static readonly HttpClient Client = new ();
    
    static Binaries()
    {
        Client.DefaultRequestHeaders.Add("User-Agent", "NoMercy/Server");
        
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            Downloads = Startup.ApiInfo?.Data.Downloads.Linux ?? [];
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            Downloads = Startup.ApiInfo?.Data.Downloads.Mac ?? [];
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            Downloads = Startup.ApiInfo?.Data.Downloads.Windows ?? [];
        else
            Downloads = [];
    }

    public static async  Task DownloadAll()
    {
        
        foreach (Download program in Downloads)
        {
            await Download(program);
            await Extract(program);
            await Cleanup(program);
        }
    }


    private static async Task Download(Download program)
    {
        Console.WriteLine($@"Downloading {program.Name}");
        
        var result = await Client.GetAsync(program.Url);
        var content = await result.Content.ReadAsByteArrayAsync();
        
        string baseName = Path.GetFileName(program.Url?.ToString() ?? "");
        
        await File.WriteAllBytesAsync(Path.Combine(AppFiles.BinariesPath, baseName), content);
    }

    private static async Task Extract(Download program)
    {
        string sourceArchiveFileName = Path.Combine(AppFiles.BinariesPath, Path.GetFileName(program.Url?.ToString() ?? ""));
        string destinationDirectoryName = Path.Combine(AppFiles.BinariesPath, program.Name);
        
        Console.WriteLine($@"Extracting {program.Name}");
        
        if(Directory.Exists(destinationDirectoryName))
            Directory.Delete(destinationDirectoryName, true);
        
        ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
        
        File.Delete(sourceArchiveFileName);
        
        await Task.Delay(0);
    }
    
    private static async Task Cleanup(Download program)
    {
        if (program.Filter == "")
        {
            await Task.Delay(0);
            return;
        }

        string workingDir = Path.Combine(AppFiles.BinariesPath, program.Name, program.Filter);
        foreach (string file in Directory.GetFiles(workingDir))
        {
            string filter = Path.DirectorySeparatorChar + program.Filter;
            string dirName = file.Replace(filter, "");
            
            File.Move(file, dirName);
        }
        
        Directory.Delete(workingDir);
    }
}