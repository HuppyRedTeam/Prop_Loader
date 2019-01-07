﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Prop_Loader
{
    public partial class Main_Form : Form
    {
        public StreamReader Output;
        public StreamWriter Input;
        public Thread t;

        public Main_Form()
        {
            InitializeComponent();
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
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
            this.Game_Mode.Text = fl.Getgame_mode();
            this.White_List.Text = fl.GetWhitelist();
        }

        private void start_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(WriteLog));
            t.Start();
        }

        public void WriteLog()
        {
            Server_Process sp = new Server_Process();
            Input = sp.GetInput();
            Output = sp.GetOutput();
            while (true)
            {
                Thread.Sleep(500);
                logbox.AppendText(Output.ReadLine() + "\n");

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
            System.Environment.Exit(0);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Input.WriteLine(input.Text + "\n");
            input.Text = "";
        }

        private void remote_Click(object sender, EventArgs e)
        {

        }
    }
}
