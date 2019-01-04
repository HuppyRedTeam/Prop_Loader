using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prop_Loader
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            File_loader fl = new File_loader(System.Environment.CurrentDirectory + @"\server.properties");
            this.Bind_IP.Text = fl.GetIP();
            this.Prop_path.Text = fl.Getpath();
            this.Bind_Port.Text = fl.GetPort();
            this.Max_Player.Text = fl.GetMaxplayer();
        }
    }
}
