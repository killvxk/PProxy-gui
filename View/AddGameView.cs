using PProxy_gui.Controller;
using PProxy_gui.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PProxy_gui.View
{
    public partial class AddGameView : Form
    {
        private MainController mc;
        public bool ok;
        public AddGameView(MainController _mc)
        {
            InitializeComponent();
            mc = _mc;
            ok = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string confName = tb_name.Text;
            GameConf conf = new GameConf();
            conf.Processes = GetList(tb_process.Text);
            conf.Whitelist = GetList(tb_domain.Text);
            mc.SaveConfig<GameConf>($"{Properties.Resources.p_prefix}/{conf}.json", conf);
            ok = true;
            Close();
        }

        private List<string> GetList(string text)
        {
            List<string> list = new List<string>();
            foreach (var v in text.Split(new char[] { '\n', ';', ',', '\r' }))
            {
                if (!v.Equals(""))
                {
                    list.Add(v);
                }
            }
            return list;
        }
    }
}
