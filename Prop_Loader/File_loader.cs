using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prop_Loader
{
    class File_loader
    {
        private string prop_path;
        private FileStream propfile;

        public File_loader(string prop_path)
        {
            this.prop_path = prop_path;
            try
            {
                propfile = File.OpenRead(prop_path);
            }catch(IOException e)
            {
                MessageBox.Show(e.ToString(), "server.prop文件不存在！", MessageBoxButtons.OK);
            }
        }

        public string Getpath()
        {
            return prop_path;
        }

        public string GetIP()
        {
            string N_IPAdress = null;

            if(N_IPAdress == null)
            {
                throw new PropFile_Exception("Format Error!");
            }
            return N_IPAdress;
        }
    }
}
