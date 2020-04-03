using Microsoft.Extensions.Configuration.Ini;

namespace PlannerN.Services
{
    class Settings
    {
        private static IniConfigurationProvider instanceSettings;
        public static IniConfigurationProvider InstanceSettings { get => instanceSettings; }

        static Settings()
        {
            instanceSettings = SettingsLoader.LoadSettings();
        }
    }
}
