using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace PlannerN
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string ConfigPath = "config.ini";
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            IServiceCollection services = new ServiceCollection();

            if (!File.Exists(ConfigPath))
            {
                using (File.Create(ConfigPath)) { }
            }
            var configBuilder = new ConfigurationBuilder().AddIniFile(ConfigPath);
            IConfiguration config = configBuilder.Build();
            services.AddSingleton<IConfiguration>(config);

            services.AddTransient<MainWindow, MainWindow>();


            var provider = services.BuildServiceProvider();


            MainWindow mainWindow = provider.GetService<MainWindow>();
            mainWindow.Show();

        }
    }
}
