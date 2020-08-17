namespace PProxy_gui.View
{
    partial class MainView
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Server = new System.Windows.Forms.ComboBox();
            this.cb_Process = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameConfigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_status = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProxyServer:";
            // 
            // cb_Server
            // 
            this.cb_Server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Server.FormattingEnabled = true;
            this.cb_Server.Location = new System.Drawing.Point(139, 40);
            this.cb_Server.Name = "cb_Server";
            this.cb_Server.Size = new System.Drawing.Size(185, 23);
            this.cb_Server.TabIndex = 1;
            // 
            // cb_Process
            // 
            this.cb_Process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Process.FormattingEnabled = true;
            this.cb_Process.Location = new System.Drawing.Point(139, 68);
            this.cb_Process.Name = "cb_Process";
            this.cb_Process.Size = new System.Drawing.Size(185, 23);
            this.cb_Process.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "GameConfigure:";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(330, 40);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Run";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(330, 68);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proxyServerToolStripMenuItem,
            this.gameConfigureToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // proxyServerToolStripMenuItem
            // 
            this.proxyServerToolStripMenuItem.Name = "proxyServerToolStripMenuItem";
            this.proxyServerToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.proxyServerToolStripMenuItem.Text = "ProxyServer";
            this.proxyServerToolStripMenuItem.Click += new System.EventHandler(this.proxyServerToolStripMenuItem_Click);
            // 
            // gameConfigureToolStripMenuItem
            // 
            this.gameConfigureToolStripMenuItem.Name = "gameConfigureToolStripMenuItem";
            this.gameConfigureToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.gameConfigureToolStripMenuItem.Text = "GameConfigure";
            this.gameConfigureToolStripMenuItem.Click += new System.EventHandler(this.gameConfigureToolStripMenuItem_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_status.ForeColor = System.Drawing.Color.Lime;
            this.lb_status.Location = new System.Drawing.Point(0, 111);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(0, 15);
            this.lb_status.TabIndex = 7;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 24);
            this.toolStripMenuItem1.Text = "Reload";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 126);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.cb_Process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PProxy";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Server;
        private System.Windows.Forms.ComboBox cb_Process;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameConfigureToolStripMenuItem;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

