using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeConverter
{
    public class Info
    {
        public string dloadUrl { get; set; }

        public int bitrate { get; set; }

        public string mp3size { get; set; }
    }

    public class Video
    {
        public string vidID { get; set; }
        public string vidTitle { get; set; }
        public string vidThumb { get; set; }
        public double duration { get; set; }
        public Dictionary<string, Info> vidInfo { get; set; }
        public string path { get; set; }

        public void download(string filepath, string extension)
        {
            var client = new WebClient();
            path = filepath + vidTitle + extension;
            client.DownloadFile(vidInfo["0"].dloadUrl, path);
        }

    }

}
