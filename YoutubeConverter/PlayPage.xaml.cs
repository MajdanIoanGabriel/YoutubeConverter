using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace YoutubeConverter
{
    /// <summary>
    /// Interaction logic for PlayPage.xaml
    /// </summary>
    public partial class PlayPage : Page
    {
        private Video Video { get; set; }
        private readonly MediaPlayer mediaPlayer = new();
        public PlayPage(Video new_video)
        {
            InitializeComponent();
            Video = new_video;
            video_title.Content = Video.vidTitle;

            mediaPlayer.Open(new Uri(Video.path));

            DispatcherTimer timer = new();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan && mediaPlayer.Source != null)
                lblStatus.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            else
                lblStatus.Content = "No file selected...";
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            NavigationService.Navigate(new ConvertPage());
        }
    }
}
