//文件名：BuildingForm.cs
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
 public partial class BuildingForm : Form
 {
    public BuildingForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    private void 楼栋信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      if ((Convert.ToDouble(this.总户数TextBox.Text) - Convert.ToDouble(this.入住户数TextBox.Text) != Convert.ToDouble(this.空置户数TextBox.Text)) || (Convert.ToDouble(this.总户数TextBox.Text) - Convert.ToDouble(this.住宅户数TextBox.Text) != Convert.ToDouble(this.商用户数TextBox.Text)))
      {
        MessageBox.Show("总户数、入住户数、空置户数、住宅户数、商用户数其中之一有错！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      this.Validate();
      this.楼栋信息BindingSource.EndEdit();
      this.楼栋信息TableAdapter.Update(this.dBCommunityDataSet.楼栋信息);
    }
    private void BuildingForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
      this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息);
    }
    private void 打印ToolStripButton_Click(object sender, EventArgs e)
    {//打印楼栋信息
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
      MyColumns = (char)(this.dBCommunityDataSet.楼栋信息.Columns.Count + 64);
      MyRange = MyWorkSheet.get_Range("A5", MyColumns.ToString() + "5");
      int Count = 0;
      foreach (DataColumn MyNewColumn in this.dBCommunityDataSet.楼栋信息.Columns)
      {
        MyData[0, Count] = MyNewColumn.ColumnName;
        Count = Count + 1;
      }
      j = 1;
      //输出数据库记录
      foreach (DataRow MyRow in this.dBCommunityDataSet.楼栋信息.Rows)
      {
       for (i = 0; i < this.dBCommunityDataSet.楼栋信息.Columns.Count; i++)
       {
         MyData[j, i] = MyRow[i].ToString();
       }
       j++;
      }
      MyRange = MyRange.get_Resize(this.dBCommunityDataSet.楼栋信息.Rows.Count + 1, this.dBCommunityDataSet.楼栋信息.Columns.Count);
      MyRange.Value2 = MyData;
      MyRange.EntireColumn.AutoFit();
      MyWorkSheet.Cells[2, 2] = this.MyCommunity + "楼栋信息表";
      Range MyRange22 = MyWorkSheet.get_Range("B2", "B2");
      MyRange22.Font.Bold = true;
      MyRange22.Font.Size = "20";
      MyWorkSheet.Cells[4, 1] = "打印日期：" + DateTime.Now.ToShortDateString();
    }
  }
}