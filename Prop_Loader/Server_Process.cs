using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Prop_Loader
{
    class Server_Process
    {
        public Process p;
        public ProcessStartInfo pf;

        public Server_Process()
        {
            p = new Process();
            pf = new ProcessStartInfo("cmd.exe");
            pf.UseShellExecute = false;
            p.StartInfo = pf;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            pf.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(@"G:");
            p.StandardInput.WriteLine(@"cd G:/Bukkit");
            p.StandardInput.WriteLine(@"java -jar mc.jar");
        }

        public StreamWriter GetInput()
        {
            return p.StandardInput;
        }

        public StreamReader GetOutput()
        {
            return p.StandardOutput;
        }

    }
}
