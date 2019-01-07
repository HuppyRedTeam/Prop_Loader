namespace Prop_Loader
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refresh = new System.Windows.Forms.Button();
            this.Disk_Usage = new System.Windows.Forms.Label();
            this.Memory_Usage = new System.Windows.Forms.Label();
            this.CPU_Usage = new System.Windows.Forms.Label();
            this.White_List = new System.Windows.Forms.Label();
            this.Game_Mode = new System.Windows.Forms.Label();
            this.Max_Player = new System.Windows.Forms.Label();
            this.Bind_Port = new System.Windows.Forms.Label();
            this.Bind_IP = new System.Windows.Forms.Label();
            this.Prop_path = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.remote_state = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.logbox = new System.Windows.Forms.RichTextBox();
            this.status = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.remote = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refresh);
            this.tabPage1.Controls.Add(this.Disk_Usage);
            this.tabPage1.Controls.Add(this.Memory_Usage);
            this.tabPage1.Controls.Add(this.CPU_Usage);
            this.tabPage1.Controls.Add(this.White_List);
            this.tabPage1.Controls.Add(this.Game_Mode);
            this.tabPage1.Controls.Add(this.Max_Player);
            this.tabPage1.Controls.Add(this.Bind_Port);
            this.tabPage1.Controls.Add(this.Bind_IP);
            this.tabPage1.Controls.Add(this.Prop_path);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基准信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(9, 305);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(72, 22);
            this.refresh.TabIndex = 18;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Disk_Usage
            // 
            this.Disk_Usage.AutoSize = true;
            this.Disk_Usage.Location = new System.Drawing.Point(92, 273);
            this.Disk_Usage.Name = "Disk_Usage";
            this.Disk_Usage.Size = new System.Drawing.Size(87, 15);
            this.Disk_Usage.TabIndex = 17;
            this.Disk_Usage.Text = "Disk_Usage";
            // 
            // Memory_Usage
            // 
            this.Memory_Usage.AutoSize = true;
            this.Memory_Usage.Location = new System.Drawing.Point(92, 238);
            this.Memory_Usage.Name = "Memory_Usage";
            this.Memory_Usage.Size = new System.Drawing.Size(103, 15);
            this.Memory_Usage.TabIndex = 16;
            this.Memory_Usage.Text = "Memory_Usage";
            // 
            // CPU_Usage
            // 
            this.CPU_Usage.AutoSize = true;
            this.CPU_Usage.Location = new System.Drawing.Point(83, 202);
            this.CPU_Usage.Name = "CPU_Usage";
            this.CPU_Usage.Size = new System.Drawing.Size(79, 15);
            this.CPU_Usage.TabIndex = 15;
            this.CPU_Usage.Text = "CPU_Usage";
            // 
            // White_List
            // 
            this.White_List.AutoSize = true;
            this.White_List.Location = new System.Drawing.Point(75, 142);
            this.White_List.Name = "White_List";
            this.White_List.Size = new System.Drawing.Size(87, 15);
            this.White_List.TabIndex = 14;
            this.White_List.Text = "White_List";
            // 
            // Game_Mode
            // 
            this.Game_Mode.AutoSize = true;
            this.Game_Mode.Location = new System.Drawing.Point(89, 114);
            this.Game_Mode.Name = "Game_Mode";
            this.Game_Mode.Size = new System.Drawing.Size(79, 15);
            this.Game_Mode.TabIndex = 13;
            this.Game_Mode.Text = "Game_Mode";
            // 
            // Max_Player
            // 
            this.Max_Player.AutoSize = true;
            this.Max_Player.Location = new System.Drawing.Point(89, 86);
            this.Max_Player.Name = "Max_Player";
            this.Max_Player.Size = new System.Drawing.Size(87, 15);
            this.Max_Player.TabIndex = 12;
            this.Max_Player.Text = "Max_Player";
            // 
            // Bind_Port
            // 
            this.Bind_Port.AutoSize = true;
            this.Bind_Port.Location = new System.Drawing.Point(89, 59);
            this.Bind_Port.Name = "Bind_Port";
            this.Bind_Port.Size = new System.Drawing.Size(79, 15);
            this.Bind_Port.TabIndex = 11;
            this.Bind_Port.Text = "Bind_Port";
            // 
            // Bind_IP
            // 
            this.Bind_IP.AutoSize = true;
            this.Bind_IP.Location = new System.Drawing.Point(75, 32);
            this.Bind_IP.Name = "Bind_IP";
            this.Bind_IP.Size = new System.Drawing.Size(63, 15);
            this.Bind_IP.TabIndex = 10;
            this.Bind_IP.Text = "Bind_IP";
            // 
            // Prop_path
            // 
            this.Prop_path.AutoSize = true;
            this.Prop_path.Location = new System.Drawing.Point(121, 3);
            this.Prop_path.Name = "Prop_path";
            this.Prop_path.Size = new System.Drawing.Size(79, 15);
            this.Prop_path.TabIndex = 9;
            this.Prop_path.Text = "Prop_path";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "磁盘占用：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "内存占用：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPU占用：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "白名单：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "游戏模式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "最大人数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "使用端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "绑定IP：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prop文件位置：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.remote);
            this.tabPage2.Controls.Add(this.remote_state);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.start);
            this.tabPage2.Controls.Add(this.Send);
            this.tabPage2.Controls.Add(this.input);
            this.tabPage2.Controls.Add(this.logbox);
            this.tabPage2.Controls.Add(this.status);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "控制台";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // remote_state
            // 
            this.remote_state.AutoSize = true;
            this.remote_state.ForeColor = System.Drawing.Color.Maroon;
            this.remote_state.Location = new System.Drawing.Point(81, 88);
            this.remote_state.Name = "remote_state";
            this.remote_state.Size = new System.Drawing.Size(37, 15);
            this.remote_state.TabIndex = 8;
            this.remote_state.Text = "关闭";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "当前状态：";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(9, 41);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(105, 24);
            this.start.TabIndex = 5;
            this.start.Text = "开启";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(680, 488);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(82, 26);
            this.Send.TabIndex = 4;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(154, 488);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(520, 25);
            this.input.TabIndex = 3;
            // 
            // logbox
            // 
            this.logbox.Location = new System.Drawing.Point(154, 11);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(608, 470);
            this.logbox.TabIndex = 2;
            this.logbox.Text = "";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Maroon;
            this.status.Location = new System.Drawing.Point(81, 14);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 15);
            this.status.TabIndex = 1;
            this.status.Text = "关闭";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "当前状态：";
            // 
            // remote
            // 
            this.remote.Location = new System.Drawing.Point(9, 115);
            this.remote.Name = "remote";
            this.remote.Size = new System.Drawing.Size(105, 31);
            this.remote.TabIndex = 9;
            this.remote.Text = "远程控制开关";
            this.remote.UseVisualStyleBackColor = true;
            this.remote.Click += new System.EventHandler(this.remote_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Form";
            this.Text = "读取窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Disk_Usage;
        private System.Windows.Forms.Label Memory_Usage;
        private System.Windows.Forms.Label CPU_Usage;
        private System.Windows.Forms.Label White_List;
        private System.Windows.Forms.Label Game_Mode;
        private System.Windows.Forms.Label Max_Player;
        private System.Windows.Forms.Label Bind_Port;
        private System.Windows.Forms.Label Bind_IP;
        private System.Windows.Forms.Label Prop_path;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.RichTextBox logbox;
        private System.Windows.Forms.Label remote_state;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button remote;
    }
}

