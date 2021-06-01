using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace YoutubeConverter
{
    /// <summary>
    /// Interaction logic for ConvertPage.xaml
    /// </summary>
    public partial class ConvertPage : Page
    {
        public ConvertPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var idLength = 11;  // Youtube video ID lenght is 11
            var id = Input.Text;
            var pos = id.IndexOf("v=");

            if (pos < 0 || (id.Length < pos + 2 + idLength))
            {
                MessageBox.Show("Invalid link given!", "Error");
                return;
            }

            id = id.Substring(pos + 2, idLength);

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://download-video-youtube1.p.rapidapi.com/mp3/" + id),
                Headers =
                {
                    { "x-rapidapi-key", "646a7edddbmsh2e7804d95936819p1a928djsn76645304dbce" },
                    { "x-rapidapi-host", "download-video-youtube1.p.rapidapi.com" },
                },
            };
            using var response = await client.SendAsync(request);
            try { 
                response.EnsureSuccessStatusCode(); 
            }
            catch(Exception) {
                MessageBox.Show("Invalid link given!", "Error");
                return;
            }
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Video video = JsonSerializer.Deserialize<Video>(body);

            try {
                video.Download();
            }
            catch (Exception) {
                MessageBox.Show("No filename entered!", "Error");
                return;
            }

            NavigationService.Navigate(new PlayPage(video));
        }
    }
}
