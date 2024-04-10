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
    public partial class CreateSaveForm : Form
    {
        private string pathText;

        public string PathText
        {
            get => pathText;
        }

        public CreateSaveForm(int status)
        {
            InitializeComponent();

            if (status == 0)
                this.Text = "Создать файл";
            else
                Text = "Сохранить файл как";
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                pathBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (pathBox.Text.Length == 0 || nameBox.Text.Length == 0)
                MessageBox.Show("Оба поля должны быть заполнены!");
            else
            {
                this.Hide();
                pathText = pathBox.Text + "\\" + nameBox.Text;
            }
        }
    }
}
