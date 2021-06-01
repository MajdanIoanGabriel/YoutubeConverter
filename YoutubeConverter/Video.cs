using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void removeIllegalChars()
        {
            var charsToRemove = new string[] { "/", "\\", ":", "*", "?", "\"", "<", ">", "|" };
            foreach (var c in charsToRemove)
            {
                vidTitle = vidTitle.Replace(c, string.Empty);
            }
        }

        public void download()
        {
            removeIllegalChars();
            var client = new WebClient();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "MP3 file (*.mp3)|*.mp3";
            saveFileDialog1.Title = "Save audio File";
            saveFileDialog1.FileName = vidTitle;

            if(saveFileDialog1.ShowDialog() == true) {

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
