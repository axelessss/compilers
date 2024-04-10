using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMaker
{
    public class File_Form
    {
        public FileStream file;
        private string path;
        private string readen;

        public string Readen
        {
            get => readen;
        }

        public string Path
        {
            get => path;
        }
        public File_Form(string path)
        {
            this.path = path;
        }

        public void Create_File()
        {
            file = new FileStream(this.path, FileMode.Create);
        }

        public void Save_File(ref string text)
        {
            using (file = new FileStream(path, FileMode.Create))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(text);
                file.Write(buffer, 0, buffer.Length);
            }
        }

        public void Open_File()
        {
            using (file = new FileStream(this.path, FileMode.Open))
            {
                byte[] buffer = new byte[file.Length];
                file.Read(buffer, 0, buffer.Length);
                this.readen = Encoding.UTF8.GetString(buffer);
            }
        }
    }
}
