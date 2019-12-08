//文件名：MoveForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
namespace MyCommunity
{
  public partial class MoveForm : Form
  {
    public MoveForm()
    {
      InitializeComponent();
    }
    private void 迁出信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.迁出信息BindingSource.EndEdit();
      this.迁出信息TableAdapter.Update(this.dBCommunityDataSet.迁出信息);
    }
    private void MoveForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
      this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息);
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.迁出信息”中
      this.迁出信息TableAdapter.Fill(this.dBCommunityDataSet.迁出信息);
    }
    private void 查询ToolStripButton_Click(object sender, EventArgs e)
    {
      this.迁出信息BindingSource.Filter="业主编号 LIKE '"+this.业主编号ToolStripTextBox.Text+"'";
    }
    private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {//获取指定楼栋的业主信息
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string My楼栋名称 = this.楼栋名称ComboBox.Text;
      string MySQL = "SELECT * FROM [业主信息] WHERE (业主编号 NOT IN (SELECT 业主编号 FROM 迁出信息)) AND ([楼栋名称] = '" + My楼栋名称 + "')";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      DataTable MyTable = new DataTable();
      OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdapter.Fill(MyTable);
      this.业主姓名ComboBox.DataSource = MyTable;
      this.业主姓名ComboBox.DisplayMember = "业主姓名";
      this.业主姓名ComboBox.ValueMember = "业主编号";
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
    }
    private void 业主姓名ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
      {
        this.业主编号TextBox.Text = this.业主姓名ComboBox.SelectedValue.ToString();
      }
    }
  }
}