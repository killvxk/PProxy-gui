namespace PProxy_gui.View
{
    partial class AddServerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_method = new System.Windows.Forms.ComboBox();
            this.tb_plugin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_opts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(108, 8);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(212, 25);
            this.tb_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(108, 68);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(212, 25);
            this.tb_server.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server:";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(108, 99);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(212, 25);
            this.tb_port.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "ServerPort:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Method:";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(108, 161);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(212, 25);
            this.tb_pwd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password:";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "socks5",
            "shadowsocks"});
            this.cb_type.Location = new System.Drawing.Point(108, 39);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(212, 23);
            this.cb_type.TabIndex = 12;
            // 
            // cb_method
            // 
            this.cb_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_method.FormattingEnabled = true;
            this.cb_method.Items.AddRange(new object[] {
            "aes-128-gcm",
            "aes-256-gcm",
            "chacha20-ietf-poly1305"});
            this.cb_method.Location = new System.Drawing.Point(108, 132);
            this.cb_method.Name = "cb_method";
            this.cb_method.Size = new System.Drawing.Size(212, 23);
            this.cb_method.TabIndex = 13;
            // 
            // tb_plugin
            // 
            this.tb_plugin.Location = new System.Drawing.Point(108, 192);
            this.tb_plugin.Name = "tb_plugin";
            this.tb_plugin.Size = new System.Drawing.Size(212, 25);
            this.tb_plugin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Plugin:";
            // 
            // tb_opts
            // 
            this.tb_opts.Location = new System.Drawing.Point(108, 223);
            this.tb_opts.Name = "tb_opts";
            this.tb_opts.Size = new System.Drawing.Size(212, 25);
            this.tb_opts.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "PluginOpts:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(10, 254);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 30);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(170, 254);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 30);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 298);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_opts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_plugin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_method);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProxyConfigure";
            this.Load += new System.EventHandler(this.AddServerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_method;
        private System.Windows.Forms.TextBox tb_plugin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_opts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}