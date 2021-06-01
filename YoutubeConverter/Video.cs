using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace YoutubeConverter
{
    #pragma warning disable IDE1006 // Naming Styles
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

        #pragma warning restore IDE1006 // Naming Styles

        private void RemoveIllegalChars()
        {
            var charsToRemove = new string[] { "/", "\\", ":", "*", "?", "\"", "<", ">", "|" };
            foreach (var c in charsToRemove)
            {
                vidTitle = vidTitle.Replace(c, string.Empty);
            }
        }

        public void Download()
        {
            RemoveIllegalChars();
            var client = new WebClient();

            SaveFileDialog saveFileDialog1 = new()
            {
                Filter = "MP3 file (*.mp3)|*.mp3",
                Title = "Save audio File",
                FileName = vidTitle
            };

            if (saveFileDialog1.ShowDialog() == true) {

                if (saveFileDialog1.FileName != "") {
                    path = saveFileDialog1.FileName;
                    vidTitle = Path.GetFileName(path);
                    client.DownloadFile(vidInfo["0"].dloadUrl, path);
                }
                else {
                    throw (new Exception());
                }
                    
            }
            else {
                throw (new Exception());
            }

        }

    }

}
