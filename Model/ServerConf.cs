namespace PProxy_gui.Model
{
    class ServerConf
    {
        private string type;
        private string server;
        private int server_port;
        private string method;
        private string password;
        private string plugin;
        private string plugin_opts;
        public ServerConf()
        {
            type = "socks5";
            server = "127.0.0.1";
            server_port = 1080;
            method = "";
            password = "";
            plugin = "";
            plugin_opts = "";
        }

        public string Type { get => type; set => type = value; }
        public string Server { get => server; set => server = value; }
        public int Server_port { get => server_port; set => server_port = value; }
        public string Method { get => method; set => method = value; }
        public string Password { get => password; set => password = value; }
        public string Plugin { get => plugin; set => plugin = value; }
        public string Plugin_opts { get => plugin_opts; set => plugin_opts = value; }
    }
}
