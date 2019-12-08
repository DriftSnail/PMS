//文件名：StationForm.cs
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
  public partial class StationForm : Form
  {
    public StationForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    private void 车位使用BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.车位使用BindingSource.EndEdit();
      this.车位使用TableAdapter.Update(this.dBCommunityDataSet.车位使用);
    }
    private void StationForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.业主信息”中
      this.业主信息TableAdapter.Fill(this.dBCommunityDataSet.业主信息);
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
      this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息);
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.车位使用”中
      this.车位使用TableAdapter.Fill(this.dBCommunityDataSet.车位使用);
    }
    private void 查询ToolStripButton_Click(object sender, EventArgs e)
    {
      this.车位使用BindingSource.Filter="车位编号 LIKE '"+this.车位编号ToolStripTextBox.Text+"'";
    }
    private void 打印ToolStripButton_Click(object sender, EventArgs e)
    {//打印车位使用信息
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
      MyColumns = (char)(this.dBCommunityDataSet.车位使用.Columns.Count + 64);
      MyRange = MyWorkSheet.get_Range("A5", MyColumns.ToString() + "5");
      int Count = 0;
      foreach (DataColumn MyNewColumn in this.dBCommunityDataSet.车位使用.Columns)
      {
         MyData[0, Count] = MyNewColumn.ColumnName;
         Count = Count + 1;
      }
      j = 1;
      //输出数据库记录
      foreach (DataGridViewRow MyRow in this.车位使用DataGridView.Rows)
      {
        for (i = 0; i < this.dBCommunityDataSet.车位使用.Columns.Count; i++)
        {
          if (i == 6 | i == 7)
          {
            MyData[j, i] = DateTime.Parse(MyRow.Cells[i].Value.ToString()).ToShortDateString();
          }
          else
          {
            MyData[j, i] = MyRow.Cells[i].Value.ToString();
          }
        }
        j++;
      }
      MyRange = MyRange.get_Resize(this.dBCommunityDataSet.车位使用.Rows.Count + 1, this.dBCommunityDataSet.车位使用.Columns.Count);
      MyRange.Value2 = MyData;
      MyRange.EntireColumn.AutoFit();
      MyWorkSheet.Cells[2, 2] = this.MyCommunity + "车位信息表";
      Range MyRange22 = MyWorkSheet.get_Range("B2", "B2");
      MyRange22.Font.Bold = true;
      MyRange22.Font.Size = "20";
      MyWorkSheet.Cells[4, 1] = "打印日期：" + DateTime.Now.ToShortDateString();
    }
    private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {//获取指定楼栋的业主姓名
      this.业主信息BindingSource.Filter = "楼栋名称 LIKE '" + this.楼栋名称ComboBox.Text+ "'";       
    }
    private void 业主姓名ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {//获取指定业主的编号
      if (this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
      {
       this.业主编号TextBox.Text = this.业主姓名ComboBox.SelectedValue.ToString();
      }
    }
  }
}