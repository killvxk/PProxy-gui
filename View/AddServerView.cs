using PProxy_gui.Controller;
using PProxy_gui.Model;
using System;
using System.Windows.Forms;

namespace PProxy_gui.View
{
    public partial class AddServerView : Form
    {
        private MainController mc;
        public bool ok;
        public AddServerView(MainController _mc)
        {
            InitializeComponent();
            mc = _mc;
            ok = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string confName = tb_name.Text;
                ServerConf conf = new ServerConf();
                conf.Type = cb_type.Text;
                conf.Server = tb_server.Text;
                conf.Server_port = int.Parse(tb_port.Text);
                if (conf.Type != "socks5")
                {
                    conf.Method = cb_method.Text;
                    conf.Password = tb_pwd.Text;
                    conf.Plugin = tb_plugin.Text;
                    conf.Plugin_opts = tb_opts.Text;
                }
                mc.SaveConfig<ServerConf>($"{Properties.Resources.s_prefix}/{confName}.json", conf);
                ok = true;
                Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddServerView_Load(object sender, EventArgs e)
        {
            cb_type.SelectedIndex = 0;
            cb_method.SelectedIndex = 0;
        }
    }
}
