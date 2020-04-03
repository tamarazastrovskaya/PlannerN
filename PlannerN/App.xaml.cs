using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PlannerN.Entity;
using PlannerN.Services;
using System.IO;
using System.Windows;

namespace PlannerN
{

    public partial class App : Application
    {

        private void OnStartUp(object sender, StartupEventArgs e)
        {
            string configPath = "config.ini";

            IServiceCollection services = new ServiceCollection();

            services.AddSingleton(LogFactory<App>.CreateLog);
            services.AddScoped<Config>();


            if (!File.Exists(configPath))
            {
                File.Create(configPath).Close();
            }
            var configBuilder = new ConfigurationBuilder().AddIniFile(configPath);
            IConfiguration config = configBuilder.Build();
            services.AddSingleton<IConfiguration>(config);



            string
                host = config.GetValue<string>("host"),
                user = config.GetValue<string>("user"),
                dbname = config.GetValue<string>("dbname"),
                dbpass = config.GetValue<string>("dbpass");

            string Dsn =
                $"Server ={host}; Database = {dbname};User = {dbpass}; Password ={dbpass}";
            var context = new Context.AppContext(Dsn);
            services.AddSingleton<Context.AppContext>(context);

            Category el1 = context.categories.Find(1);

            context.categories.Create();


            services.AddTransient<FirstService>();
            services.AddTransient<MainWindow>();


            ServiceProvider provider = services.BuildServiceProvider();


            MainWindow window = provider.GetService<MainWindow>();
            Logger<App> logger = provider.GetService<Logger<App>>();

            logger.LogInformation("Test");
            window.Show();
        }
    }
}
