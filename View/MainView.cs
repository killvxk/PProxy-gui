using PProxy_gui.Controller;
using System;
using System.Windows.Forms;

namespace PProxy_gui.View
{
    public partial class MainView : Form
    {
        MainController mc;
        public MainView()
        {
            InitializeComponent();
            mc = new MainController();
        }

        private void UpdateServer()
        {
            var serverList = mc.LoadConfigList(Properties.Resources.s_prefix);
            cb_Server.Items.Clear();
            cb_Server.Items.AddRange(serverList.ToArray());
            try
            {
                cb_Server.SelectedIndex = 0;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void UpdateGame()
        {
            var processList = mc.LoadConfigList(Properties.Resources.p_prefix);
            cb_Process.Items.Clear();
            cb_Process.Items.AddRange(processList.ToArray());
            try
            {
                cb_Process.SelectedIndex = 0;
            }
            catch (Exception)
            {
                return;
            }
        }

        public void UpdateConf()
        {
            UpdateServer();
            UpdateGame();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            UpdateConf();
        }
        delegate void SetEnableDel();
        private void SetEnable()
        {
            if (!InvokeRequired)
            {
                cb_Server.Enabled = !cb_Server.Enabled;
                cb_Process.Enabled = !cb_Process.Enabled;
                btn_start.Enabled = !btn_start.Enabled;
                btn_stop.Enabled = !btn_stop.Enabled;
            }
            else
            {
                Invoke(new SetEnableDel(SetEnable));
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cb_Process.Text == "" || cb_Server.Text == "")
            {
                return;
            }
            mc.RunPProxy(cb_Server.Text, cb_Process.Text);
            SetEnable();
            lb_status.Text = $"Server: {cb_Server.Text} Game: {cb_Process.Text}";
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            mc.StopPProxy(new MainController.ExitEvent(SetEnable));
            //SetEnable();
            lb_status.Text = "";
        }

        private void proxyServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = new AddServerView(mc);
            view.ShowDialog();
            if (view.ok)
            {
                UpdateServer();
            }
        }

        private void gameConfigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = new AddGameView(mc);
            view.ShowDialog();
            if (view.ok)
            {
                UpdateGame();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateConf();
        }
    }
}
