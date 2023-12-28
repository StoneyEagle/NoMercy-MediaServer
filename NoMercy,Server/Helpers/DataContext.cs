namespace NoMercy.Server.Helpers;
using Microsoft.EntityFrameworkCore;

public class MediaDbContext(IConfiguration configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={AppFiles.MediaDatabase}");
    }
}
public class QueueDbContext(IConfiguration configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={AppFiles.QueueDatabase}");
    }
}