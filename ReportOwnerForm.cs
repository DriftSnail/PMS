//文件名：ReportOwnerForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;
using System.Reflection;
//using Microsoft.Office.Core;
using System.Data.OleDb;
namespace MyCommunity
{
  public partial class ReportOwnerForm : Form
  {
    public ReportOwnerForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    private System.Data.DataTable MyTable = new System.Data.DataTable();  
    private void ReportOwnerForm_Load(object sender, EventArgs e)
    {
      this.房屋性质ComboBox.Items.Add("全部");
      this.房屋性质ComboBox.Items.Add("住宅");
      this.房屋性质ComboBox.Items.Add("商用");
      this.房屋性质ComboBox.Items.Add("其他");
      this.楼栋名称ComboBox.Items.Add("全部");
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "SELECT * FROM [楼栋信息]";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      System.Data.DataTable ItemTable = new System.Data.DataTable();
      OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdapter.Fill(ItemTable);
      foreach (DataRow MyRow in ItemTable.Rows)
      {
        this.楼栋名称ComboBox.Items.Add(MyRow["楼栋名称"].ToString());
      }
      if (MyConnection.State == ConnectionState.Open)
      {
         MyConnection.Close();
      }
      this.当前状态ComboBox.Items.Add("全部");
      this.当前状态ComboBox.Items.Add("已入住");
      this.当前状态ComboBox.Items.Add("未入住");
      this.当前状态ComboBox.Items.Add("其他");
    }
    private void 查询Button_Click(object sender, EventArgs e)
    {//查询业主信息
      MyTable.Rows.Clear();
      string MySQL = "Select * FROM 业主信息 WHERE (业主编号 NOT IN (Select 业主编号 FROM 迁出信息)) ";
      if (this.楼栋名称ComboBox.Text == "全部")
        MySQL += "";
      else
        MySQL += " AND (楼栋名称='" + this.楼栋名称ComboBox.Text + "')";
      MySQL += " AND (单元名称 LIKE '%" + this.单元名称TextBox.Text + "%')";
      if (this.房屋性质ComboBox.Text == "全部")
        MySQL += "";
      else
        MySQL += " AND (房屋性质='" + this.房屋性质ComboBox.Text + "')";
      MySQL += " AND (房屋类型 LIKE '%" + this.房屋类型TextBox.Text + "%')";
      MySQL += " AND (常住人员 LIKE '%" + this.常住人员TextBox.Text + "%')";
      if (this.当前状态ComboBox.Text == "全部")
        MySQL += "";
      else
        MySQL += " AND (当前状态='" + this.当前状态ComboBox.Text + "')";
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      OleDbDataAdapter MyAdatper = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdatper.Fill(MyTable);
      this.业主报表DataGridView.DataSource = MyTable;
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }            
    }
    private void 打印Button_Click(object sender, EventArgs e)
    {//打印业主报表信息
      ApplicationClass MyExcel;
      Workbooks MyWorkBooks;
      Workbook MyWorkBook;
      Worksheet MyWorkSheet;
      char MyColumns;
      Range MyRange;
      Object[,] MyData = new Object[500, 35];
      int i, j;
      MyExcel = new ApplicationClass();
      MyExcel.Visible = true;
      if (MyExcel == null)
      {
        MessageBox.Show("Excel程序无法启动！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      MyWorkBooks = MyExcel.Workbooks;
      MyWorkBook = MyWorkBooks.Add(Missing.Value);
      MyWorkSheet = (Worksheet)MyWorkBook.Worksheets[1];
      MyColumns = (char)(this.MyTable.Columns.Count + 64);
      MyRange = MyWorkSheet.get_Range("A5", MyColumns.ToString() + "5");
      int Count = 0;
      foreach (DataColumn MyNewColumn in this.MyTable.Columns)
      {
        MyData[0, Count] = MyNewColumn.ColumnName;
        Count = Count + 1;
      }
      j = 1;
      //输出数据库记录
      foreach (DataRow MyRow in this.MyTable.Rows)
      {
        for (i = 0; i < this.MyTable.Columns.Count; i++)
        {
          if (i == 12)
          {
            MyData[j, i] = DateTime.Parse(MyRow[i].ToString()).ToShortDateString();
          }
          else if (i == 2)
          {
            MyData[j, i] ="ID"+ MyRow[i].ToString();
          }
          else
          {
            MyData[j, i] = MyRow[i].ToString();
          }
        }
        j++;
      }
      MyRange = MyRange.get_Resize(this.MyTable.Rows.Count + 1, this.MyTable.Columns.Count);
      MyRange.Value2 = MyData;
      MyRange.EntireColumn.AutoFit();
      MyWorkSheet.Cells[2, 2] = this.MyCommunity + "业主信息表";
      Range MyRange22 = MyWorkSheet.get_Range("B2", "B2");
      MyRange22.Font.Bold = true;
      MyRange22.Font.Size = "20";
      MyWorkSheet.Cells[4, 1] = "打印日期：" + DateTime.Now.ToShortDateString();
    }
  }
}