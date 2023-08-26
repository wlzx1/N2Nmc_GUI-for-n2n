using HandyControl.Controls;
using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace n2nmc.View.Pagey
{
    /// <summary>
    /// Page5.xaml 的交互逻辑
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();

            // 创建一个定时器，每隔一段时间执行一次更新文本框的方法
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private DispatcherTimer timer;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            // 更新文本框的内容
            textlog.Text = Page3.outputall;
        }
    }
}
