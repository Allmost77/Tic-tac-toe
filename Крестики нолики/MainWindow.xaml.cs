using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Крестики_нолики
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsFullscreen { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Settings_button_Click(object sender, RoutedEventArgs e)
        {
            MainMenuGrid.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Visible;
        }

        private void CloseSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsPanel.Visibility = Visibility.Collapsed;
            MainMenuGrid.Visibility = Visibility.Visible;
        }

        private void FullscreenCheckbox_Click(object sender, RoutedEventArgs e)
        {
            if (IsFullscreen)
            {
                WindowState = WindowState.Maximized;
                WindowStyle = WindowStyle.None;
            }
            else
            {
                WindowState = WindowState.Normal;
                WindowStyle = WindowStyle.SingleBorderWindow;
            }
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}