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
        public bool IsFullscreen { get; set; } = false;

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
                this.WindowState = WindowState.Normal;
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                IsFullscreen = false;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None;
                IsFullscreen = true;
            }
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Play_button_Click(object sender, RoutedEventArgs e)
        {
            MainMenuGrid.Visibility = Visibility.Collapsed;
            SizeSelectionPanel.Visibility = Visibility.Visible;
       
        }

      
        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            SizeSelectionPanel.Visibility = Visibility.Hidden;
            MainMenuGrid.Visibility = Visibility.Hidden;

        }

        private void CancelSizeSelection_Click(object sender, RoutedEventArgs e)
        {
            SizeSelectionPanel.Visibility = Visibility.Collapsed;
            MainMenuGrid.Visibility = Visibility.Visible;
        }
    }
}