using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplitAudioFile
{
    public partial class AudioSlicer : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private TimeSpan currentTime;
        private TimeSpan startRecord;
        private TimeSpan stopRecord;
        private string fileName;
        private int time;
        public AudioSlicer()
        {
            InitializeComponent();
        }

        private void ShowNameT(object sender, EventArgs e)
        {
            showNameT.Text = fileName;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(fileName);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            ShowNameT(sender, e);
        }

        private void StartBtn(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(fileName);
                outputDevice.Init(audioFile);
            }
            timerAudio.Start();
            outputDevice.Play();
        }

        private void StopAudioBtn(object sender, EventArgs e)
        {
            timerAudio.Stop();
            outputDevice?.Stop();
            time = 0;
            showTime.Text = "00:00:00";
        }

        private void PauseAudioBtn(object sender, EventArgs e)
        {
            timerAudio.Stop();
            outputDevice?.Pause();
        }

        private void TimerAudio(object sender, EventArgs e)
        {
            time++;
            currentTime = TimeSpan.FromSeconds(time);
            showTime.Text = currentTime.ToString("hh\\:mm\\:ss");
        }

        private void StartRecordBtn(object sender, EventArgs e)
        {
            startRecord = currentTime;
        }

        private void StopRecordBtn(object sender, EventArgs e)
        {
            stopRecord = currentTime;
        }

        private void SaveRecordBtn(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                DefaultExt = "ogg",
                Filter = "ogg files (*.ogg)|*.ogg|All files (*.*)|*.*",
                FileName = nameRecordT.Text
            };
            saveFileDialog.ShowDialog();

            string output = saveFileDialog.FileName;

            TrimFile(fileName, output, startRecord, stopRecord);

            nameRecordT.Text = String.Empty;
            startRecord = TimeSpan.Zero;
            stopRecord = TimeSpan.Zero;
        }

        public static void TrimFile(string input, string output, TimeSpan start, TimeSpan end)
        {
            TimeSpan minimumTime = new TimeSpan(0, 0, 0);
            var reader = new AudioFileReader(input);
            TimeSpan totalSecond = reader.TotalTime;

            var trimmed = new OffsetSampleProvider(reader);
            if (start > minimumTime)
            {
                var deleteSecond = start.Subtract(TimeSpan.FromSeconds(1));
                trimmed.SkipOver = TimeSpan.FromSeconds(deleteSecond.TotalSeconds);
            }
            else
            {
                trimmed.SkipOver = TimeSpan.FromSeconds(start.TotalSeconds);
            }
            var getPieceFomAudio = end - start;

            trimmed.Take = TimeSpan.FromSeconds(getPieceFomAudio.TotalSeconds);

            WaveFileWriter.CreateWaveFile16(output, trimmed);
        }
    }
}
