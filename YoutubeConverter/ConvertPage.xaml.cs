using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
            var id = Input.Text;
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
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            System.IO.File.WriteAllText(@"D:\Facultate\Semestrul II\.NET\YoutubeConverter\response.json", body);
            Video video = JsonSerializer.Deserialize<Video>(body);

            // using StreamReader file = File.OpenText(@"D:\Facultate\Semestrul II\.NET\YoutubeConverter\response.json");
            // Video video = JsonSerializer.Deserialize<Video>(File.ReadAllText(@"D:\Facultate\Semestrul II\.NET\YoutubeConverter\response.json"));

            var filepath = @"D:\Facultate\Semestrul II\.NET\YoutubeConverter\";
            var extension = ".mp3";

            video.download(filepath, extension);
            NavigationService.Navigate(new PlayPage(video));
        }
    }
}
