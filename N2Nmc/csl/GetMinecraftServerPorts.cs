using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N2Nmc.csl
{
    internal class GetMinecraftServerPorts
    {
        //使用案例
        //List<int> openedPorts = GetMinecraftServerPorts();
        //string portsText = string.Join(", ", openedPorts);
        //MessageBox.Show($"Minecraft Server Opened Ports: {portsText}");



        public List<int> GetServerPorts()
        {
            List<int> openedPorts = new List<int>();

            Process[] processes = Process.GetProcessesByName("java");//可更改名称
            foreach (var process in processes)
            {
                using (ProcessModule module = process.MainModule)
                {
                    string processPath = module.FileName;
                    int processId = process.Id;

                    if (!string.IsNullOrEmpty(processPath))
                    {
                        string netstatOutput = RunCommand($"netstat -ano | findstr {processId}");
                        MatchCollection matches = Regex.Matches(netstatOutput, @"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5})");

                        foreach (Match match in matches)
                        {
                            string ipAddressPortString = match.Value;
                            string[] parts = ipAddressPortString.Split(':');
                            int port = int.Parse(parts[1]);

                            openedPorts.Add(port);
                        }
                    }
                }
            }

            return openedPorts;
        }

        private string RunCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C {command}";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output;
        }
    }
}
