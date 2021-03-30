using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YoutubeConverter
{
    /// <summary>
    /// Interaction logic for DownloadPage.xaml
    /// </summary>
    public partial class DownloadPage : Page
    {
        private Video video { get; set; }
        public DownloadPage(Video new_video)
        {
            InitializeComponent();
            video = new_video;

            video_title.Content = video.vidTitle;
            video_duration.Content = video.duration;
            video_bitrate.ItemsSource = video.vidInfo.Values;
            video_size.Content = video.vidInfo["0"].mp3size;

            List<string> bitrates = new List<string>();

            for(Info info: video.vidInfo.Values())
            {

            }

        }
    }
}
