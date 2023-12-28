// ReSharper disable MemberCanBePrivate.Global

namespace NoMercy.Server.Helpers;

public static class AppFiles
{
    public static readonly string AppDataPath =
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

    public static readonly string AppPath = Path.Combine(AppDataPath, "NoMercy_C#");

    public static readonly string CachePath = Path.Combine(AppPath, "Cache");
    public static readonly string ConfigPath = Path.Combine(AppPath, "config");
    public static readonly string TokenFile = Path.Combine(ConfigPath, "token.json");
    public static readonly string ConfigFile = Path.Combine(ConfigPath, "config.json");
    
    public static readonly string DataPath = Path.Combine(AppPath, "data");
    
    public static readonly string LogPath = Path.Combine(AppPath, "log");
    public static readonly string MetadataPath = Path.Combine(AppPath, "metadata");
    public static readonly string PluginsPath = Path.Combine(AppPath, "plugins");
    public static readonly string RootPath = Path.Combine(AppPath, "root");

    public static readonly string ApiCachePath = Path.Combine(CachePath, "apiData");
    public static readonly string ImagesPath = Path.Combine(CachePath, "images");
    public static readonly string OmdbPath = Path.Combine(CachePath, "omdb");
    public static readonly string TempPath = Path.Combine(CachePath, "temp");
    public static readonly string TranscodePath = Path.Combine(CachePath, "transcode");

    public static readonly string CollectionsPath = Path.Combine(DataPath, "collections");
    public static readonly string PlaylistsPath = Path.Combine(DataPath, "playlists");
    public static readonly string ScheduledTasksPath = Path.Combine(DataPath, "ScheduledTasks");
    public static readonly string SubtitlesPath = Path.Combine(DataPath, "subtitles");
    public static readonly string PluginConfigPath = Path.Combine(PluginsPath, "configurations");
    public static readonly string UserDataPath = Path.Combine(DataPath, "userData");

    public static readonly string PeoplePath = Path.Combine(MetadataPath, "people");
    public static readonly string LibraryPath = Path.Combine(MetadataPath, "library");
    public static readonly string ViewsPath = Path.Combine(MetadataPath, "views");

    public static readonly string BinariesPath = Path.Combine(RootPath, "binaries");
    
    public static readonly string FfmpegPath = Path.Combine(BinariesPath, "ffmpeg/ffmpeg" + SystemInfo.ExecSuffix);
    public static readonly string FfProbePath = Path.Combine(BinariesPath, "ffmpeg/ffprobe" + SystemInfo.ExecSuffix);
    public static readonly string FpCalcPath = Path.Combine(BinariesPath, "fpcalc/fpcalc" + SystemInfo.ExecSuffix);
    public static readonly string SubtitleEdit = Path.Combine(BinariesPath, "subtitleedit/SubtitleEdit" + SystemInfo.ExecSuffix);
    
    public static readonly string CertPath = Path.Combine(RootPath, "certs");
    public static readonly string CertFile = Path.Combine(CertPath, "cert.pem");
    public static readonly string KeyFile = Path.Combine(CertPath, "key.pem");
    public static readonly string CaFile = Path.Combine(CertPath, "ca.pem");
    
    public static readonly string AppIcon = Path.Combine(Directory.GetCurrentDirectory(), "Assets/icon.ico");
    
    public static readonly string MediaDatabase = Path.Combine(DataPath, "media.db");
    public static readonly string QueueDatabase = Path.Combine(DataPath, "queue.db");

    public static List<string> AllPaths()
    {
        return [
            AppDataPath,
            AppPath,
            CachePath,
            ConfigPath,
            DataPath,
            LogPath,
            MetadataPath,
            PluginsPath,
            RootPath,
            ApiCachePath,
            ImagesPath,
            OmdbPath,
            TempPath,
            TranscodePath,
            CollectionsPath,
            PlaylistsPath,
            ScheduledTasksPath,
            SubtitlesPath,
            PluginConfigPath,
            UserDataPath,
            PeoplePath,
            LibraryPath,
            ViewsPath,
            BinariesPath,
            CertPath
        ];
    }

    public static void CreateAppFolders()
    {
        if (!Directory.Exists(AppPath)) 
            Directory.CreateDirectory(AppPath);

        foreach (var path in AllPaths().Where(path => !Directory.Exists(path)))
        {
            Console.WriteLine($@"Creating directory: {path}");
            Directory.CreateDirectory(path);
        }
    }
    
}