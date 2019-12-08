//文件名：ComplainForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
  public partial class ComplainForm : Form
  {
    public ComplainForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    private void 服务投诉BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.服务投诉BindingSource.EndEdit();
      this.服务投诉TableAdapter.Update(this.dBCommunityDataSet.服务投诉);
    }
    private void ComplainForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
      this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息);
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.服务投诉”中
      this.服务投诉TableAdapter.Fill(this.dBCommunityDataSet.服务投诉);
    }
    private void 查询ToolStripButton_Click(object sender, EventArgs e)
    {
      this.服务投诉BindingSource.Filter = "投诉编号 LIKE '" + this.投诉编号ToolStripTextBox.Text + "'";
    }
    private void 打印ToolStripButton_Click(object sender, EventArgs e)
    {//打印服务投诉处理单
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.ShowDialog();
    }
    private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {//获取指定楼栋的业主姓名
      this.业主信息TableAdapter.Fill(this.dBCommunityDataSet.业主信息);
      this.业主信息BindingSource.Filter = "楼栋名称 = '" + 楼栋名称ComboBox.Text + "'";
    }
    private void 业主姓名ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
		try
		{
			//获取指定业主的编号
			if (this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
			{
				this.业主编号TextBox.Text = this.业主姓名ComboBox.SelectedValue.ToString();
			}
		}
		catch { }
    }
    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawString(this.MyCommunity + "服务投诉处理单", new Font("宋体", 20), Brushes.Black, 200, 90);
      e.Graphics.DrawString("投诉编号：" + this.服务投诉DataGridView.CurrentRow.Cells[0].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 145);
      e.Graphics.DrawString("打印日期：" + DateTime.Now.ToLongDateString(), new Font("宋体", 10), Brushes.Black, 550, 145);
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
      e.Graphics.DrawString("楼栋名称：" + this.服务投诉DataGridView.CurrentRow.Cells[1].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 175);
      e.Graphics.DrawString("业主编号：" + this.服务投诉DataGridView.CurrentRow.Cells[2].Value.ToString(), new Font("宋体", 10), Brushes.Black, 250, 175);
      e.Graphics.DrawString("业主姓名：" + this.服务投诉DataGridView.CurrentRow.Cells[3].Value.ToString(), new Font("宋体", 10), Brushes.Black, 450, 175);
      e.Graphics.DrawString("接待人员：" + this.服务投诉DataGridView.CurrentRow.Cells[5].Value.ToString(), new Font("宋体", 10), Brushes.Black, 580, 175);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
      e.Graphics.DrawString("投诉日期：" + DateTime.Parse(this.服务投诉DataGridView.CurrentRow.Cells[4].Value.ToString()).ToShortDateString(), new Font("宋体", 10), Brushes.Black, 100, 200);
      e.Graphics.DrawString("投诉主题：" + this.服务投诉DataGridView.CurrentRow.Cells[6].Value.ToString(), new Font("宋体", 10), Brushes.Black, 250, 200);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 220, 720, 220);
      e.Graphics.DrawString("投诉内容：", new Font("宋体", 10), Brushes.Black, 100, 225);
      e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[7].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 245, 620, 90));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 335, 720, 335);
      e.Graphics.DrawString("处理意见：", new Font("宋体", 10), Brushes.Black, 100, 340);
      e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[10].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 360, 620, 90));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 450, 720, 450);
      e.Graphics.DrawString("处理日期：" + DateTime.Parse(this.服务投诉DataGridView.CurrentRow.Cells[8].Value.ToString()).ToShortDateString(), new Font("宋体", 10), Brushes.Black, 100, 455);
      e.Graphics.DrawString("处理人员：" + this.服务投诉DataGridView.CurrentRow.Cells[9].Value.ToString(), new Font("宋体", 10), Brushes.Black, 450, 455);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 475, 720, 475);
      e.Graphics.DrawString("处理结果：", new Font("宋体", 10), Brushes.Black, 100, 480);
      e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[11].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 500, 620, 150));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 635, 720, 635);
      e.Graphics.DrawString("业主反馈：", new Font("宋体", 10), Brushes.Black, 100, 640);
      e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[12].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 660, 620, 200));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 845, 720, 845);
      e.Graphics.DrawString("补充说明：", new Font("宋体", 10), Brushes.Black, 100, 850);
      e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[13].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 870, 620, 125));
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 1000, 720, 1000);       
    }
    private void 业主编号TextBox_TextChanged(object sender, EventArgs e)
    {
        this.业主姓名ComboBox.SelectedValue = this.业主编号TextBox.Text;
    }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}