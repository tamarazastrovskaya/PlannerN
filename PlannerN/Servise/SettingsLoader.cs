using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;

namespace PlannerN.Services
{
    class SettingsLoader
    {
        public static IniConfigurationProvider LoadSettings()
        {
            IniConfigurationSource source = new IniConfigurationSource();
            source.Path = "Settings.ini";
            IniConfigurationProvider settings = (IniConfigurationProvider)source.Build(new ConfigurationBuilder());
            settings.Load();
            return settings;
        }
    }
}
