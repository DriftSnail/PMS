//文件名：OperatorForm.cs
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
  public partial class OperatorForm : Form
  {
    public OperatorForm()
    {
        InitializeComponent();
    }
    private void 操作用户BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
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
      string MyUser = this.用户名称TextBox.Text;
      this.Validate();
      this.操作用户BindingSource.EndEdit();
      this.操作用户TableAdapter.Update(this.dBCommunityDataSet.操作用户);
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "Update 操作用户 Set 用户密码='" + MyPW + "' WHERE 用户名称='" + MyUser + "'";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      OleDbCommand MyCommand = new OleDbCommand(MySQL, MyConnection);
      MyCommand.Connection.Open();
      int MyCount = MyCommand.ExecuteNonQuery();
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
      this.操作用户TableAdapter.Fill(this.dBCommunityDataSet.操作用户);
    }
    private void OperatorForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.操作用户”中
      this.操作用户TableAdapter.Fill(this.dBCommunityDataSet.操作用户);
    }
  }
}