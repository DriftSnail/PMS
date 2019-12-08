//文件名：LoginForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;
using System.Security.Principal;
using System.Data.OleDb;
namespace MyCommunity
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
	  this.skinEngine1.SkinFile = @"MSN.ssk";
    }
    //记录用户登录次数
    private int MyTryCount = 0;
    private void 退出系统Button_Click(object sender, EventArgs e)
    {
      MainForm MyDlg = (MainForm)this.Owner;
      MyDlg.Close();            
    }
    private void 登录系统Button_Click(object sender, EventArgs e)
    {//从app.config文件中读取数据库连接字符串信息
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "Select COUNT(*) From 操作用户 Where 用户名称=@用户名称 AND 用户密码=@用户密码";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      OleDbCommand MyCommand = new OleDbCommand(MySQL, MyConnection);
      MyCommand.Parameters.Clear();
      OleDbParameter MyNameParameter = new OleDbParameter();
      MyNameParameter.ParameterName = "@用户名称";
      MyNameParameter.Value = this.用户名称TextBox.Text;
      MyCommand.Parameters.Add(MyNameParameter);
      OleDbParameter MyPWParameter = new OleDbParameter();
      MyPWParameter.ParameterName = "@用户密码";
      string MyHashName = "SHA1";
      string MyPassword = this.用户密码TextBox.Text;
      //创建一个哈希算法
      HashAlgorithm MyHashAlgorithm = HashAlgorithm.Create(MyHashName);
      //转换密码字符串为一个字节数组
      byte[] MyPasswordData = Encoding.Default.GetBytes(MyPassword);
      //生成密码字符串的哈希码
      byte[] MyHash = MyHashAlgorithm.ComputeHash(MyPasswordData);
      //显示密码对应的哈希码
      string MyPW = BitConverter.ToString(MyHash);
      MyPWParameter.Value = MyPW;
      MyCommand.Parameters.Add(MyPWParameter);
      int MyCount = (int)MyCommand.ExecuteScalar();
      if (MyCount == 1)
      {
        this.Close();
      }
      else
      {
        this.MyTryCount += 1;
        if (this.MyTryCount != 3)
        {
          int MyDoCount = 3 - this.MyTryCount;
          MessageBox.Show("用户密码或用户名称有错，还有" + MyDoCount + "次机会！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.用户密码TextBox.Text = "";
          this.用户名称TextBox.Text = "";
        }
        else
        {
          退出系统Button_Click(null, null);
        }
      }
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }                  
    }
  }
}