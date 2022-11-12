using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_cutting_and_Merging_Tool
{
    public partial class EnglishMerge : Form
    {
        private object command;
        private object folderBrowserDialog1;
       
        public int iresult { get; private set; }

        public EnglishMerge()
        {
            InitializeComponent();
        }

        private void buttonAddE_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strFile = openFileDialog1.FileName;
                axTimelineControl1.AddVideoClip(1, strFile, 0, axTimelineControl1.GetMediaDuration(strFile), 0, 1);
                axTimelineControl1.AddAudioClip(5, strFile, 0, axTimelineControl1.GetMediaDuration(strFile), 0, (float)1.0);
            }

        }

        private void buttonPlayEM_Click(object sender, EventArgs e)
        {
            axTimelineControl1.Play();
        }

        private void buttonStopEM_Click(object sender, EventArgs e)
        {
            axTimelineControl1.Stop();
        }

        private void buttonMergeEM_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveEM_Click(object sender, EventArgs e)
        {
            
             axTimelineControl1.OutputType = 2;
             axTimelineControl1.MP4AspectRatio = 0;
             axTimelineControl1.MP4AudioBitrate = 96000;
             axTimelineControl1.MP4AudioChannels = 2;
             axTimelineControl1.MP4AudioSampleRate = 44100;
             axTimelineControl1.MP4Framerate = 100;
             axTimelineControl1.MP4H264Preset = 0;
        
           string outputFilename = $@"{txtOutputFolder.Text}\{outputFileNameTextBox.Text}{extensionComboBox.Text}";
            axTimelineControl1.GetTimelineDuration();
           
            string command = $"-i \"{outputFilename}\"";
            
            iresult = axTimelineControl1.Save(outputFilename);

            FfmpegHandler.ExecuteFFMpeg(command);
            
            Process.Start("explorer.exe", "/select, \"" + txtOutputFolder.Text + "\"");

            Application.Exit();
            
        }

        private void buttonBackEM_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EnglishSelect().Show();
        }

        private void buttoncloseEC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxPreview_Click(object sender, EventArgs e)
        {

        }


        private void axTimelineControl1_Enter(object sender, EventArgs e)
        {

        }

        private void EnglishMerge_Load(object sender, EventArgs e)
        {
            axTimelineControl1.SetPreviewWnd((int)pictureBoxPreview.Handle);
        }

        private void buttonScale01_Click(object sender, EventArgs e)
        {
            axTimelineControl1.SetScale((float)0.01);
        }

        private void buttonScale03_Click(object sender, EventArgs e)
        {
            axTimelineControl1.SetScale((float)0.03);
        }

        private void buttonRemoveEC_Click(object sender, EventArgs e)
        {
            axTimelineControl1.DeleteClip(01, 0);
            axTimelineControl1.DeleteClip(05, 0);

        }

        private void folderOpenButton_Click(object sender, EventArgs e)
        {
          /*  folderBrowserDialog2.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog2.SelectedPath;
            }*/
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtOutputFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderOpenButton_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog2.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void extensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
