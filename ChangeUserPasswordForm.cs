//文件名：ChangeUserPasswordForm.cs
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
  public partial class ChangeUserPasswordForm : Form
  {
    public ChangeUserPasswordForm()
    {
      InitializeComponent();
    }
    private void 返回系统Button_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void 修改密码Button_Click(object sender, EventArgs e)
    {
      if (!(this.新密码TextBox.Text == this.再输一次新密码TextBox.Text) || (this.新密码TextBox.Text.Length == 0))
      {
        MessageBox.Show("两次密码的输入不一致！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      string MyHashName = "SHA1";
      //创建一个哈希算法
      HashAlgorithm MyHashAlgorithm = HashAlgorithm.Create(MyHashName);
      string MyNewPassword = this.新密码TextBox.Text;
      //转换密码字符串为一个字节数组
      byte[] MyNewPasswordData = Encoding.Default.GetBytes(MyNewPassword);
      //生成密码字符串的哈希码
      byte[] MyNewHash = MyHashAlgorithm.ComputeHash(MyNewPasswordData);
      //显示密码对应的哈希码
      string MyNewPW = BitConverter.ToString(MyNewHash);
      string MyOldPassword = this.旧密码TextBox.Text;
      byte[] MyOldPasswordData = Encoding.Default.GetBytes(MyOldPassword);
      byte[] MyOldHash = MyHashAlgorithm.ComputeHash(MyOldPasswordData);
      string MyOldPW = BitConverter.ToString(MyOldHash);
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "Update  操作用户 Set 用户密码='" + MyNewPW + "' Where 用户名称='" + this.用户名称TextBox.Text + "' AND 用户密码='" + MyOldPW + "'";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      OleDbCommand MyCommand = new OleDbCommand(MySQL, MyConnection);
      MyCommand.Connection.Open();
      int MyCount = MyCommand.ExecuteNonQuery();
      if (MyCount == 1)
      {
        MessageBox.Show("在数据库中修改用户密码操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("在数据库中修改用户密码操作失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
    }
  }
}