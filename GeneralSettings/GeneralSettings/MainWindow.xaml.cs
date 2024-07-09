using System.Windows;
using System.Windows.Input;

namespace GeneralSettings
{
    public partial class MainWindow : Window
    {
        // MainWindow constructor
        public MainWindow()
        {
            InitializeComponent(); // XAML bileşenlerini başlatır
        }

        // Pencere fare ile sürüklendiğinde çağrılan olay işleyici
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Sol fare tuşuna basıldığında pencereyi sürükleme işlemi başlatılır
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        // Pencereyi simge durumuna küçültmek için olay işleyici
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            // Uygulamanın ana penceresini simge durumuna küçült
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        // Pencere durumunu değiştirmek için olay işleyici
        private void WindowStateButton_Click(object sender, RoutedEventArgs e)
        {
            // Pencere durumunu kontrol eder ve değiştirir (büyütme/küçültme)
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;
        }

        // Uygulamayı kapatmak için olay işleyici
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Uygulamayı kapatır
            Application.Current.Shutdown();
        }
    }
}
