using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
using System.Xml.Linq;
using System.Xml.Schema;
using n2nmc.View.Pagey;
using n2nmc.View;
using log4net;
using log4net.Config;
using System.Timers;
using System.Windows.Threading;
using N2Nmc.View;

namespace n2nmc.View.Pagey
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    
    public partial class Page1 : Page
    {
        
        ILog log = log4net.LogManager.GetLogger(typeof(Page1));
        List<Card> cardsall = new List<Card>();

        // 定义数据库连接参数
        public static string serverall = "14.29.239.175"; //服务器地址
        public static int portall = 3306; //端口
        public static string usernameall = "root"; //用户名
        public static string passwordall = "xjb123456"; //密码
        public static string databaseall = "n2n"; //数据库名
        // 创建连接字符串
        public static string connectionStringall = $"server={serverall};port={portall};user={usernameall};password={passwordall};database={databaseall};";

        public Page1()
        {
            
            InitializeComponent();
            

            // 创建连接对象
            using (MySqlConnection connection = new MySqlConnection(connectionStringall))
            {
                
                Console.WriteLine("连接成功");
                HandyControl.Controls.Growl.SuccessGlobal("连接成功");
                // 打开数据库连接
                connection.Open();
                Console.WriteLine("打开成功");
                // 创建 SQL 查询语句
                string sql = "SELECT * FROM user";  //SELECT * FROM user(表名)

                // 创建命令对象
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    // 执行查询并获取数据读取器
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("开始查询");
                        // 创建一个包含卡片数据的集合
                        List<Card> cards = new List<Card>();

                        // 遍历数据读取器并输出结果
                        while (reader.Read())
                        {

                            string column1Value = reader.GetString("user");
                            string column2Value = ""; //reader.GetString("p");

                            Console.WriteLine($"user: {column1Value}, p: {column2Value}");
                            log.Info($"user: {column1Value}, p: {column2Value}");
                            
                            Console.WriteLine($"user: {column1Value}, p: {column2Value}");
                            log.Info($"user: {column1Value}, p: {column2Value}");
                            cards.Add(new Card { Title = column1Value });
                            
                            

                        }
                        cardsall = cards;
                        // 将集合绑定到 ItemsControl 控件的 ItemsSource 属性
                        myItemsControl.ItemsSource = cards;
                        
                    }
                }

                // 关闭数据库连接
                connection.Close();
            }

        }


        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // 在这里添加按钮单击事件的处理逻辑

        //    // 判断按钮的 Command 是否等于集合中的某个数据，并返回数据的位置信息
        //    Button button = (Button)sender;
        //    string Command1 = button.Command.ToString();
        //    Console.WriteLine(Command1);
        //    Console.WriteLine(cardsall);
        //    //int index = cardsall.FindIndex(card => card == Command1);
        //    int index = 0;

        //    if (index != -1)
        //    {
        //        // 找到了匹配的数据
        //        // index 是数据在集合中的位置信息
        //        // 可以根据需要进行进一步处理
        //        Console.WriteLine($"找到了 Command 为 {button.Command} 的对象，位置为 {index}。");
        //    }
        //    else
        //    {
        //        // 没有找到匹配的数据
        //        Console.WriteLine($"未找到 Command 为 {button.Command} 的对象。");
        //    }
        //}

        public static string? jie = "";
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            ILog log = log4net.LogManager.GetLogger(typeof(Page1));
            passwordall = "123456";

            if (MainView.RunFilePath == "") {
                HandyControl.Controls.Growl.SuccessGlobal("请转到设置添加启动器路径");

            }



            // 获取点击的按钮
            Button button = (Button)sender;

            // 获取按钮绑定的数据对象
            Card card = (Card)button.DataContext;

            // 获取按钮对应的标题
            string? title = card.Title;
            jie = title;
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // 显示反馈消息框
            //MessageBox.Show($"你点击了按钮：{title}");

            // 创建一个新的线程，并传递一个匿名方法作为线程要执行的方法
            //Thread thread = new Thread(() => RunCmdCommand(currentDirectory + "edge\\edge.exe -c " + title + " -k " + passwordall + " -l " + MainView.severip));

            HandyControl.Controls.Growl.SuccessGlobal("正在加入房间,请稍后...");

            // 创建一个定时器，检测是否启动成功
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();


            Page3.commandall = currentDirectory + "edge\\edge.exe -c " + title + " -k " + passwordall + " -l "+MainView.severip;
            Page3 page3 = new Page3();
            await page3.ExecuteCommandAsync(Page3.commandall);


            // 启动线程
            //thread.Start();
            Console.WriteLine(currentDirectory + "edge\\edge.exe -c " + title + " -k " + passwordall + " -l " + MainView.severip);
            //MainView.Framez.Source = new Uri("Pagey/.xaml", UriKind.Relative);
            //MainView.tiaozhuan("Page5");
            log.Info(currentDirectory + "edge\\edge.exe -c " + title + " -k " + passwordall + " -l " + MainView.severip);
            Console.WriteLine("log写入");

        }


        //文本对比,用于检测n2n是否启动成功
        private DispatcherTimer timer;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            // 更新文本框的内容
            if (Page3.anoutput.Contains("[OK] edge <<< ================ >>> supernode"))
            {
                
                HandyControl.Controls.Growl.SuccessGlobal("房间加入成功");
                
                timer.Stop();
                //启动房间窗口
                if (jie == "")
                {
                    HandyControl.Controls.Growl.SuccessGlobal("未获取到房间名称");
                    Page2.guanbibi();
                    timer.Stop();
                }
                else {
                    MainView.jiedian = jie;
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
            

        }


        //运行cmd命令，无实时回显，已废弃
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
            startInfo.CreateNoWindow = true;  // 不创建新窗口

            process.StartInfo = startInfo;

            // 启动进程
            process.Start();
            HandyControl.Controls.Growl.SuccessGlobal("已加入房间");
            // 读取并显示输出结果
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            //log输出
            ILog log = log4net.LogManager.GetLogger(typeof(Page2));
            log.Info(output);
            //log.Info(output);
            HandyControl.Controls.Growl.SuccessGlobal("房间已关闭");
            // 等待进程结束
            process.WaitForExit();
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ScrollBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }

    public class Card
    {

        public string? Title { get; set; }
    }
}

