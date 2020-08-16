using System.Collections.Generic;

namespace PProxy_gui.Model
{
    class GameConf
    {
        private List<string> processes;
        private List<string> whitelist;
        public GameConf()
        {
            processes = new List<string>();
            whitelist = new List<string>();
        }

        public List<string> Processes { get => processes; set => processes = value; }
        public List<string> Whitelist { get => whitelist; set => whitelist = value; }
    }
}
