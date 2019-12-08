//文件名：OtherPaymentForm.cs
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
  public partial class OtherPaymentForm : Form
  {
    public OtherPaymentForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    public string MyOperator;
    private void 新增Button_Click(object sender, EventArgs e)
    {//新增其他费用信息
      this.收据编号TextBox.Text = System.Guid.NewGuid().ToString().ToUpper();
      this.收款日期TextBox.Text = DateTime.Now.ToShortDateString();
      this.收款人员TextBox.Text = this.MyOperator; 
    }
    private void 打印Button_Click(object sender, EventArgs e)
    {//打印其他费用交款收据
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.ShowDialog();
    }
    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawString(this.MyCommunity + "物业管理服务收费收据", new Font("宋体", 20), Brushes.Black, 150, 90);
      e.Graphics.DrawString("收据编号：" + this.收据编号TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 145);
      e.Graphics.DrawString("收款日期：" + this.收款日期TextBox.Text, new Font("宋体", 10), Brushes.Black, 550, 145);
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
      e.Graphics.DrawString("交款人员：" + this.交款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 175);
      e.Graphics.DrawString("收款金额：" + this.收款金额TextBox.Text + "元", new Font("宋体", 10), Brushes.Black, 300, 175);
      e.Graphics.DrawString("收款形式：" + this.收款形式TextBox.Text, new Font("宋体", 10), Brushes.Black, 500, 175);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
      e.Graphics.DrawString("收款事由：", new Font("宋体", 10), Brushes.Black, 100, 200);
      e.Graphics.DrawString(this.收款事由TextBox.Text, new Font("宋体", 10), Brushes.Black, new RectangleF(110, 220, 620, 110));
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 335, 720, 335);
      e.Graphics.DrawString("补充说明：" + this.补充说明TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 340);
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 360, 720, 360);
      e.Graphics.DrawString("收款人员：" + this.收款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 365);            
    }
    private void 保存Button_Click(object sender, EventArgs e)
    {//保存其他收费信息
      if (this.收据编号TextBox.Text.Length < 1 || this.交款人员TextBox.Text.Length < 1 || this.收款人员TextBox.Text.Length < 1|| this.收款日期TextBox.Text.Length < 1 || this.收款形式TextBox.Text.Length < 1 || Convert.ToDouble(this.收款金额TextBox.Text)<1)
      {
        return;
      }
      string MySaveInfo = "现在将保存业主交纳的物业管理服务收费信息，是否继续？";
      if (MessageBox.Show(MySaveInfo, "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        return;
      }
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      OleDbCommand MyCommand = MyConnection.CreateCommand();
      string MySQL = "INSERT INTO 费用收据(收据编号,收款日期,交款人员,收款金额,收款形式,收款人员,收款事由,补充说明) VALUES('";
      MySQL += this.收据编号TextBox.Text + "','";
      MySQL += this.收款日期TextBox.Text + "','";
      MySQL += this.交款人员TextBox.Text + "',";
      MySQL += this.收款金额TextBox.Text + ",'";
      MySQL += this.收款形式TextBox.Text + "','";
      MySQL += this.收款人员TextBox.Text + "','";
      MySQL += this.收款事由TextBox.Text + "','";
      MySQL += this.补充说明TextBox.Text + "');";
      MyCommand.CommandText = MySQL;
      MyCommand.ExecuteNonQuery();
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
      this.收据编号TextBox.Text = "";
      this.收款日期TextBox.Text = "";
      this.交款人员TextBox.Text = "";
      this.收款金额TextBox.Text = "";
      this.收款形式TextBox.Text = "";
      this.收款人员TextBox.Text = "";
    } 
  }
}