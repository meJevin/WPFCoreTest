using System.Windows;

namespace WPFAppCore
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Todo: initialize update manager
        }

        private async void CheckForUpdatesButton_Click(object sender, RoutedEventArgs e)
        {
            // Todo: check for updates
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Todo: update app
        }
    }
}
