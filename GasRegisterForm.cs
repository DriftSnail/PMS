//文件名：GasRegisterForm.cs
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
  public partial class GasRegisterForm : Form
  {
    public GasRegisterForm()
    {
      InitializeComponent();
    }
    private void 水电气费BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.水电气费BindingSource.EndEdit();
      this.水电气费TableAdapter.Update(this.dBCommunityDataSet.水电气费);
    }
    private void GasRegisterForm_Load(object sender, EventArgs e)
    {
      for (int i = 2006; i <= 2030; i++)
      {
        this.计费年份ToolStripComboBox.Items.Add(i.ToString());
      }
      for (int i = 1; i <= 12; i++)
      {
        this.计费月份ToolStripComboBox.Items.Add(i.ToString());
      }
      this.费用类型ToolStripComboBox.Items.Add("水费");
      this.费用类型ToolStripComboBox.Items.Add("电费");
      this.费用类型ToolStripComboBox.Items.Add("气费");
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "SELECT * FROM [楼栋信息]";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      DataTable MyTable = new DataTable();
      OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdapter.Fill(MyTable);
      foreach (DataRow MyRow in MyTable.Rows)
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
      this.水电气费TableAdapter.Fill(this.dBCommunityDataSet.水电气费);
      this.水电气费BindingSource.Filter = "楼栋名称='" + 楼栋名称ToolStripComboBox.Text + "' AND 计费年份=" + 计费年份ToolStripComboBox.Text + " AND 计费月份=" + 计费月份ToolStripComboBox.Text + " AND 费用类型='" + 费用类型ToolStripComboBox.Text + "' AND 登记标志='正在登记'";   
    }
    private void 新增ToolStripButton_Click(object sender, EventArgs e)
    {//新增水电气费
      string MyAddInfo = "现在将新增指定月份的水电气费数据，是否继续？";
      if (MessageBox.Show(MyAddInfo, "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        return;
      }
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      string MySQL = "Select Count(*) From 水电气费 WHERE 计费年份=" + this.计费年份ToolStripComboBox.Text + " AND 计费月份=" + this.计费月份ToolStripComboBox.Text + " AND 费用类型='" + this.费用类型ToolStripComboBox.Text + "' AND 楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "'";
      OleDbCommand MyCommand = new OleDbCommand(MySQL, MyConnection);
      string MyCount = MyCommand.ExecuteScalar().ToString();
      if (Convert.ToInt16(MyCount) == 0)
      {//插入新月份费用的业主基本信息
        MySQL = "INSERT INTO 水电气费 (楼栋名称,业主编号,业主姓名) SELECT 楼栋名称,业主编号,业主姓名 FROM 业主信息 WHERE (业主编号 NOT IN (SELECT 业主编号 FROM 迁出信息)) AND (楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "')";
        MyCommand.CommandText = MySQL;
        MyCommand.ExecuteNonQuery();
        MySQL = "UPDATE 水电气费 SET 登记标志='正在登记',费用类型='" + this.费用类型ToolStripComboBox.Text + "',计费年份=" + this.计费年份ToolStripComboBox.Text + ",计费月份=" + this.计费月份ToolStripComboBox.Text + " WHERE 登记标志 IS NULL";
        MyCommand.CommandText = MySQL;
        MyCommand.ExecuteNonQuery();
        int MyLastMonth = Convert.ToInt16(this.计费月份ToolStripComboBox.Text) - 1;
        int MyLastYear = Convert.ToInt16(this.计费年份ToolStripComboBox.Text);
        if (MyLastMonth == 0)
        {
          MyLastMonth = 12;
          MyLastYear = Convert.ToInt16(this.计费年份ToolStripComboBox.Text) - 1;
        }
        //将上月止数作为新月份底数
        MySQL = "Select 楼栋名称,业主编号,业主姓名,计费年份,计费月份,费用类型,表编号,表底数,表止数,计费单价 FROM 水电气费 WHERE 计费年份=" + MyLastYear.ToString() + " AND 计费月份=" + MyLastMonth.ToString() + " AND 费用类型='" + this.费用类型ToolStripComboBox.Text + "' AND 楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "' AND 登记标志='完成登记'";
        DataTable MyComputeTable = new DataTable();
        OleDbDataAdapter MyAdatper = new OleDbDataAdapter(MySQL, MyConnection);
        MyAdatper.Fill(MyComputeTable);
        foreach (DataRow MyRow in MyComputeTable.Rows)
        {
          string My楼栋名称 = MyRow[0].ToString();
          string My业主编号 = MyRow[1].ToString();
          string My业主姓名 = MyRow[2].ToString();
          string My计费年份 = MyRow[3].ToString();
          string My计费月份 = MyRow[4].ToString();
          string My费用类型 = MyRow[5].ToString();
          string My表编号 = MyRow[6].ToString();
          string My表底数 = MyRow[7].ToString();
          string My表止数 = MyRow[8].ToString();
          string My计费单价 = MyRow[9].ToString();                    
          MySQL = "UPDATE 水电气费 SET 表编号='" + My表编号 + "',表底数=" + My表止数 + ",计费单价=" + My计费单价 + " WHERE 计费年份=" + this.计费年份ToolStripComboBox.Text + " AND 计费月份=" + this.计费月份ToolStripComboBox.Text + " AND 费用类型='" + this.费用类型ToolStripComboBox.Text + "' AND 楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "' AND 业主编号='" + My业主编号 + "'";
          MyCommand.CommandText = MySQL;
          MyCommand.ExecuteNonQuery();
        }
      }
      if (MyConnection.State == ConnectionState.Open)
      {
         MyConnection.Close();
      }
      this.水电气费TableAdapter.Fill(this.dBCommunityDataSet.水电气费);
      this.水电气费BindingSource.Filter = "楼栋名称='" + 楼栋名称ToolStripComboBox.Text + "' AND 计费年份=" + 计费年份ToolStripComboBox.Text + " AND 计费月份=" + 计费月份ToolStripComboBox.Text + " AND 费用类型='" + 费用类型ToolStripComboBox.Text + "' AND 登记标志='正在登记'";   
    }
    private void 登记ToolStripButton_Click(object sender, EventArgs e)
    {
      string MyRegInfo = "登记水电气费数据意味着本月正在登记的数据将无法再修改，是否继续？";
      if (MessageBox.Show(MyRegInfo, "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
         return;
      }
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      string MySQL = "UPDATE 水电气费 SET 登记标志='完成登记',费用状态='未交费' WHERE 计费年份=" + this.计费年份ToolStripComboBox.Text + " AND 计费月份=" + this.计费月份ToolStripComboBox.Text + " AND 费用类型='" + this.费用类型ToolStripComboBox.Text + "' AND 楼栋名称='" + this.楼栋名称ToolStripComboBox.Text + "'";
      OleDbCommand MyCommand = MyConnection.CreateCommand();
      MyCommand.CommandText = MySQL;
      MyCommand.ExecuteNonQuery();
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
      this.水电气费TableAdapter.Fill(this.dBCommunityDataSet.水电气费);
      this.水电气费BindingSource.Filter = "楼栋名称='" + 楼栋名称ToolStripComboBox.Text + "' AND 计费年份=" + 计费年份ToolStripComboBox.Text + " AND 计费月份=" + 计费月份ToolStripComboBox.Text + " AND 费用类型='" + 费用类型ToolStripComboBox.Text + "' AND 登记标志='正在登记'";          
    }
  }
}