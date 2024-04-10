using FileMaker;
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
    public partial class Reference_Form : Form
    {
        public Reference_Form()
        {
            InitializeComponent();
            Show_Info();
        }

        private void Show_Info()
        {
            File_Form file = new File_Form("README.txt");
            file.Open_File();
            referenceBox.Text = file.Readen;
        }
    }
}
