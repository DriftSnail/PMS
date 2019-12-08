//文件名：Program.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace MyCommunity
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //使用默认窗体作为启动窗体
            //Application.Run(new Form1());
            //使用自定义窗体作为启动窗体
            Application.Run(new MainForm());
        }
    }
}
