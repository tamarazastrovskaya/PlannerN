using Microsoft.Extensions.Logging;
using System.Windows;


namespace PlannerN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(FirstService firstService, Logger<App> logger)
        {
            logger.LogCritical("Test");
            InitializeComponent();
        }
    }
}
