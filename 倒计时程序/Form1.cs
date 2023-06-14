using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 倒计时程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Point 鼠标按下时的位置;
        private bool 鼠标是否按下;
        private void 文本显示_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                鼠标是否按下 = true;
                鼠标按下时的位置 = new Point(-e.X, -e.Y);
            }
        }

        private void 文本显示_MouseUp(object sender, MouseEventArgs e)
        {
            鼠标是否按下 = false;
        }

        private void 文本显示_MouseMove(object sender, MouseEventArgs e)
        {
            if(鼠标是否按下)
            {
                Point 位置设定 = MousePosition;
                位置设定.Offset(鼠标按下时的位置.X,鼠标按下时的位置.Y);
                Location = 位置设定;
            }
        }

        private void 循环触发器_Tick(object sender, EventArgs e)
        {
            DateTime 当前时间 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            DateTime 设定时间 = Convert.ToDateTime("2023-7-14");
            TimeSpan 差值 = 设定时间.Subtract(当前时间);
            int 输出 = 差值.Days;
            文本显示.Text = "放假倒计时："+输出+"天";
            循环触发器.Interval = 10000;
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 启用开机自启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey 键根 = Registry.CurrentUser;
            RegistryKey 键路径 = 键根.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            string 程序路径 = Application.ExecutablePath;
            string 获取的值 = 键路径?.GetValue("倒计时")?.ToString() ?? "";
            if (程序路径 == 获取的值)
            {
                键路径.DeleteValue("倒计时");
                启用开机启动ToolStripMenuItem.Checked = false;
            }
            else
            {
                键路径.SetValue("倒计时", 程序路径);
                启用开机启动ToolStripMenuItem.Checked = true;
            }
            键路径.Close();
            键根.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey 键根 = Registry.CurrentUser;
            RegistryKey 键路径 = 键根.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            string 程序路径 = Application.ExecutablePath;
            string 获取的值 = 键路径?.GetValue("倒计时")?.ToString() ?? "";
            if (程序路径 == 获取的值)
            {
                启用开机启动ToolStripMenuItem.Checked = true;
            }
            else
            {
                启用开机启动ToolStripMenuItem.Checked = false;
            }
            键路径.Close();
            键根.Close();
        }
    }
}
