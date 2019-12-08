//文件名：EventForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
  public partial class EventForm : Form
  {
    public EventForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    private void 突发事件BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.突发事件BindingSource.EndEdit();
      this.突发事件TableAdapter.Update(this.dBCommunityDataSet.突发事件);
    }
    private void EventForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.突发事件”中
      this.突发事件TableAdapter.Fill(this.dBCommunityDataSet.突发事件);
    }
    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawString(this.MyCommunity + "突发事件信息表", new Font("宋体", 20), Brushes.Black, 200, 90);
      e.Graphics.DrawString("事件编号：" + this.突发事件DataGridView.CurrentRow.Cells[0].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 145);
      e.Graphics.DrawString("打印日期：" + DateTime.Now.ToLongDateString(), new Font("宋体", 10), Brushes.Black, 550, 145);
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
      e.Graphics.DrawString("发生日期：" + DateTime.Parse(this.突发事件DataGridView.CurrentRow.Cells[1].Value.ToString()).ToShortDateString(), new Font("宋体", 10), Brushes.Black, 100, 175);
      e.Graphics.DrawString("处理人员：" + this.突发事件DataGridView.CurrentRow.Cells[2].Value.ToString(), new Font("宋体", 10), Brushes.Black, 450, 175);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
      e.Graphics.DrawString("事件主题：" + this.突发事件DataGridView.CurrentRow.Cells[3].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 200);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 220, 720, 220);
      e.Graphics.DrawString("事件内容：", new Font("宋体", 10), Brushes.Black, 100, 225);
      e.Graphics.DrawString(this.突发事件DataGridView.CurrentRow.Cells[4].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 245, 620, 230));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 475, 720, 475);
      e.Graphics.DrawString("处理结果：", new Font("宋体", 10), Brushes.Black, 100, 480);
      e.Graphics.DrawString(this.突发事件DataGridView.CurrentRow.Cells[5].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 500, 620, 340));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 845, 720, 845);
      e.Graphics.DrawString("补充说明：", new Font("宋体", 10), Brushes.Black, 100, 850);
      e.Graphics.DrawString(this.突发事件DataGridView.CurrentRow.Cells[6].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 870, 620, 125));
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 1000, 720, 1000);       
    }
    private void 查询ToolStripButton_Click(object sender, EventArgs e)
    {
      this.突发事件BindingSource.Filter = "事件编号 LIKE '" + this.事件编号ToolStripTextBox.Text + "'"; 
    }
    private void 打印ToolStripButton_Click(object sender, EventArgs e)
    {//打印突发事件信息单
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.ShowDialog();
    }
  }
}