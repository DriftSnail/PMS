//文件名：ReportChargeForm.cs
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
  public partial class ReportChargeForm : Form
  {
    public ReportChargeForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    private System.Data.DataTable MyTable = new System.Data.DataTable();
    private void 查询Button_Click(object sender, EventArgs e)
    {//查询收入统计信息
      MyTable.Rows.Clear();
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "Select * FROM 费用收据 WHERE (收款日期 BETWEEN #" + this.开始日期TextBox.Text + "# AND #" + this.结束日期TextBox.Text + "#) AND (收款事由 LIKE '%" + this.收款事由TextBox.Text + "%')";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      OleDbDataAdapter MyAdatper = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdatper.Fill(MyTable);
      this.收入统计报表DataGridView.DataSource = MyTable;
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
    }
    private void 打印Button_Click(object sender, EventArgs e)
    {//打印收入统计信息
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
          if (i == 1)
          {
            MyData[j, i] = DateTime.Parse(MyRow[i].ToString()).ToShortDateString();
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
      MyWorkSheet.Cells[2, 2] = this.MyCommunity + "收入统计表";
      Range MyRange22 = MyWorkSheet.get_Range("B2", "B2");
      MyRange22.Font.Bold = true;
      MyRange22.Font.Size = "20";
      MyWorkSheet.Cells[4, 1] = "打印日期：" + DateTime.Now.ToShortDateString();
    }
  }
}