using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using log4net;
using MySql.Data.MySqlClient;
using N2Nmc.csl;
using N2Nmc.View;
using static n2nmc.View.Pagey.Page1;
using static N2Nmc.csl.GetMinecraftServerPorts;

namespace n2nmc.View.Pagey
{
    /// <summary>
    /// Page3.xaml 的交互逻辑
    /// </summary>
    public partial class Page3 : Page
    {

        public Page3()
        {
            InitializeComponent();
        }

        public void Xieru1(string neirong)
        {
            ILog log = LogManager.GetLogger("Info");
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
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@user", neirong); // 替换为要插入的实际值

                        connection.Open();
                        command.ExecuteNonQuery();


                    }
                }

                Console.WriteLine("数据插入成功！");
                log.Info("数据插入成功！");
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
            //connection.Close();


        }

        public static void duqu1()
        {
            //// 定义连接参数
            //string server = "localhost";
            //int port = 3308; // 替换为实际的端口号
            //string username = "root";
            //string password = "123456";
            //string database = "wlzx";

            //// 创建连接字符串
            //string connectionString = $"server={server};port={port};user={username};password={password};database={database};";



            // 创建连接对象
            using (MySqlConnection connection = new MySqlConnection(connectionStringall))
            {
                Console.WriteLine("连接成功");
                // 打开数据库连接
                connection.Open();
                MessageBox.Show("连接成功");
                // 创建 SQL 查询语句
                string sql = "SELECT * FROM user";  //SELECT * FROM user(表名)

                // 创建命令对象
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    // 执行查询并获取数据读取器
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        MessageBox.Show("开始查询");
                        // 遍历数据读取器并输出结果
                        while (reader.Read())
                        {

                            string column1Value = reader.GetString("user");
                            string column2Value = ""; //reader.GetString("p");

                            Console.WriteLine($"user: {column1Value}, p: {column2Value}");
                            MessageBox.Show($"user: {column1Value}, p: {column2Value}");
                        }
                    }
                }

                // 关闭数据库连接
                connection.Close();
            }


        }

        public void shanchu(string neirong)
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
                    Console.WriteLine("删除了 {0} 行记录", rowsAffected);
                }
            }


        }




        // 读取按钮点击事件处理程序
        private void duqu1(object sender, EventArgs e)
        {
            duqu1();



        }

        private void shanchu1(object sender, RoutedEventArgs e)
        {
            shanchu("wlzx");
        }
        // 写入按钮点击事件处理程序
        private void xieru1(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("开始写入");
            Xieru1("");
            //Thread thread = new Thread();
            // 启动线程
            //thread.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName("edge").ToList().Count > 0)
            {

                //存在
                MessageBox.Show("在运行");

            }
            else
            {

                //不存在
                MessageBox.Show("不在运行");

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = "edge";//name就是进程的名称
            int pid = -1;
            Process[] pp = Process.GetProcessesByName(name);
            for (int i = 0; i < pp.Length; i++)
            {
                if (pp[i].ProcessName == name)
                {
                    pid = pp[i].Id;//这个就是进程的ID
                    MessageBox.Show($"{name}, {pid}");
                }
            }
        }
        //log测试
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            //创建日志记录组件实例
            ILog log = log4net.LogManager.GetLogger(typeof(Page3));
            //记录错误日志
            log.Error("发生了错误：", new Exception("log4net的测试错误信息"));
            //记录致命的错误
            log.Fatal("发生了致命的错误：", new Exception("log4net测试致命信息"));
            //记录一般信息
            log.Info("log4net的一般信息");
            //记录调试信息
            log.Debug("log4net的调试信息");
            //记录警告信息
            log.Warn("log4net警告信息");
            Console.WriteLine("ok");
        }





        private async void cmdshishi(object sender, RoutedEventArgs e)
        {
            //string command = "ping 127.0.0.1 -t"; // 替换为你想执行的cmd命令
            commandall = "ping 127.0.0.1 -t";
            await Task.Run(() => ExecuteCommandAsync(commandall));
        }


        // 导入 Windows API
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string? lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        public static string commandall = "";
        public static string outputall = "";
        public static string anoutput = "";
        public static int processId;
        public static Process? process;
        public async Task ExecuteCommandAsync(string command)
        {
            using ( process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.OutputDataReceived += new DataReceivedEventHandler(OutputDataReceived);
                process.ErrorDataReceived += new DataReceivedEventHandler(OutputDataReceived);

                process.Start();

                //Thread.Sleep(2000);
                //获取这个进程的进程id
                //processId = process.Id;

                // 隐藏指定进程ID的窗口
                //WindowHider.HideWindowByProcessId(processId);

                // 显示指定进程ID的窗口
                //WindowHider.ShowWindowByProcessId(1234);

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                await process.WaitForExitAsync();
            }
        }

        public static IntPtr cmdWindowHandle;

        public static void runcmdclose() {

            if (process == null)
            {
                HandyControl.Controls.Growl.SuccessGlobal("无窗口可关闭");
            }
            else {
                CmdWindowController.SendCtrlCSignal(processId);
            }

            


        }
        //向cmd窗口发送ctrl+c,方法1
        public class CmdWindowController
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

            public const int WM_CHAR = 0x0102;
            public const int VK_CONTROL = 0x11;
            public const int VK_C = 0x43;

            public static void SendCtrlCSignal(int processId)
            {
                Process process = Process.GetProcessById(processId);
                if (process != null)
                {
                    IntPtr hWnd = process.MainWindowHandle;
                    if (hWnd != IntPtr.Zero)
                    {
                        // 按下 Ctrl 键
                        PostMessage(hWnd, WM_CHAR, (IntPtr)VK_CONTROL, IntPtr.Zero);

                        // 按下 C 键
                        PostMessage(hWnd, WM_CHAR, (IntPtr)VK_C, IntPtr.Zero);

                        // 释放 C 键
                        PostMessage(hWnd, WM_CHAR, (IntPtr)VK_C, (IntPtr)0x80000000);

                        // 释放 Ctrl 键
                        PostMessage(hWnd, WM_CHAR, (IntPtr)VK_CONTROL, (IntPtr)0x80000000);
                    }
                }
            }
        }

        //向cmd窗口发送ctrl+c，方法2
        public class CmdProcessController
        {
            [DllImport("kernel32.dll")]
            public static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);

            public static void SendCtrlCSignal(Process process)
            {
                const uint CTRL_C_EVENT = 0x0000;
                GenerateConsoleCtrlEvent(CTRL_C_EVENT, (uint)process.SessionId);
            }
        }


        //[DllImport("kernel32.dll")]
        //public static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);
        ////向指定进程id的窗口发送ctrl+c
        //public static void SendCtrlCSignal(int processId)
        //{
        //    const uint CTRL_C_EVENT = 0x0000;

        //    Process process = Process.GetProcessById(processId);
        //    if (process != null)
        //    {
        //        GenerateConsoleCtrlEvent(CTRL_C_EVENT, (uint)process.SessionId);
        //    }
        //}

        //使用进程id隐藏应用窗口
        public class WindowHider
        {
            private const int SW_HIDE = 0;
            private const int SW_SHOW = 5;

            [DllImport("user32.dll")]
            private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            [DllImport("user32.dll")]
            private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

            [DllImport("user32.dll")]
            private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

            public static void HideWindowByProcessId(int processId)
            {
                IntPtr hWnd = GetMainWindowHandle(processId);
                if (hWnd != IntPtr.Zero)
                {
                    ShowWindow(hWnd, SW_HIDE);
                }
            }

            public static void ShowWindowByProcessId(int processId)
            {
                IntPtr hWnd = GetMainWindowHandle(processId);
                if (hWnd != IntPtr.Zero)
                {
                    ShowWindow(hWnd, SW_SHOW);
                }
            }

            private static IntPtr GetMainWindowHandle(int processId)
            {
                Process process = Process.GetProcessById(processId);
                IntPtr hWnd = process.MainWindowHandle;

                if (hWnd == IntPtr.Zero)
                {
                    // 如果主窗口句柄为0，尝试获取顶级窗口句柄
                    hWnd = GetWindow(process.Handle, 5); // GW_CHILD = 5
                }

                return hWnd;
            }
        }


        ILog log = log4net.LogManager.GetLogger(typeof(Page3));
        private void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                Dispatcher.Invoke(() =>
                {
                    anoutput= e.Data;
                    //HandyControl.Controls.Growl.SuccessGlobal(anoutput);
                    outputall = outputall+e.Data+Environment.NewLine;
                    OutputTextBox.Text = outputall;
                    //OutputTextBox.ScrollToEnd();
                    log.Info(anoutput);
                });
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            room mainWindow = new room(); // 实例化主窗口
            mainWindow.Show(); // 显示主窗口
        }

        

        private void GetSeverPorts_Click(object sender, RoutedEventArgs e)
        {
            
            List<int> openedPorts = GetMinecraftServerPorts();
            string portsText = string.Join(", ", openedPorts);
            MessageBox.Show($"Minecraft Server Opened Ports: {portsText}");
        }
        private List<int> GetMinecraftServerPorts()
        {
            List<int> openedPorts = new List<int>();

            Process[] processes = Process.GetProcessesByName("javaw");
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
    
    public static class ProcessExtensions
    {
        public static Task WaitForExitAsync(this Process process)
        {
            var tcs = new TaskCompletionSource<bool>();

            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(true);

            return tcs.Task;
        }


    }
}









