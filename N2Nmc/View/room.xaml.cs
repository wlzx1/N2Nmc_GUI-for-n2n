using HandyControl.Controls;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using n2nmc.View;
using log4net;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using N2Nmc.csl.LANChat;

namespace N2Nmc.View
{
    /// <summary>
    /// room.xaml 的交互逻辑
    /// </summary>
    public partial class room : System.Windows.Window
    {
        
        public room()
        {
            InitializeComponent();

            // 创建局域网群聊客户端
            StartListening();

        }

        //关闭窗口
        private void Buttonguanbi_Click(object sender, RoutedEventArgs e)
        {
            // 关闭当前窗口
            n2nmc.View.Pagey.Page2.guanbibi();
            StopListening();
            Close();
        }

        //窗口移动
        private void Winmove_room(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
        //最小化窗口
        private void Buttonzuixiaohua_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        public class DataItem
        {
            public string? Community { get; set; }
            public string? Ip4Address { get; set; }
            public string? StuIda { get; set; }
        }
        public string? json;

        //初次访问api
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string url = "http://"+MainView.severapi+"/edges?"+MainView.jiedian;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    json = await response.Content.ReadAsStringAsync();

                    // 在这里处理返回的 JSON 数据
                    Console.WriteLine(json);
                    //HandyControl.Controls.Growl.SuccessGlobal(json);
                    ILog log = log4net.LogManager.GetLogger(typeof(room));
                    log.Info(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("发生异常: " + ex.Message);
                    ILog log = log4net.LogManager.GetLogger(typeof(room));
                    log.Error(ex.Message);
                }
            }

            if (json != null)
            {
                JArray jsonArray = JArray.Parse(json);
                List<DataItem> dataItems = new List<DataItem>();
                int StuId = 0;
                foreach (JObject jsonObject in jsonArray)
                {
                    StuId += 1;
                    string? community = (string?)jsonObject["desc"];
                    string? ip4addr = (string?)jsonObject["ip4addr"];

                    string? ip4 = null;

                    if (ip4addr != null)
                    {
                        int index = ip4addr.IndexOf("/");
                        ip4 = ip4addr.Substring(0, index);
                    }

                    dataItems.Add(new DataItem { StuIda = StuId.ToString(), Community = community, Ip4Address = ip4 });
                }

                DataGridroom.ItemsSource = dataItems;
            }
            else
            {
                HandyControl.Controls.Growl.SuccessGlobal("未获取到房间列表");
            }
        }
        //刷新api数据
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "http://" + MainView.severapi + "/edges?" + MainView.jiedian;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    json = await response.Content.ReadAsStringAsync();

                    // 在这里处理返回的 JSON 数据
                    Console.WriteLine(json);
                    //HandyControl.Controls.Growl.SuccessGlobal(json);
                    ILog log = log4net.LogManager.GetLogger(typeof(room));
                    log.Info(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("发生异常: " + ex.Message);
                    HandyControl.Controls.Growl.SuccessGlobal("发生异常: " + ex.Message);
                    ILog log = log4net.LogManager.GetLogger(typeof(room));
                    log.Error("发生异常: " + ex.Message);
                }
            }

            if (json != null)
            {
                JArray jsonArray = JArray.Parse(json);
                List<DataItem> dataItems = new List<DataItem>();
                int StuId = 0;
                foreach (JObject jsonObject in jsonArray)
                {
                    StuId += 1;
                    string? community = (string?)jsonObject["desc"];
                    string? ip4addr = (string?)jsonObject["ip4addr"];

                    string? ip4 = null;

                    if (ip4addr != null)
                    {
                        int index = ip4addr.IndexOf("/");
                        ip4 = ip4addr.Substring(0, index);
                    }

                    dataItems.Add(new DataItem { StuIda = StuId.ToString(), Community = community, Ip4Address = ip4 });
                }

                DataGridroom.ItemsSource = dataItems;
            }
            else {
                HandyControl.Controls.Growl.SuccessGlobal("未获取到房间列表");
            }

            

            

            
        }

        //发送消息
        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (DataItem item in DataGridroom.Items)
            {
                SendMessage(item.Ip4Address, messageTextBox.Text);
                HandyControl.Controls.Growl.SuccessGlobal("向"+item.Ip4Address+"发送"+messageTextBox.Text);
            }
        }

        //向指定IP地址发送消息的方法
        private void SendMessage(string ipAddress, string message)
        {
            try
            {
                using (var client = new UdpClient())
                {
                    var ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), 8888);
                    var bytes = Encoding.UTF8.GetBytes(message);
                    client.Send(bytes, bytes.Length, ipEndPoint);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message);
            }
        }

        //消息接收服务
        private UdpClient udpClient;
        private int port = 8888;
        //启动udp客户端
        private void StartListening()
        {
            udpClient = new UdpClient(port);
            HandyControl.Controls.Growl.SuccessGlobal("已在端口"+port+"端口启用聊天");
            udpClient.BeginReceive(ReceiveCallback, null);
        }

        private void StopListening()
        {
            // 关闭UDP客户端
            udpClient.Close();
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            
            // 检查UDP客户端是否已关闭
            if (udpClient.Client == null || !udpClient.Client.Connected)
            {
                HandyControl.Controls.Growl.SuccessGlobal("UDP客户端已关闭");
                return;
            }

            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, port);
            byte[] receivedBytes = udpClient.EndReceive(ar, ref remoteEndPoint);
            string receivedMessage = Encoding.UTF8.GetString(receivedBytes);

            // 在这里处理接收到的消息（receivedMessage）
            //HandyControl.Controls.Growl.SuccessGlobal("收到消息："+receivedMessage);
            //TextBlock_Chat.Text += "消息："+receivedMessage + Environment.NewLine;
            
            Dispatcher.Invoke(() =>
            {
                
                TextBlock_Chat.Text += "消息：" + receivedMessage + Environment.NewLine;
                HandyControl.Controls.Growl.SuccessGlobal("收到消息：" + receivedMessage);
            });
            // 继续监听下一个消息
            udpClient.BeginReceive(ReceiveCallback, null);
        }

        
    }

}

