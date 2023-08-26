using log4net;
using N2Nmc.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;

namespace n2nmc.View.Pagey
{
    /// <summary>
    /// Page4.xaml 的交互逻辑
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        public static string name="";
        public static string passwordall="";
        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            name = lianjitext.Text;
            passwordall = lianjimima.Text;

            ILog log = log4net.LogManager.GetLogger(typeof(Page2));
            
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            HandyControl.Controls.Growl.SuccessGlobal("正在进入房间,请稍后...");

            // 创建一个定时器，检测是否启动成功
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            //运行cmd命令并实时回显
            Page3.commandall = currentDirectory + "edge\\edge.exe -c " + name + " -k " + passwordall + " -l " + MainView.severip;
            Page3 page3 = new Page3();
            await page3.ExecuteCommandAsync(Page3.commandall);


            //// 创建一个新的线程，并传递一个匿名方法作为线程要执行的方法(无法实时回显，已废弃)
            //Thread thread = new Thread(() => RunCmdCommand(currentDirectory+lianji));
            //// 启动线程
            //thread.Start();

            Console.WriteLine( currentDirectory + "edge\\edge.exe -c " + name + " -k " + passwordall + " -l " + MainView.severip);
            log.Info(currentDirectory + "edge\\edge.exe -c " + name + " -k " + passwordall + " -l " + MainView.severip);
            
        }


        //文本对比,用于检测n2n是否启动成功
        private DispatcherTimer timer;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            // 更新文本框的内容
            if (Page3.anoutput.Contains("[OK] edge <<< ================ >>> supernode"))
            {

                HandyControl.Controls.Growl.SuccessGlobal("房间加入成功");
                //启动房间窗口
                if (name == "")
                {
                    HandyControl.Controls.Growl.SuccessGlobal("未获取到房间名称");
                    Page2.guanbibi();
                    timer.Stop();
                }
                else
                {
                    MainView.jiedian = name;
                    room mainWindow = new room(); // 实例化主窗口
                    mainWindow.Show(); // 显示主窗口
                    timer.Stop();
                }


            }
            if (Page3.anoutput.Contains("No Windows tap devices found, did you run tapinstall.exe?"))
            {
                HandyControl.Controls.Growl.SuccessGlobal("请检测虚拟网卡是否安装成功，或者虚拟网卡是否正在使用(查看资源管理器是否有edge.exe正在运行)");
                timer.Stop();
            }
            if (Page3.anoutput.Contains("switching to AES as key was provided"))
            {

                HandyControl.Controls.Growl.SuccessGlobal("私人房间，请填写密码");
                timer.Stop();
            }


        }


        ////运行cmd命令，无实时回显，已废弃
        //static void RunCmdCommand(string command)  //运行cmd命令
        //{
        //    ILog log = log4net.LogManager.GetLogger(typeof(Page2));
        //    // 创建一个新的进程
        //    Process process = new Process();

        //    // 设置进程启动信息
        //    ProcessStartInfo startInfo = new ProcessStartInfo();
        //    startInfo.FileName = "cmd.exe";  // 指定要执行的命令行程序
        //    startInfo.Arguments = "/c " + command;  // 指定要执行的命令及参数
        //    startInfo.RedirectStandardOutput = true;  // 重定向标准输出
        //    startInfo.UseShellExecute = false;  // 不使用操作系统的 shell 执行
        //    startInfo.CreateNoWindow = true;  // 不创建新窗口

        //    process.StartInfo = startInfo;

        //    // 启动进程
        //    process.Start();

        //    // 读取并显示输出结果
        //    string output = process.StandardOutput.ReadToEnd();
        //    Console.WriteLine(output);
        //    log.Info(output);
        //    // 等待进程结束
        //    process.WaitForExit();
        //}

        
    }
}
