using Microsoft.Extensions.Logging;
using PlannerN.Entity;
using System.Collections.Generic;
using System.Windows;


namespace PlannerN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ILogger<MainWindow> logger;

        public MainWindow(ILogger<MainWindow> logger)
        {
            this.logger = logger;

            logger.LogCritical("Test");
            InitializeComponent();
            var List = new List<Task>();

            var conn = new Context.PlannerContext();
            conn.Tasks.Add(new Task() { Description = "Задача" });
            conn.SaveChanges();
            // var List = conn.Tasks.ToList<Task>();

            ListView.ItemsSource = List;
            this.logger = logger;
        }


    }
}
