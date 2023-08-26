using n2nmc.View.Pagey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Net;
using log4net;
using static N2Nmc.csl.Class2;
using static N2Nmc.csl.Class1;
using N2Nmc.csl;

namespace n2nmc.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    
    public partial class MainView : Window
    {
        //全局n2n服务器ip
        public static string severip = "";//N2N服务器地址
        public static string severapi = "";//api地址
        //用于page2窗口控件状态
        public static int pass;
        public static int guanbipage2;
        public static string jiedian = "";
        //启动器路径
        public static string RunFilePath = "";
        public string currentDirectoryall = AppDomain.CurrentDomain.BaseDirectory; //运行目录



        public MainView()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
            tap();
            log4net.Config.XmlConfigurator.Configure();
            string filePath = "config.ini";
            IniFile iniFile = new IniFile(filePath);
            RunFilePath = iniFile.ReadValue("set", "RunFilePath");
            
            //给予防火墙权限
            SetFirewallRule(currentDirectoryall + "edge\\edge.exe", true);
            SetFirewallRule(currentDirectoryall + "WinIPBroadcast\\WinIPBroadcast.exe", true);
            SetFirewallRule(currentDirectoryall + "N2Nmc.exe", true);


            //运行WinIPBroadcast（数据转发到虚拟网卡）
            RunCmdCommand(currentDirectoryall + "WinIPBroadcast\\WinIPBroadcast.exe run");

            if (RunFilePath == "")
            {
                MessageBox.Show("请转到设置填写启动器路径");
                Framez.Source = new Uri("Pagey/Page6.xaml", UriKind.Relative);
            }
            else {
                SetFirewallRule(RunFilePath, true); // 允许程序访问网络
            }
        }

        private static void ChageEvent() {

            
        }
        //public static void tiaozhuanpage5() {
        //    //MainView.



        public void logm(string loga) {
            ILog log = log4net.LogManager.GetLogger(typeof(MainView));
            log.Info(loga);
        }


        //}
        //左侧边栏按钮
        public void tiaozhuan(string ye) {
            Framez.Source = new Uri("Pagey/"+ye+".xaml", UriKind.Relative);
            
        }

        private void Page1Button_Click(object sender, RoutedEventArgs e)
        {
            //HandyControl.Controls.Growl.SuccessGlobal("正在连接数据库...");
            Framez.Source = new Uri("Pagey/Page1.xaml", UriKind.Relative);
            //HandyControl.Controls.Growl.SuccessGlobal("1");
            //HandyControl.Controls.Growl.Success("a");
            page1to.Background = new SolidColorBrush(Color.FromRgb(211, 229, 240));
            page2to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page3to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page4to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            
        }

        private void Page2Button_Click(object sender, RoutedEventArgs e)
        {

            Framez.Source = new Uri("Pagey/Page2.xaml", UriKind.Relative);
            page1to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page2to.Background = new SolidColorBrush(Color.FromRgb(211, 229, 240));
            page3to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page4to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
        }

        private void Page3Button_Click(object sender, RoutedEventArgs e)
        {
            Framez.Source = new Uri("Pagey/Page4.xaml", UriKind.Relative);
            page1to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page2to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page3to.Background = new SolidColorBrush(Color.FromRgb(211, 229, 240));
            page4to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
        }
        private void Page4Button_Click(object sender, RoutedEventArgs e)
        {
            Framez.Source = new Uri("Pagey/Page3.xaml", UriKind.Relative);
            
        }
        private void Page5Button_Click(object sender, RoutedEventArgs e)
        {
            Framez.Source = new Uri("Pagey/Page5.xaml", UriKind.Relative);
            page1to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page2to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page3to.Background = new SolidColorBrush(Color.FromRgb(211, 211, 211));
            page4to.Background = new SolidColorBrush(Color.FromRgb(211, 229, 240));
        }
        private void Buttonset_Click(object sender, RoutedEventArgs e)
        {
            Framez.Source = new Uri("Pagey/Page6.xaml", UriKind.Relative);
        }

        public void tap()
        {
            ILog log = LogManager.GetLogger("Info");
            if (jiance()|| IsApplicationInstalled("TAP-Windows"))
            {
                Console.WriteLine("TAP-Windows已安装");
                log.Info("TAP-Windows已安装");
            }
            else
            {
                Console.WriteLine("TAP-Windows未安装");
                log.Info("TAP-Windows未安装");
                MessageBox.Show("TAP-Windows未安装，程序将会帮您启动安装程序，请在将来弹出的对话框中安装TAP-Windows,请勿更改默认安装目录，并重启本软件", "消息");
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\TAP-Windows\\9.21.2.exe");
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                Console.WriteLine("当前目录：" + currentDirectory);
                log.Info("当前目录：" + currentDirectory);
                Environment.Exit(0);
            }



        }
        static bool IsApplicationInstalled(string applicationName)
        {
            // 检查注册表中的应用程序列表
            using (var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
            {
                foreach (string subKeyName in key.GetSubKeyNames())
                {
                    using (var subKey = key.OpenSubKey(subKeyName))
                    {
                        string? displayName = subKey.GetValue("DisplayName") as string;
                        if (displayName != null && displayName.Contains(applicationName))
                        {
                            Console.WriteLine("true");
                            return true;
                            
                        }
                    }
                }
            }
            Console.WriteLine("false");
            return false;
        }


        //检测目录中是否存在TAP-Windows
        static bool jiance() {
            string directoryPath = "C:\\Program Files\\TAP-Windows\\bin";  //目录路径
            string fileName = "tapinstall.exe";   //文件名
            bool fileExists = IsFileExists(directoryPath, fileName);
            if (fileExists)
            {
                return true;
            }
            else
            {
                return false;
                
            }


        }

        //扫描目录内文件
        public static bool IsFileExists(string directoryPath, string fileName)
        {
            string filePath = System.IO.Path.Combine(directoryPath, fileName);
            return File.Exists(filePath);
        }

        //运行cmd命令，无实时回显
        static void RunCmdCommand(string command)  //运行cmd命令
        {

            // 创建一个新的进程
            Process process = new Process();

            // 设置进程启动信息
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";  // 指定要执行的命令行程序
            startInfo.Arguments = "/c " + command;  // 指定要执行的命令及参数
            startInfo.RedirectStandardOutput = true;  // 重定向标准输出
            startInfo.UseShellExecute = false;  // 不使用操作系统的 shell 执行
            startInfo.CreateNoWindow = false;  // 不创建新窗口

            process.StartInfo = startInfo;

            // 启动进程
            process.Start();
            
            // 读取并显示输出结果
            string output = process.StandardOutput.ReadToEnd();
            
            // 等待进程结束
            process.WaitForExit();
        }


        //关闭按钮
        private void Buttonguanbi_Click(object sender, RoutedEventArgs e)
        {
            //仅关闭本窗口
            //Close();
            Page2.guanbibi();
            // 移除防火墙规则
            SetFirewallRule(RunFilePath, false); // 禁止程序访问网络
            //彻底关闭
            Environment.Exit(0);
        }
        //窗口移动
        private void WinMove_main(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
        //最小化窗口
        private void Buttonzuixiaohua_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        
    }
}
