using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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
using static N2Nmc.csl.Class1;
using static N2Nmc.csl.Class2;
using n2nmc.View;



namespace N2Nmc.View.Pagey
{
    /// <summary>
    /// Page6.xaml 的交互逻辑
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
            string filePath = "config.ini";
            IniFile iniFile = new IniFile(filePath);
            lujing.Text = iniFile.ReadValue("set", "RunFilePath");
            //// 写入配置项
            //iniFile.WriteValue("Section1", "Key1", "Value1");
            //iniFile.WriteValue("Section1", "Key2", "Value2");

            //// 读取配置项
            //string value1 = iniFile.ReadValue("Section1", "Key1");
            //string value2 = iniFile.ReadValue("Section1", "Key2");
        }

        private void liulan_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "config.ini";
            IniFile iniFile = new IniFile(filePath);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*"; // 设置文件筛选器，这里将显示所有文件
            if (openFileDialog.ShowDialog() == true) // 显示对话框并检查用户是否点击了“确定”按钮
            {
                string selectedFilePath = openFileDialog.FileName; // 获取用户选择的文件路径
                                                                   // 在这里可以对选择的文件路径进行处理
                                                                   // 例如，将路径显示在文本框中
                lujing.Text = selectedFilePath;
                iniFile.WriteValue("set", "RunFilePath", selectedFilePath);
                MainView.RunFilePath = selectedFilePath;
                SetFirewallRule(selectedFilePath, true); // 允许程序访问网络
            }

        }
        
    }
}
