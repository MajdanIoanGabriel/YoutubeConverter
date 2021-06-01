using System.Windows;

namespace YoutubeConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _mainFrame.Navigate(new ConvertPage());
        }

    }
}
