using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_cutting_and_Merging_Tool
{
    public partial class Language : Form
    {
        private EnglishSelect englishselect;

        public Language()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Language_Load(object sender, EventArgs e)
        {

        }

        private void labelSinhala_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sinhala_Select().Show();
        }

        private void labelEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EnglishSelect().Show();

        }

        private void labelTamil_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TamilSelect().Show();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
