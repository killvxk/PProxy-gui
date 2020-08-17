using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace PProxy_gui.Controller
{
    public class MainController
    {
        Process p;
        public List<string> LoadConfigList(string path)
        {
            List<string> list = new List<string>();
            foreach (var file in Directory.GetFiles(path, "*.json"))
            {
                list.Add(Path.GetFileNameWithoutExtension(file));
            }
            return list;
        }
        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public T LoadConfig<T>(string path)
        {
            T t = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            return t;
        }
        /// <summary>
        /// 保存配置文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="t"></param>
        public void SaveConfig<T>(string path, T t)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(t));
        }
        /// <summary>
        /// 运行代理
        /// </summary>
        /// <param name="sconf"></param>
        /// <param name="pconf"></param>
        public delegate void ExitEvent();
        public void RunPProxy(string sconf, string pconf)
        {
            p = GetProcess();
            p.StartInfo.Arguments = $"-sconfig {Properties.Resources.s_prefix}/{sconf}.json -pconfig {Properties.Resources.p_prefix}/{pconf}.json";
            p.Start();
        }
        /// <summary>
        /// 停止代理
        /// </summary>
        public void StopPProxy(ExitEvent exitEvent)
        {
            if (p is null || p.HasExited)
            {
                return;
            }
            if (AttachConsole((uint)p.Id))
            {
                SetConsoleCtrlHandler(null, true);
                GenerateConsoleCtrlEvent(CtrlTypes.CTRL_C_EVENT, 0);
                FreeConsole();
                SetConsoleCtrlHandler(null, false);
                while (!p.HasExited) ;
                exitEvent();
            }
        }

        private Process GetProcess()
        {
            Process process = new Process();
            process.StartInfo.FileName = Properties.Resources.execFile;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.RedirectStandardInput = false;
            process.StartInfo.RedirectStandardError = false;

            return process;
        }

        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(uint dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GenerateConsoleCtrlEvent(CtrlTypes dwCtrlEvent, uint dwProcessGroupId);

        enum CtrlTypes : uint
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT,
            CTRL_CLOSE_EVENT,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT
        }

        private delegate bool ConsoleCtrlDelegate(CtrlTypes CtrlType);
    }
}
