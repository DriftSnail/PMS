//文件名：CommonPropertyForm.cs
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
namespace MyCommunity
{
  public partial class CommonPropertyForm : Form
  {
    public CommonPropertyForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    private void 公共财产BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.公共财产BindingSource.EndEdit();
      this.公共财产TableAdapter.Update(this.dBCommunityDataSet.公共财产);
    }
    private void CommonPropertyForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.公共财产”中
      this.公共财产TableAdapter.Fill(this.dBCommunityDataSet.公共财产);
    }
    private void 打印ToolStripButton_Click(object sender, EventArgs e)
    {//打印公共财产信息
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
      MyColumns = (char)(this.dBCommunityDataSet.公共财产.Columns.Count + 64);
      MyRange = MyWorkSheet.get_Range("A5", MyColumns.ToString() + "5");
      int Count = 0;
      foreach (DataColumn MyNewColumn in this.dBCommunityDataSet.公共财产.Columns)
      {
        MyData[0, Count] = MyNewColumn.ColumnName;
        Count = Count + 1;
      }
      j = 1;
      //输出数据库记录
      foreach (DataRow MyRow in this.dBCommunityDataSet.公共财产.Rows)
      {
        for (i = 0; i < this.dBCommunityDataSet.公共财产.Columns.Count; i++)
        {
          if (i == 5)
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
      MyRange = MyRange.get_Resize(this.dBCommunityDataSet.公共财产.Rows.Count + 1, this.dBCommunityDataSet.公共财产.Columns.Count);
      MyRange.Value2 = MyData;
      MyRange.EntireColumn.AutoFit();
      MyWorkSheet.Cells[2, 2] = this.MyCommunity + "公共财产信息表";
      Range MyRange22 = MyWorkSheet.get_Range("B2", "B2");
      MyRange22.Font.Bold = true;
      MyRange22.Font.Size = "20";
      MyWorkSheet.Cells[4, 1] = "打印日期：" + DateTime.Now.ToShortDateString();
    }
  }
}