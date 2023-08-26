using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2Nmc.csl
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Windows;

    namespace LANChat
    {
        public class LANChat
        {
            private const int Port = 8888; // 聊天室通信端口号
            private const string BroadcastAddress = "255.255.255.255"; // 广播地址

            private UdpClient udpClient;
            private Thread receiveThread;

            public event Action<string> MessageReceived;

            public LANChat()
            {
                try
                {
                    // 创建UDP客户端
                    udpClient = new UdpClient(Port);

                    // 启动接收消息线程
                    receiveThread = new Thread(ReceiveMessages);
                    receiveThread.IsBackground = true;
                    receiveThread.Start();
                }
                catch (SocketException e)
                {
                    MessageBox.Show("无法启动局域网群聊客户端：" + e.Message);
                }
            }

            public void SendMessage(string message)
            {
                try
                {
                    // 将消息转换为字节数组
                    byte[] data = Encoding.UTF8.GetBytes(message);

                    // 发送消息到指定的广播地址和端口号
                    var remoteEp = new IPEndPoint(IPAddress.Parse(BroadcastAddress), Port);
                    udpClient.Send(data, data.Length, remoteEp);
                }
                catch (SocketException e)
                {
                    MessageBox.Show("发送消息失败：" + e.Message);
                }
            }

            private void ReceiveMessages()
            {
                try
                {
                    while (true)
                    {
                        // 接收从聊天室收到的消息
                        var remoteEp = new IPEndPoint(IPAddress.Any, Port);
                        byte[] data = udpClient.Receive(ref remoteEp);
                        string message = Encoding.UTF8.GetString(data);

                        // 触发消息接收事件
                        MessageReceived?.Invoke(message);
                    }
                }
                catch (SocketException e)
                {
                    MessageBox.Show("接收消息失败：" + e.Message);
                }
            }
        }
    }
}
