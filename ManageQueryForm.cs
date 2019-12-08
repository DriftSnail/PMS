//文件名：ManageQueryForm.cs
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
  public partial class ManageQueryForm : Form
  {
    public ManageQueryForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    private System.Data.DataTable MyTable = new System.Data.DataTable(); 
    private void ManageQueryForm_Load(object sender, EventArgs e)
    {
      for (int i = 2006; i <= 2030; i++)
      {
        this.计费年份ComboBox.Items.Add(i.ToString());
      }
      this.计费月份ComboBox.Items.Add("全年");
      for (int i = 1; i <= 12; i++)
      {
        this.计费月份ComboBox.Items.Add(i.ToString());
      }
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
      this.业主姓名ComboBox.Items.Add("全部");
      this.费用状态ComboBox.Items.Add("全部");
      this.费用状态ComboBox.Items.Add("已交费");
      this.费用状态ComboBox.Items.Add("未交费");
    }
    private void 查询Button_Click(object sender, EventArgs e)
    {
      MyTable.Rows.Clear();
      string MySQL = "Select * FROM 物管费用 WHERE (登记标志='完成登记') AND (计费年份= " + this.计费年份ComboBox.Text + ")";
      if (this.计费月份ComboBox.Text == "全年")
        MySQL += "";
      else
        MySQL += " AND (计费月份=" + this.计费月份ComboBox.Text + ")";
      if (this.楼栋名称ComboBox.Text == "全部")
        MySQL += "";
      else
        MySQL += " AND (楼栋名称='" + this.楼栋名称ComboBox.Text + "')";
      if (this.业主姓名ComboBox.Text == "全部")
        MySQL += "";
      else
        MySQL += " AND (业主姓名='" + this.业主姓名ComboBox.Text + "')";
      if (this.费用状态ComboBox.Text == "全部")
        MySQL += "";
      else
        MySQL += " AND (费用状态='" + this.费用状态ComboBox.Text + "')";
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      OleDbDataAdapter MyAdatper = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdatper.Fill(MyTable);
      this.物管费用DataGridView.DataSource = MyTable;
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }              
    }
    private void 打印Button_Click(object sender, EventArgs e)
    {//打印物管费用信息
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
          MyData[j, i] = MyRow[i].ToString();
        }
        j++;
      }
      MyRange = MyRange.get_Resize(this.MyTable.Rows.Count + 1, this.MyTable.Columns.Count);
      MyRange.Value2 = MyData;
      MyRange.EntireColumn.AutoFit();
      MyWorkSheet.Cells[2, 2] = this.MyCommunity + "物管费用表";
      Range MyRange22 = MyWorkSheet.get_Range("B2", "B2");
      MyRange22.Font.Bold = true;
      MyRange22.Font.Size = "20";
      MyWorkSheet.Cells[4, 1] = "打印日期：" + DateTime.Now.ToShortDateString();
    }
    private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.业主姓名ComboBox.Items.Clear();
      this.业主姓名ComboBox.Items.Add("全部");
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "SELECT * FROM [业主信息] WHERE ([楼栋名称] ='" + this.楼栋名称ComboBox.Text + "')";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      System.Data.DataTable ItemTable = new System.Data.DataTable();
      OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdapter.Fill(ItemTable);
      foreach (DataRow MyRow in ItemTable.Rows)
      {
        this.业主姓名ComboBox.Items.Add(MyRow["业主姓名"].ToString());
      }
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
    }
  }
}