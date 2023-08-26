using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
using HandyControl.Controls;
using System.Windows.Threading;
using log4net;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using n2nmc.View.Pagey;
using static n2nmc.View.Pagey.Page1;
using static System.Net.Mime.MediaTypeNames;
using N2Nmc.View;

namespace n2nmc.View.Pagey
{
    /// <summary>
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            homename.Text = nameall;

            homepassword.Text = passwordall;

            kuaisu.Text = kuaisuall;

            if (guanbi == 1)
            {
                Buttonguanbi.IsEnabled = true;
            }
            else {
                Buttonguanbi.IsEnabled = false;
            }
            pass = 0;

            
        }

        public static string nameall = "";
        public static string passwordall = "";
        public static string kuaisuall = "";
        public static int pass = 0; //默认为私人房间
        public static int guanbi;
        //private Thread jincheng;
        

        private async void Cuangjian_Click(object sender, RoutedEventArgs e)
        {
            ILog log = log4net.LogManager.GetLogger(typeof(Page2));

            string name = homename.Text;
            nameall = name;
            string password = homepassword.Text;
            if (pass == 0)
            {
                passwordall = password;
            }
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // 创建一个新的线程，并传递一个匿名方法作为线程要执行的方法（运行cmd命令无实时回显，已废弃）
            //Thread thread = new Thread(() => RunCmdCommand(currentDirectory + "edge\\edge.exe -c " + name + " -k " + passwordall + " -l " + MainView.severip));
            // 启动线程
            //thread.Start();
            HandyControl.Controls.Growl.SuccessGlobal("正在创建房间中请稍后...");

            Console.WriteLine(currentDirectory + "edge\\edge.exe -c " + name + " -k " + passwordall + " -l " + MainView.severip);
            log.Info(currentDirectory + "edge\\edge.exe -c " + name + " -k " + passwordall);
            //HandyControl.Controls.Growl.SuccessGlobal("正在创建房间中请稍后...");
            kuaisuall = "edge\\edge.exe -c " + name + " -k " + passwordall + " -l " + MainView.severip;
            kuaisu.Text = "edge\\edge.exe -c " + name + " -k " + passwordall + " -l " + MainView.severip;
            Buttonguanbi.IsEnabled = true;
            guanbi = 1;
            if (pass == 1)
            {
                Xieru1(name);
                HandyControl.Controls.Growl.SuccessGlobal("已发布到联机大厅");
            }
            else {
                if (homepassword.Text == "")
                {
                    HandyControl.Controls.Growl.SuccessGlobal("私人房间，请填写密码");
                }
            }

            // 创建一个定时器，检测是否启动成功
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            


            //运行cmd命令并实时回显
            Page3.commandall = currentDirectory + "edge\\edge.exe -c " + name + " -k " + passwordall + " -l " + MainView.severip;
            Page3 page3 = new Page3();
            await page3.ExecuteCommandAsync(Page3.commandall);

            





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
                if (nameall == "")
                {
                    HandyControl.Controls.Growl.SuccessGlobal("未获取到房间名称");
                    guanbibi();
                    timer.Stop();
                }
                else
                {
                    MainView.jiedian = nameall;
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
            if (Page3.anoutput.Contains("switching to AES as key was provided")) {

                HandyControl.Controls.Growl.SuccessGlobal("私人房间，请填写密码");
                timer.Stop();
            }
            

        }



        //进程守护，消耗系统资源，已废弃

        //public static void jinchengshouhu()
        //{
        //    bool IsProcessRunningju(string processName)
        //    {
        //        Process[] processes = Process.GetProcessesByName(processName); // 获取指定进程名的进程数组
        //        return processes.Length > 0; // 如果数组长度大于 0，说明进程在运行，否则进程不在运行
        //    }

        //    while (true)
        //    {
        //        if (!IsProcessRunningju("edge")) // 如果进程不在运行
        //        {
        //            //如果进程不存在

        //            MessageBox.Show("房间已关闭");
        //        }

        //        Thread.Sleep(1000); // 等待一段时间再进行下一次检查
        //    }
        //}

        // 判断进程是否在运行

        private bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName); // 获取指定进程名的进程数组
            return processes.Length > 0; // 如果数组长度大于 0，说明进程在运行，否则进程不在运行
        }

        public static string outputall="";
        [STAThread]

        //运行cmd命令，无实时回显，已废弃
        static void RunCmdCommand(string command)  
        {
            
            // 创建一个新的进程
            Process process = new Process();

            // 设置进程启动信息
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";  // 指定要执行的命令行程序
            startInfo.Arguments = "/c " + command;  // 指定要执行的命令及参数
            startInfo.RedirectStandardOutput = true;  // 重定向标准输出
            startInfo.UseShellExecute = false;  // 不使用操作系统的 shell 执行
            startInfo.CreateNoWindow = true;  // 不创建新窗口

            process.StartInfo = startInfo;

            // 启动进程
            process.Start();

            // 读取并显示输出结果
            string output = process.StandardOutput.ReadToEnd();
            outputall = output;


            Console.WriteLine(output);

            log4net.Config.XmlConfigurator.Configure();
            ILog log = log4net.LogManager.GetLogger(typeof(Page2));
            log.Info(output);
            log.Info("关闭日志");
            
            HandyControl.Controls.Growl.SuccessGlobal("房间已关闭");
            n2nmc.View.Pagey.Page2.guanbi = 0;
            // 等待进程结束
            
            process.WaitForExit();


        }
        
        //关闭按钮被点击时
        private void Guanbi_Click(object sender, RoutedEventArgs e)
        {
            Buttonguanbi.IsEnabled = false;
            Thread thread = new Thread(guanbibi);
            //启动线程
            thread.Start();
            //Page3.runcmdclose();

        }

        public static void guanbibi() {

            neirong = nameall;
            shanchu();

            guanbi = 0;
            ILog log = log4net.LogManager.GetLogger(typeof(Page2));

            if (System.Diagnostics.Process.GetProcessesByName("edge").ToList().Count > 0)
            {
                //存在
                log.Info("在运行");
                //MessageBox.Show("在运行");
                string name = "edge";//name就是进程的名称
                int pid = -1;
                Process[] pp = Process.GetProcessesByName(name);
                for (int i = 0; i < pp.Length; i++)
                {
                    if (pp[i].ProcessName == name)
                    {
                        pid = pp[i].Id;//这个就是进程的ID
                        //MessageBox.Show($"{name}, {pid}");
                        log.Info($"{name}, {pid}");
                    }
                }
                if (pid > 0)
                {

                    try
                    {
                        // 获取进程对象
                        Process process = Process.GetProcessById(pid);

                        if (process != null && !process.HasExited)
                        {
                            // 获取进程对象
                            // 启动进程并获取进程对象Process process = Process.Start("edge");
                            //发送关闭窗口消息并等待进程退出
                            if (!process.CloseMainWindow())
                            {
                                //process.Close();
                                process.Kill();
                            }
                            // 等待一段时间，让进程有时间响应关闭窗口消息,要不然会报错
                            //Thread.Sleep(20000);

                            //// 如果进程已经退出，则不再调用 WaitForExit() 方法
                            //if (!process.HasExited)
                            //{
                            //    // 等待进程退出
                            //    if (!process.WaitForExit(10000))
                            //    {
                            //        // 如果进程在超时时间内没有退出，则使用 Kill() 终止进程
                            //        process.Kill();
                            //        log.Info(outputall);
                            //    }
                            //}
                        }
                        else
                        {
                            // 进程已经退出或不存在，处理异常情况
                            // 可以记录日志或显示错误信息
                            log.Info("进程已退出或不存在");
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        // 指定的进程ID无效，处理异常情况
                        // 可以记录日志或显示错误信息
                        log.Error("无效的进程ID", ex);
                    }

                }
                else
                {
                    // 进程ID无效，处理异常情况
                    // 可以记录日志或显示错误信息
                    log.Info("无效的进程ID");
                    HandyControl.Controls.Growl.SuccessGlobal("无效的进程ID");

                }

                HandyControl.Controls.Growl.SuccessGlobal("房间已关闭");

            }
            else
            {
                //不存在
                log.Info("不在运行");
            }

            

        }
        

        //checkBix被点击时
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (this.homeCheck.IsChecked == true)
            {
                HandyControl.Controls.Growl.SuccessGlobal("公开房间，会发布到联机大厅");
                homepassword.IsEnabled = false;//禁止密码框填入信息
                passwordall = "123456";//让密码等于默认密码
                Console.WriteLine(passwordall);
                pass = 1;//改变全局变量，以判断checkbix的点击状态
            }
            else {
                HandyControl.Controls.Growl.SuccessGlobal("私人房间，不会发布到联机大厅");
                homepassword.IsEnabled = true;
                pass = 0;

            }

            
        }



        //数据库写入
        public void Xieru1(string neirong)
        {
            ILog log = log4net.LogManager.GetLogger(typeof(Page2));
            try
            {
                // 执行 MySQL 操作
                // 定义连接参数
                //string server = "localhost";
                //int port = 3308; // 替换为实际的端口号
                //string username = "root";
                //string password = "123456";
                //string database = "wlzx";

                // 创建连接字符串
                //string connectionString = $"server={server};port={port};user={username};password={password};database={database};";


                string insertQuery = "INSERT INTO user (user) VALUES (@user)"; //INSERT INTO user (user)<表名> VALUES (@user)

                using (MySqlConnection connection = new MySqlConnection(connectionStringall))
                {
                    Console.WriteLine("连接成功");
                    log.Info("连接成功");
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@user", neirong); // 替换为要插入的实际值

                        connection.Open();
                        command.ExecuteNonQuery();


                    }
                }

                Console.WriteLine("数据插入成功！");
                log.Info("数据插入成功");
                
            }
            catch (MySqlException ex)
            {
                // 获取错误码和错误信息
                int errorCode = ex.Number;
                string errorMessage = ex.Message;
                Console.WriteLine("MySQL 错误码：" + errorCode);
                HandyControl.Controls.Growl.SuccessGlobal("MySQL 错误码：" + errorCode + "MySQL 错误信息：" + errorMessage);
                log.Info("MySQL 错误码：" + errorCode);
                Console.WriteLine("MySQL 错误信息：" + errorMessage);
                log.Info("MySQL 错误信息：" + errorMessage);
            }
            //connection.Close();


        }

        public static string? neirong;
        //数据库删除
        public static void shanchu()
        {
            ILog log = log4net.LogManager.GetLogger(typeof(Page2));
            try
            {
                // 创建 MySQL 连接对象
                using (MySqlConnection connection = new MySqlConnection(connectionStringall))
                {
                    // 打开数据库连接
                    connection.Open();

                    // 创建 SQL 删除语句
                    string sql = "DELETE FROM user WHERE user = @user";

                    // 创建 MySQL 命令对象
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        // 设置参数
                        command.Parameters.AddWithValue("@user", neirong); // 根据实际需要设置参数值

                        // 执行删除操作
                        int rowsAffected = command.ExecuteNonQuery();

                        // 输出受影响的行数
                        Console.WriteLine("已关闭房间 {0} 个", rowsAffected);
                        log.Info("已关闭房间 {"+ rowsAffected + "} 个");

                    }
                }
            }
            catch (MySqlException ex)
            {
                // 获取错误码和错误信息
                int errorCode = ex.Number;
                string errorMessage = ex.Message;
                Console.WriteLine("MySQL 错误码：" + errorCode);
                log.Info("MySQL 错误码：" + errorCode);
                Console.WriteLine("MySQL 错误信息：" + errorMessage);
                log.Info("MySQL 错误信息：" + errorMessage);
            }
            


        }
    }
}
