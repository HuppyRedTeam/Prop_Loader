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
        private StreamReader propfile;

        public File_loader(string prop_path)
        {
            this.prop_path = prop_path;
            try
            {
                propfile = new StreamReader(File.OpenRead(prop_path));
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
            string result;
            while((result = propfile.ReadLine())!=null){

            }
            string[] readl = result.Split('=');
            Console.Write(readl[0]);
            if (readl[0].Equals("server-ip"))
            {
                if (readl[1] != null)
                {
                    N_IPAdress = readl[1];
                }
                else
                {
                    N_IPAdress = "0.0.0.0";
                }
            }
            if(N_IPAdress == null)
            {
                throw new PropFile_Exception("Format Error!");
            }
            return N_IPAdress;
        }
    }
}
