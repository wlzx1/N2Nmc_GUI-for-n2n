using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace N2Nmc.csl
{
    internal class Class1
    {

        //static void Main()
        //{
        //    // 设置防火墙规则
        //    SetFirewallRule("MyApp.exe", true); // 允许程序访问网络

        //    // 启动特定程序
        //    StartProgram("MyApp.exe");

        //    // 停止特定程序
        //    StopProgram("MyApp.exe");

        //    // 移除防火墙规则
        //    SetFirewallRule("MyApp.exe", false); // 禁止程序访问网络
        //}


        // 设置防火墙规则
        public static void SetFirewallRule(string appName, bool allow)
        {
            string command = allow ? "netsh advfirewall firewall add rule" : "netsh advfirewall firewall delete rule";
            string arguments = $"name=\"{appName}\" dir=out action={(allow ? "allow" : "block")}";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C {command} {arguments}";
            process.Start();
            process.WaitForExit();
        }

        // 启动程序
        public static void StartProgram(string appName)
        {
            Process.Start(appName);
        }

        // 停止程序
        public static void StopProgram(string appName)
        {
            Process[] processes = Process.GetProcessesByName(appName);
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }
    }
}
