using HelloApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

public class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

        // получаем конфигурацию из файла appsettings.json
        ConfigurationBuilder builder = new ConfigurationBuilder();
        builder.SetBasePath(@"D:\Programming\C#\Databases\DatabasesApp\HelloApp");
        builder.AddJsonFile("appsettings.json");
        IConfigurationRoot config = builder.Build();

        // получаем строку подключения из файла appsettings.json
        string connectionString = config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
        return new ApplicationContext(optionsBuilder.Options);
        //return new ApplicationContext(config.GetConnectionString("DefaultConnection");
    }
}