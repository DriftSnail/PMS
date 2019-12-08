//文件名：CommonRepairForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
  public partial class CommonRepairForm : Form
  {
    public CommonRepairForm()
    {
        InitializeComponent();
    }
    public string MyCommunity;
    private void 公共维修BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
     if (Convert.ToDouble(this.修理费用TextBox.Text) + Convert.ToDouble(this.材料费用TextBox.Text) != Convert.ToDouble(this.费用合计TextBox.Text))
     {
       MessageBox.Show("修理费用、材料费用或费用合计金额有误，请仔细检查后再保存！", "信息提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
       return;
     }
     this.Validate();
     this.公共维修BindingSource.EndEdit();
     this.公共维修TableAdapter.Update(this.dBCommunityDataSet.公共维修);
    }
    private void CommonRepairForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.公共财产”中
      this.公共财产TableAdapter.FillByUsing(this.dBCommunityDataSet.公共财产); 
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.公共维修”中
      this.公共维修TableAdapter.Fill(this.dBCommunityDataSet.公共维修);
    }
    private void 查询ToolStripButton_Click(object sender, EventArgs e)
    {
      this.公共维修BindingSource.Filter = "维修编号 LIKE '" +this.维修编号ToolStripTextBox.Text +"'";
    }
    private void 财产名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.财产名称ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
      {
        this.财产编号TextBox.Text = this.财产名称ComboBox.SelectedValue.ToString();
      }
    }
    private void 打印ToolStripButton_Click(object sender, EventArgs e)
    {//打印公共财产维修单
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.ShowDialog();
    }
    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawString(this.MyCommunity + "公共财产维修单", new Font("宋体", 20), Brushes.Black, 200, 90);
      e.Graphics.DrawString("维修编号：" + this.公共维修DataGridView.CurrentRow.Cells[0].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 145);
      e.Graphics.DrawString("打印日期：" + DateTime.Now.ToLongDateString(), new Font("宋体", 10), Brushes.Black, 550, 145);
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
      e.Graphics.DrawString("财产编号：" + this.公共维修DataGridView.CurrentRow.Cells[1].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 175);
      e.Graphics.DrawString("财产名称：" + this.公共维修DataGridView.CurrentRow.Cells[2].Value.ToString(), new Font("宋体", 10), Brushes.Black, 300, 175);
      e.Graphics.DrawString("报修日期：" + DateTime.Parse(this.公共维修DataGridView.CurrentRow.Cells[3].Value.ToString()).ToShortDateString(), new Font("宋体", 10), Brushes.Black, 550, 175);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
      e.Graphics.DrawString("报修人员：" + this.公共维修DataGridView.CurrentRow.Cells[4].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 200);
      e.Graphics.DrawString("受理人员：" + this.公共维修DataGridView.CurrentRow.Cells[6].Value.ToString(), new Font("宋体", 10), Brushes.Black, 300, 200);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 220, 720, 220);
      e.Graphics.DrawString("故障现象：", new Font("宋体", 10), Brushes.Black, 100, 225);
      e.Graphics.DrawString(this.公共维修DataGridView.CurrentRow.Cells[5].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 245, 620, 90));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 335, 720, 335);
      e.Graphics.DrawString("处理意见：", new Font("宋体", 10), Brushes.Black, 100, 340);
      e.Graphics.DrawString(this.公共维修DataGridView.CurrentRow.Cells[7].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 360, 620, 90));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 450, 720, 450);
      e.Graphics.DrawString("修理日期：" + DateTime.Parse(this.公共维修DataGridView.CurrentRow.Cells[8].Value.ToString()).ToShortDateString(), new Font("宋体", 10), Brushes.Black, 100, 455);
      e.Graphics.DrawString("修理人员：" + this.公共维修DataGridView.CurrentRow.Cells[9].Value.ToString(), new Font("宋体", 10), Brushes.Black, 250, 455);
      e.Graphics.DrawString("修理费用：" + this.公共维修DataGridView.CurrentRow.Cells[10].Value.ToString() + "元", new Font("宋体", 10), Brushes.Black, 370, 455);
      e.Graphics.DrawString("材料费用：" + this.公共维修DataGridView.CurrentRow.Cells[11].Value.ToString() + "元", new Font("宋体", 10), Brushes.Black, 480, 455);
      double My费用合计 = Convert.ToDouble(this.公共维修DataGridView.CurrentRow.Cells[10].Value.ToString()) + Convert.ToDouble(this.公共维修DataGridView.CurrentRow.Cells[11].Value.ToString());
      e.Graphics.DrawString("费用合计：" + My费用合计.ToString() + "元", new Font("宋体", 10), Brushes.Black, 590, 455);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 475, 720, 475);
      e.Graphics.DrawString("修理结果：", new Font("宋体", 10), Brushes.Black, 100, 480);
      e.Graphics.DrawString(this.公共维修DataGridView.CurrentRow.Cells[12].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 500, 620, 240));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 765, 720, 765);
      e.Graphics.DrawString("补充说明：", new Font("宋体", 10), Brushes.Black, 100, 770);
      e.Graphics.DrawString(this.公共维修DataGridView.CurrentRow.Cells[13].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 790, 620, 205));
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 1000, 720, 1000);            
    }
  }
}