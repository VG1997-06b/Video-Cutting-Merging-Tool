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
    public partial class Sinhala_Select : Form
    {
        public Sinhala_Select()
        {
            InitializeComponent();
        }

        private void buttonBackS_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Language().Show();
        }

        private void labelSinhalaCut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SinhalaCut().Show();
        
         }

        private void labelSinhalaMerge_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SinhalaMerge().Show();

        }
    }
}
