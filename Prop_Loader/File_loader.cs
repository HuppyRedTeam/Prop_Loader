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
            } catch (IOException e)
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
            string result;
            try
            {
                result = Getvalue("server-ip");
                if (result.Equals(""))
                {
                    return "0.0.0.0";
                }
                else
                {
                    return result;
                }
            }catch(PropFile_Exception e)
            {
                MessageBox.Show(e.ToString(), "错误", MessageBoxButtons.OK);
                return "错误";
            }
        }

        public string GetPort()
        {
            string result;
            try
            {
                result = Getvalue("server-port");
                return result;
            }catch(PropFile_Exception e)
            {
                MessageBox.Show(e.ToString(), "错误", MessageBoxButtons.OK);
                return "错误";
            }
        }

        public string GetMaxplayer()
        {
            string result;
            try
            {
                result = Getvalue("max-players");
                return result;
            }
            catch (PropFile_Exception e)
            {
                MessageBox.Show(e.ToString(), "错误", MessageBoxButtons.OK);
                return "错误";
            }
        }

        private string Getvalue(string valuename)
        {
            propfile = new StreamReader(File.OpenRead(prop_path));
            string[] readl;
            string readb;
            while((readb = propfile.ReadLine())!=null){
                readl = readb.Split('=');
                if (readl[0].Equals(valuename))
                {
                    propfile.Close();
                    return readl[1]; 
                }
            }
            propfile.Close();
            throw new PropFile_Exception("未能读取变量"+valuename);
        }

        public string Getgame_mode()
        {
            string result;
            try
            {
                result = Getvalue("gamemode");
                if (result.Equals("0"))
                {
                    return "生存模式";
                }
                if (result.Equals("1"))
                {
                    return "创造模式";
                }
                if (result.Equals("2"))
                {
                    return "观察模式";
                }
                return "其他模式";
            }
            catch (PropFile_Exception e)
            {
                MessageBox.Show(e.ToString(), "错误", MessageBoxButtons.OK);
                return "错误";
            }
        }

        public string GetWhitelist()
        {
            string result;
            try
            {
                result = Getvalue("white-list");
                return result;
            }
            catch (PropFile_Exception e)
            {
                MessageBox.Show(e.ToString(), "错误", MessageBoxButtons.OK);
                return "错误";
            }
        }
    }
}
