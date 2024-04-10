using FileMaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace terLR1
{
    public partial class Form1 : Form
    {
        bool isDataDirty = false;

        private string form_text;
        private static File_Form file_form; 

        public Form1()
        {
            InitializeComponent();
            form_text = this.Text;
            inputBox.Hide();
            outputBox.Hide();
            this.Closing += Form1_Closing;
        }
    
        private void Create_File()
        {
            
            inputBox.Show();
            outputBox.Show();
            file_form = null;
            this.Text = form_text + " | Undefined";
            this.inputBox.Text = null;
        }

        private void Open_File()
        {
            OpenFileForm open_file = new OpenFileForm();
            open_file.ShowDialog();

            if (open_file.PathText != null)
            {
                file_form = new File_Form(open_file.PathText);
                file_form.Open_File();
                this.Text = form_text + " | " + open_file.PathText;
                this.inputBox.Text = file_form.Readen;
            }
        }

        private void Save_File()
        {
            if (file_form == null)
                Save_As();
            else
            {
                string text = inputBox.Text;
                file_form.Save_File(ref text);
            }

            
        }

        private void Save_As()
        {
            CreateSaveForm create_save_form = new CreateSaveForm(1);
            string text = inputBox.Text;
            create_save_form.ShowDialog();

            if (create_save_form.PathText != null)
            {
                file_form = new File_Form(create_save_form.PathText);
                file_form.Save_File(ref text);
                this.Text = form_text + " | " + create_save_form.PathText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void createfileMenu_Click(object sender, EventArgs e)
        {
            if (isDataDirty)
            {
                DialogResult result = MessageBox.Show("Файл не был сохранен. Хотите сохранить?", "Несохраненный файл", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        Save_File();
                        Create_File();
                        break;
                    case DialogResult.No:
                        Create_File();
                        break;
                }

            }

            else
                Create_File();
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            if (isDataDirty)
            {
                DialogResult result = MessageBox.Show("Файл не был сохранен. Хотите сохранить?", "Несохраненный файл", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        Save_File();
                        Open_File();
                        break;
                    case DialogResult.No:
                        Open_File();
                        break;
                }
            }
            else
                Open_File();
        }

        private void savefileMenu_Click(object sender, EventArgs e)
        {
            Save_File();
        }

        private void saveasMenu_Click(object sender, EventArgs e)
        {
            Save_As();
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            if (isDataDirty)
            {
                DialogResult result = MessageBox.Show("Файл не был сохранен. Хотите сохранить?", "Несохраненный файл", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        Save_File();
                        Create_File();
                        break;
                    case DialogResult.No:
                        Create_File();
                        break;
                }
            }
            else
                Create_File();
        }
       

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (isDataDirty)
            {
                DialogResult result = MessageBox.Show("Файл не был сохранен. Хотите сохранить?", "Несохраненный файл", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        Save_File();
                        Open_File();
                        break;
                    case DialogResult.No:
                        Open_File();
                        break;
                }
            }
            else
                Open_File();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save_File();
        }

        private void exitfileMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelMenu_Click(object sender, EventArgs e)
        {
            inputBox.Undo();
        }

        private void repeatMenu_Click(object sender, EventArgs e)
        {
            inputBox.Redo();
        }

        private void cutMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(inputBox.SelectedText);
            }

            catch
            {
                MessageBox.Show("Выделите текст!");
            }

            finally
            {
                inputBox.SelectedText = "";
            }
        }

        private void copyMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(inputBox.SelectedText);
            }
            catch
            {
                MessageBox.Show("Выделите текст!");
            }

            finally { }
        }

        private void pasteMenu_Click(object sender, EventArgs e)
        {
            inputBox.SelectedText = Clipboard.GetText();
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            inputBox.Text = null;
        }

        private void chooseallMenu_Click(object sender, EventArgs e)
        {
            inputBox.SelectAll();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            inputBox.Undo();
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            inputBox.Redo();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(inputBox.SelectedText);
            }
            catch
            {
                MessageBox.Show("Выделите текст!");
            }

            finally { }

        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(inputBox.SelectedText);
            }

            catch
            {
                MessageBox.Show("Выделите текст!");
            }

            finally 
            {
                inputBox.SelectedText = "";
            }
            
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            inputBox.SelectedText = Clipboard.GetText();
        }

        private void referenceMenu_Click(object sender, EventArgs e)
        {
            Reference_Form reference = new Reference_Form();
            reference.Show();
        }

        private void aboutProg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор с анализом введённого текста\nВерсия 0.0.1");
        }

        private void referenceButton_Click(object sender, EventArgs e)
        {
            Reference_Form reference = new Reference_Form();
            reference.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор с анализом введённого текста\nВерсия 0.0.1");
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            this.isDataDirty = true;
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            if (isDataDirty)
            {
                DialogResult result = MessageBox.Show("Файл не был сохранен. Хотите сохранить?", "Несохраненный файл", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        Save_File();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
