//文件名：ManagePaymentForm.cs
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
  public partial class ManagePaymentForm : Form
  {
    public ManagePaymentForm()
    {
      InitializeComponent();
    }
    public string MyCommunity;
    public string MyOperator;
    private DataTable MyManageTable = new DataTable("物管费用明细表");
    private void ManagePaymentForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
      this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息);
      //创建无连接的数据表
      DataColumn[] MyKey = new DataColumn[1];
      DataColumn MyColumn = new DataColumn();
      MyColumn.DataType = System.Type.GetType("System.Int16");
      MyColumn.ColumnName = "序号";
      MyManageTable.Columns.Add(MyColumn);
      MyKey[0] = MyColumn;
      MyManageTable.PrimaryKey = MyKey;
      MyManageTable.Columns.Add("年份", System.Type.GetType("System.Int16"));
      MyManageTable.Columns.Add("月份", System.Type.GetType("System.Int16"));
      MyManageTable.Columns.Add("建面", System.Type.GetType("System.Double"));
      MyManageTable.Columns.Add("套面", System.Type.GetType("System.Double"));
      MyManageTable.Columns.Add("单价", System.Type.GetType("System.Double"));
      this.明细DataGridView.DataSource = MyManageTable;
    }
    private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {//获取指定楼栋的业主信息
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string My楼栋名称 = this.楼栋名称ComboBox.Text;
      string MySQL = "SELECT * FROM [业主信息] WHERE ([楼栋名称] = '" + My楼栋名称 + "')";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      DataTable ItemTable = new DataTable();
      OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdapter.Fill(ItemTable);
      this.业主姓名ComboBox.DataSource = ItemTable;
      this.业主姓名ComboBox.DisplayMember = "业主姓名";
      this.业主姓名ComboBox.ValueMember = "业主编号";
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
    }
    private void 查询Button_Click(object sender, EventArgs e)
    {//查询业主未交费信息
      string My业主编号 = "";
      if (this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
      {
        My业主编号 = this.业主姓名ComboBox.SelectedValue.ToString();
      }
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "SELECT [自动编号], [计费年份], [计费月份], [建筑面积], [套内面积], [计费单价] FROM [物管费用] WHERE ([业主编号] ='" + My业主编号 + "') AND (费用状态='未交费')";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      DataTable MyTable = new DataTable();
      OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);
      MyAdapter.Fill(MyTable);
      this.未交DataGridView.DataSource = MyTable;
      this.交款人员TextBox.Text = this.业主姓名ComboBox.Text;
    }
    private void 新增Button_Click(object sender, EventArgs e)
    {//新增收据信息
      this.收据编号TextBox.Text = System.Guid.NewGuid().ToString().ToUpper();
      this.收款日期TextBox.Text = DateTime.Now.ToShortDateString();
      this.收款人员TextBox.Text = this.MyOperator;
      this.收款金额TextBox.Text = "0";
      MyManageTable.Rows.Clear();
    }
    private void 添加Button_Click(object sender, EventArgs e)
    {//添加交款明细项目
      if ((this.收据编号TextBox.Text.Length > 1) && (this.交款人员TextBox.Text.Length > 1))
      {
        DataRow MyRow = MyManageTable.NewRow();
        MyRow[0] = Convert.ToInt16(this.未交DataGridView.CurrentRow.Cells[0].Value.ToString());
        MyRow["年份"] = Convert.ToInt16(this.未交DataGridView.CurrentRow.Cells[1].Value.ToString());
        MyRow["月份"] = Convert.ToInt16(this.未交DataGridView.CurrentRow.Cells[2].Value.ToString());
        MyRow["建面"] = this.未交DataGridView.CurrentRow.Cells[3].Value.ToString();
        MyRow["套面"] = this.未交DataGridView.CurrentRow.Cells[4].Value.ToString();
        MyRow["单价"] = Convert.ToDouble(this.未交DataGridView.CurrentRow.Cells[5].Value.ToString());           
        MyManageTable.Rows.Add(MyRow);
        double MyAmount = Convert.ToDouble(this.收款金额TextBox.Text);
        MyAmount += Convert.ToDouble(this.未交DataGridView.CurrentRow.Cells[3].Value.ToString()) * Convert.ToDouble(this.未交DataGridView.CurrentRow.Cells[5].Value.ToString());
        this.收款金额TextBox.Text = MyAmount.ToString();
      }
    }
    private void 移除Button_Click(object sender, EventArgs e)
    {//移除交款明细项目
      try
      {
        double MyAmount = Convert.ToDouble(this.收款金额TextBox.Text);
        MyAmount -= Convert.ToDouble(this.未交DataGridView.CurrentRow.Cells[3].Value.ToString()) * Convert.ToDouble(this.未交DataGridView.CurrentRow.Cells[5].Value.ToString());
        this.收款金额TextBox.Text = MyAmount.ToString();
        MyManageTable.Rows.RemoveAt(this.明细DataGridView.CurrentRow.Index);
      }
      catch
      {
      }
    }
    private void 打印Button_Click(object sender, EventArgs e)
    {//打印物管费用交款收据
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.ShowDialog();
    }
    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawString(this.MyCommunity + "物业管理费交款收据", new Font("宋体", 20), Brushes.Black, 160, 90);
      e.Graphics.DrawString("收据编号：" + this.收据编号TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 145);
      e.Graphics.DrawString("收款日期：" + this.收款日期TextBox.Text, new Font("宋体", 10), Brushes.Black, 550, 145);
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
      e.Graphics.DrawString("交款人员：" + this.交款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 175);
      e.Graphics.DrawString("收款金额：" + this.收款金额TextBox.Text + "元", new Font("宋体", 10), Brushes.Black, 230, 175);
      e.Graphics.DrawString("收款形式：" + this.收款形式TextBox.Text, new Font("宋体", 10), Brushes.Black, 380, 175);
      e.Graphics.DrawString("收款事由：" + this.收款事由TextBox.Text, new Font("宋体", 10), Brushes.Black, 500, 175);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
      e.Graphics.DrawString("补充说明：" + this.补充说明TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 200);
      e.Graphics.DrawLine(new Pen(Color.Black), 100, 220, 720, 220);
      e.Graphics.DrawString("序号", new Font("宋体", 10), Brushes.Black, 150, 225);
      e.Graphics.DrawString("年份", new Font("宋体", 10), Brushes.Black, 200, 225);
      e.Graphics.DrawString("月份", new Font("宋体", 10), Brushes.Black, 280, 225);
      e.Graphics.DrawString("建面(m2)", new Font("宋体", 10), Brushes.Black, 330, 225);
      e.Graphics.DrawString("套面(m2)", new Font("宋体", 10), Brushes.Black, 430, 225);
      e.Graphics.DrawString("单价(元)", new Font("宋体", 10), Brushes.Black, 530, 225);
      e.Graphics.DrawString("金额(元)", new Font("宋体", 10), Brushes.Black, 630, 225);
      int MyPosY = 245;
      int MyID = 1;
      foreach (DataRow MyRow in this.MyManageTable.Rows)
      {
        e.Graphics.DrawString(MyID.ToString(), new Font("宋体", 10), Brushes.Black, 150, MyPosY);
        e.Graphics.DrawString(MyRow[1].ToString(), new Font("宋体", 10), Brushes.Black, 200, MyPosY);
        e.Graphics.DrawString(MyRow[2].ToString(), new Font("宋体", 10), Brushes.Black, 280, MyPosY);
        e.Graphics.DrawString(MyRow[3].ToString(), new Font("宋体", 10), Brushes.Black, 330, MyPosY);
        e.Graphics.DrawString(MyRow[4].ToString(), new Font("宋体", 10), Brushes.Black, 430, MyPosY);
        e.Graphics.DrawString(MyRow[5].ToString(), new Font("宋体", 10), Brushes.Black, 530, MyPosY);
        double My金额 = Convert.ToDouble(MyRow[3].ToString()) * Convert.ToDouble(MyRow[5].ToString());
        e.Graphics.DrawString(My金额.ToString(), new Font("宋体", 10), Brushes.Black, 630, MyPosY);
        MyPosY += 20;
        MyID += 1;
      }
      e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 400, 720, 400);
      e.Graphics.DrawString("收款人员：" + this.收款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 410);            
    }
    private void 保存Button_Click(object sender, EventArgs e)
    {//保存物管费用交款信息
      string MySaveInfo = "现在将保存业主交纳的物业管理费数据，是否继续？";
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
      foreach (DataRow MyRow in MyManageTable.Rows)
      {
        string My原编号 = MyRow[0].ToString();
        string My收据编号 = this.收据编号TextBox.Text;
        MySQL = "UPDATE 物管费用 SET 费用状态='已交费',收据编号='" + My收据编号 + "' WHERE 自动编号=" + My原编号;
        MyCommand.CommandText = MySQL;
        MyCommand.ExecuteNonQuery();
      }
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
      查询Button_Click(null, null);
      MyManageTable.Rows.Clear();
    }
  }
}