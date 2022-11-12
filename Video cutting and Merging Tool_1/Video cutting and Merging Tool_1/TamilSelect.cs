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
    public partial class TamilSelect : Form
    {
        public TamilSelect()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Language().Show();
        }

        private void labelTamilCut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TamilCut().Show();
        }

        private void labelTamilMerge_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TamilMerge().Show();

        }
    }
}
