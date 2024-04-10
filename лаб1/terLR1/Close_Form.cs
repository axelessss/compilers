using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terLR1
{
    public partial class Close_Form : Form
    {
        private bool save;

        public bool Save 
        {
            get => save;
        }

        public Close_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.save = true;
            this.Hide();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.save = false;
            this.Hide();
        }
    }
}
