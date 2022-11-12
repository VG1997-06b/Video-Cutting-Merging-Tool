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
    public partial class SinhalaCut : Form
    {
        public SinhalaCut()
        {
            InitializeComponent();
        }

       

        private void SinhalaCut_Load(object sender, EventArgs e)
        {

        }


        private void ButtonCUT_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt16(startTextBox.Text);
            int end = Convert.ToInt16(endTextBox.Text);
            string outputFilename = $@"{txtOutputFolder.Text}\{outputFileNameTextBox.Text}{extensionComboBox.Text}";
            string command = $"-i \"{txtInputFile.Text}\" -ss {start} -t {end} \"{outputFilename}\"";

            FfmpegHandler.ExecuteFFMpeg(command);

            Process.Start("explorer.exe", "/select, \"" + txtOutputFolder.Text + "\"");

            Application.Exit();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openFileDialog1.FileName;
            }
        }

        private void folderOpenButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void buttoncloseEC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sinhala_Select().Show();
        }
    }
}
