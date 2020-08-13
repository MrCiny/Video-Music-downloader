using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace PlaylistPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveMP3(string SaveToFolder, string VideoURL, string MP3Name)
        {
            var source = @SaveToFolder;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

            var inputFile = new MediaFile { Filename = source + vid.FullName };
            var outputFile = new MediaFile { Filename = MP3Name };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }
        }

        private void Mp4Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function hasn't been implemented yet");
        }

        private void Mp3Button_Click(object sender, EventArgs e)
        {
            string url = URLInserter.Text;

            if (url != null)
            {
                SaveFileDialog saveMp3File = new SaveFileDialog();
                saveMp3File.Title = "Save an MP3 file";
                saveMp3File.FileName = "*.mp3";
                saveMp3File.DefaultExt = "mp3";


                DialogResult result = saveMp3File.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string fileName = saveMp3File.FileName;
                    string filePath = saveMp3File.InitialDirectory;

                    SaveMP3(filePath, url, fileName);
                }
            }
            return;
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Added an (Download as MP3) function");
        }

        private void UFButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                            "+ SoundCloud support \n " +
                            "+ Spotify support \n " +
                            "+ MP4 support"
                           );
        }
    }
}
