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
    public partial class OpenFileForm : Form
    {
        private string pathText;

        public string PathText
        {
            get => pathText;
        }

        public OpenFileForm()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (pathBox.Text.Length == 0)
                MessageBox.Show("Поле не должно быть пустым!");
            else
            {
                this.Hide();
                pathText = pathBox.Text;
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pathBox.Text = openFileDialog.FileName;
        }
    }
}
