//文件名：ManageRegisterForm.cs
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
  public partial class ManageRegisterForm : Form
  {
    public ManageRegisterForm()
    {
      InitializeComponent();
    }
    private void 物管费用BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.物管费用BindingSource.EndEdit();
      this.物管费用TableAdapter.Update(this.dBCommunityDataSet.物管费用);
    }
    private void ManageRegisterForm_Load(object sender, EventArgs e)
    {
      for (int i = 2006; i <= 2030; i++)
      {
        this.计费年份ToolStripComboBox.Items.Add(i.ToString());
      }
      for (int i = 1; i <= 12; i++)
      {
        this.计费月份ToolStripComboBox.Items.Add(i.ToString());
      }
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "SELECT * FROM [楼栋信息]";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      DataTable ItemTable = new DataTable();
      OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdapter.Fill(ItemTable);
      foreach (DataRow MyRow in ItemTable.Rows)
      {
        this.楼栋名称ToolStripComboBox.Items.Add(MyRow["楼栋名称"].ToString());
      }
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
    }
    private void 查询ToolStripButton_Click(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.物管费用”中
      this.物管费用TableAdapter.Fill(this.dBCommunityDataSet.物管费用);
      this.物管费用BindingSource.Filter = "楼栋名称='" + 楼栋名称ToolStripComboBox.Text + "' AND 计费年份=" + 计费年份ToolStripComboBox.Text + " AND 计费月份=" + 计费月份ToolStripComboBox.Text + "  AND 登记标志='正在登记'";          
    }
    private void 新增ToolStripButton_Click(object sender, EventArgs e)
    {//新增物管费用信息
      string MyAddInfo = "现在将新增指定月份的物业管理费数据，是否继续？";
      if (MessageBox.Show(MyAddInfo, "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        return;
      }
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      string MySQL = "Select Count(*) From 物管费用 WHERE 计费年份=" + this.计费年份ToolStripComboBox.Text + " AND 计费月份=" + this.计费月份ToolStripComboBox.Text + " AND 楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "'";
      OleDbCommand MyCommand = MyConnection.CreateCommand();
      MyCommand.CommandText = MySQL;
      string MyCount = MyCommand.ExecuteScalar().ToString();
      if (Convert.ToInt16(MyCount) == 0)
      {
        //插入新月份的物管费用基本信息
        MySQL = "INSERT INTO 物管费用 (楼栋名称,业主编号,业主姓名,建筑面积,套内面积) SELECT 楼栋名称,业主编号,业主姓名,建筑面积,套内面积 FROM 业主信息 WHERE (业主编号 NOT IN (SELECT 业主编号 FROM 迁出信息)) AND (楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "')";
        MyCommand.CommandText = MySQL;
        MyCommand.ExecuteNonQuery();
        MySQL = "UPDATE 物管费用 SET 登记标志='正在登记',计费年份=" + this.计费年份ToolStripComboBox.Text + ",计费月份=" + this.计费月份ToolStripComboBox.Text + " WHERE 登记标志 IS NULL";
        MyCommand.CommandText = MySQL;
        MyCommand.ExecuteNonQuery();
        int MyLastMonth = Convert.ToInt16(this.计费月份ToolStripComboBox.Text) - 1;
        int MyLastYear = Convert.ToInt16(this.计费年份ToolStripComboBox.Text);
        if (MyLastMonth == 0)
        {
          MyLastMonth = 12;
          MyLastYear = Convert.ToInt16(this.计费年份ToolStripComboBox.Text) - 1;
        }
        //将上月计费单价作为新月物管费用计费单价
        MySQL = "Select 业主编号,计费单价 FROM 物管费用 WHERE 计费年份=" + MyLastYear.ToString() + " AND 计费月份=" + MyLastMonth.ToString() + " AND 楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "' AND 登记标志='完成登记'";
        DataTable MyComputeTable = new DataTable();
        OleDbDataAdapter MyAdatper = new OleDbDataAdapter(MySQL, MyConnection);
        MyAdatper.Fill(MyComputeTable);
        foreach (DataRow MyRow in MyComputeTable.Rows)
        {
          string My业主编号 = MyRow[0].ToString();
          string My计费单价 = MyRow[1].ToString();
          MySQL = "UPDATE 物管费用 SET 计费单价=" + My计费单价 + " WHERE 计费年份=" + this.计费年份ToolStripComboBox.Text + " AND 计费月份=" + this.计费月份ToolStripComboBox.Text + " AND 楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "' AND 业主编号='" + My业主编号 + "'";
          MyCommand.CommandText = MySQL;
          MyCommand.ExecuteNonQuery();
        }
      }
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
      this.物管费用TableAdapter.Fill(this.dBCommunityDataSet.物管费用);
      this.物管费用BindingSource.Filter = "楼栋名称='" + 楼栋名称ToolStripComboBox.Text + "' AND 计费年份=" + 计费年份ToolStripComboBox.Text + " AND 计费月份=" + 计费月份ToolStripComboBox.Text + "  AND 登记标志='正在登记'";
    }
    private void 登记ToolStripButton_Click(object sender, EventArgs e)
    {//登记物管费用信息
      string MyRegInfo = "现在将登记指定月份的物业管理费数据，是否继续？";
      if (MessageBox.Show(MyRegInfo, "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        return;
      }
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      string MySQL = "UPDATE 物管费用 SET 登记标志='完成登记',费用状态='未交费' WHERE 计费年份=" + 计费年份ToolStripComboBox.Text + " AND 计费月份=" + 计费月份ToolStripComboBox.Text + "  AND 楼栋名称='" + 楼栋名称ToolStripComboBox.Text + "'";
      OleDbCommand MyCommand = MyConnection.CreateCommand();
      MyCommand.CommandText = MySQL;
      MyCommand.ExecuteNonQuery();
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
      this.物管费用TableAdapter.Fill(this.dBCommunityDataSet.物管费用);
      this.物管费用BindingSource.Filter = "楼栋名称='" + 楼栋名称ToolStripComboBox.Text + "' AND 计费年份=" + 计费年份ToolStripComboBox.Text + " AND 计费月份=" + 计费月份ToolStripComboBox.Text + "  AND 登记标志='正在登记'";          
    }
  }
}