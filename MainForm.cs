//文件名：MainForm.cs
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
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }
    private string MyBgPhoto;
    private string MyAddress;
    private string MyTel;
    private string MyCode;
    private string MyWeb;
    private string MySlogan;
    private string MyBgPhotoShow;
    private string MyOperator = "";
    private string MyCommunity;
    private string MyIcon;
    private void MainForm_Load(object sender, EventArgs e)
    {
      try
      {
        //添加ThreadException事件关联程序
　　    Application.ThreadException += MyThreadException;
        //从小区信息数据表中读取基本信息
        this.GetCommunityInformation();
        //显示登录对话框
        LoginForm MyDlg = new LoginForm();
        MyDlg.Text = "欢迎使用" + MySlogan;
        MyDlg.ShowDialog(this);
        this.MyOperator = MyDlg.用户名称TextBox.Text;
        //根据用户的操作权限配置系统菜单
        SetUserOperateMenu();
        //最大化显示系统主窗体
        if (MyOperator.Length > 0)
        {
          this.WindowState = FormWindowState.Maximized;
        }
        //设置系统背景图像信息
        this.BackgroundImage = new Bitmap(this.MyBgPhotoShow, true);
        this.Icon = new Icon(this.MyIcon);
        //设置系统标题栏显示文字
        this.Text = MySlogan;
      }
      catch
      {
        this.Close();
      }
    }
    public void MyThreadException(Object sender, System.Threading.ThreadExceptionEventArgs e)
    {//系统异常处理代码
      string MyInfo = "错误名称：" + e.Exception.Source + "，错误信息：" + e.Exception.Message;
      MessageBox.Show(MyInfo, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    protected override void WndProc(ref Message SystemMessage)
    {//实现在系统关闭前给予用户提示        
      switch (SystemMessage.Msg)
      {
        case 0x0112:
          if (((int)SystemMessage.WParam) == 61536)
          {
            退出系统ToolStripMenuItem_Click(null, null);
          }
          else
          {
            base.WndProc(ref SystemMessage);
          }
          break;
        default:
          base.WndProc(ref SystemMessage);
          break;
      }
    }
    public void GetCommunityInformation()
    {//从小区信息数据表中读取基本信息
      //从app.config文件中读取数据库连接字符串信息
      String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
      string MySQL = "Select  *  From 小区信息 Where 优先级=1";
      OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
      MyConnection.Open();
      DataTable MyTable = new DataTable();
      OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);             
      MyAdapter.Fill(MyTable);
      MyBgPhoto = Application.StartupPath + "\\Data\\" + (String)MyTable.Rows[0]["背景图像"];
      MyAddress = (String)MyTable.Rows[0]["小区地址"];
      MyTel = (String)MyTable.Rows[0]["服务电话"];
      MyCode = (String)MyTable.Rows[0]["邮政编码"];
      MyWeb = (String)MyTable.Rows[0]["小区网站"];
      MySlogan = (String)MyTable.Rows[0]["系统名称"];
      MyCommunity = (String)MyTable.Rows[0]["小区名称"];
      if (MyConnection.State == ConnectionState.Open)
      {
        MyConnection.Close();
      }
      MyBgPhotoShow = Application.StartupPath + "\\Data\\Show" + (String)MyTable.Rows[0]["背景图像"];
      MyIcon = Application.StartupPath + "\\Data\\" + (String)MyTable.Rows[0]["标志图标"];
    }
    //根据用户的操作权限配置系统菜单
    public void SetUserOperateMenu()
    {
　    String MyConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
  　  string MySQL = "Select  *  From 操作用户 Where 用户名称='" + this.MyOperator + "'";
    　OleDbConnection MyConnection = new OleDbConnection(MyConnectionString);
    　MyConnection.Open();
    　DataTable MyTable = new DataTable();
    　OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySQL, MyConnection);
    　MyAdapter.Fill(MyTable);
    　if ((int)MyTable.Rows[0]["基本管理之业主登记管理"] == 0)
    　{
        this.业主登记管理ToolStripMenuItem.Visible = false;
        this.业主登记管理ToolStripSeparator.Visible = false;
        this.业主登记管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["基本管理之业主迁出管理"] == 0)
    　{
        this.业主迁出管理ToolStripMenuItem.Visible = false;
        this.业主迁出管理ToolStripSeparator.Visible = false;
        this.业主迁出管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["基本管理之楼栋信息管理"] == 0)
    　{
        this.楼栋信息管理ToolStripMenuItem.Visible = false;
        this.楼栋信息管理ToolStripSeparator.Visible = false;
        this.楼栋信息管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["基本管理之公共财产管理"] == 0)
    　{
        this.公共财产管理ToolStripMenuItem.Visible = false;
        this.公共财产管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["物业管理之服务投诉管理"] == 0)
    　{
        this.服务投诉管理ToolStripMenuItem.Visible = false;
        this.服务投诉管理ToolStripSeparator.Visible = false;
        this.服务投诉管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["物业管理之业主维修管理"] == 0)
    　{
        this.业主维修管理ToolStripMenuItem.Visible = false;
        this.业主维修管理ToolStripSeparator.Visible = false;
        this.业主维修管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["物业管理之公共维修管理"] == 0)
    　{
        this.公共维修管理ToolStripMenuItem.Visible = false;
        this.公共维修管理ToolStripSeparator.Visible = false;
        this.公共维修管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["物业管理之车位使用管理"] == 0)
    　{
        this.车位使用管理ToolStripMenuItem.Visible = false;
        this.车位使用管理ToolStripSeparator.Visible = false;
        this.车位使用管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["物业管理之突发事件管理"] == 0)
    　{
        this.突发事件管理ToolStripMenuItem.Visible = false;
        this.突发事件管理ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["费用管理之水电气费登记"] == 0)
    　{
        this.水电气费登记ToolStripMenuItem.Visible = false;
        this.水电气费登记ToolStripSeparator.Visible = false;
        this.水电气费登记ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["费用管理之水电气费查询"] == 0)
    　{
        this.水电气费查询ToolStripMenuItem.Visible = false;
        this.水电气费查询ToolStripSeparator.Visible = false;
        this.水电气费查询ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["费用管理之水电气费交纳"] == 0)
    　{
        this.水电气费交纳ToolStripMenuItem.Visible = false;
        this.水电气费交纳ToolStripSeparator.Visible = false;
        this.水电气费交纳ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["费用管理之物管费用登记"] == 0)
    　{
        this.物管费用登记ToolStripMenuItem.Visible = false;
        this.物管费用登记ToolStripSeparator.Visible = false;
        this.物管费用登记ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["费用管理之物管费用查询"] == 0)
    　{
        this.物管费用查询ToolStripMenuItem.Visible = false;
        this.物管费用查询ToolStripSeparator.Visible = false;
        this.物管费用查询ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["费用管理之物管费用交纳"] == 0)
    　{
        this.物管费用交纳ToolStripMenuItem.Visible = false;
        this.物管费用交纳ToolStripSeparator.Visible = false;
        this.物管费用交纳ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["费用管理之其他费用交纳"] == 0)
    　{
        this.其他费用交纳ToolStripMenuItem.Visible = false;
        this.其他费用交纳ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["报表管理之业主统计报表"] == 0)
    　{
        this.业主统计报表ToolStripMenuItem.Visible = false;
        this.业主统计报表ToolStripSeparator.Visible = false;
        this.业主统计报表ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["报表管理之投诉统计报表"] == 0)
    　{
        this.投诉统计报表ToolStripMenuItem.Visible = false;
        this.投诉统计报表ToolStripSeparator.Visible = false;
        this.投诉统计报表ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["报表管理之业主维修报表"] == 0)
    　{
        this.业主维修报表ToolStripMenuItem.Visible = false;
        this.业主维修报表ToolStripSeparator.Visible = false;
        this.业主维修报表ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["报表管理之公共维修报表"] == 0)
    　{
        this.公共维修报表ToolStripMenuItem.Visible = false;
        this.公共维修报表ToolStripSeparator.Visible = false;
        this.公共维修报表ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["报表管理之收入统计报表"] == 0)
    　{
        this.收入统计报表ToolStripMenuItem.Visible = false;
        this.收入统计报表ToolStripButton.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["系统管理之分配用户权限"] == 0)
    　{
        this.分配用户权限ToolStripMenuItem.Visible = false;
        this.分配用户权限ToolStripSeparator.Visible = false;
        this.分配用户权限ToolStripSeparator.Visible = false;
    　}
    　if ((int)MyTable.Rows[0]["系统管理之小区信息设置"] == 0)
    　{
        this.小区信息设置ToolStripMenuItem.Visible = false;
        this.小区信息设置ToolStripSeparator.Visible = false;
        this.小区信息设置ToolStripSeparator.Visible = false;
    　}
    　if (MyConnection.State == ConnectionState.Open)
    　{
        MyConnection.Close();
    　}
    }
    private void 系统帮助信息ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      VersionForm MyDlg = new VersionForm();
      MyDlg.label1.Text = this.MySlogan;
      MyDlg.ShowDialog();
    }
    private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("您确定现在退出本系统吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }
    private void 修改用户密码ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ChangeUserPasswordForm MyDlg = new ChangeUserPasswordForm();
      MyDlg.用户名称TextBox.Text = this.MyOperator;
      MyDlg.ShowDialog();
    }
    private void 小区信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CommunityForm MyDlg = new CommunityForm();
      MyDlg.ShowDialog();
      StringBuilder MyTempPath = new StringBuilder(this.MyBgPhotoShow);
      this.GetCommunityInformation();
      //生成系统背景图像
      if (!System.IO.File.Exists(MyBgPhotoShow))
      {
        Image MyImage = new Bitmap(MyBgPhoto, true);
        int PosX = 10;
        int PosY = MyImage.Height / 2 + 70;
        int MyFont = 150;
        bool bMyFound = false;
        int MyWidth = MyImage.Width;
        int MyHeight = MyImage.Height;
        int MySize = MyWidth * MyHeight;
        Bitmap MyPattern = new Bitmap(MyWidth, MyHeight);
        Bitmap MyBitmap = new Bitmap(MyImage);
        Graphics g = Graphics.FromImage(MyPattern);
        Graphics MyGraphics = Graphics.FromImage(MyImage);
        g.Clear(Color.White);
        while (bMyFound == false)
        {
          Font NewFont = new Font("宋体", MyFont, FontStyle.Bold);
          SizeF MyString = new SizeF(MyWidth, MyHeight);
          MyString = g.MeasureString(MySlogan, NewFont);
          if (MyString.Width < MyPattern.Width)
          {
            if (MyString.Height < MyPattern.Height)
            {
              bMyFound = true;
              g.DrawString(MySlogan, NewFont, new SolidBrush(Color.Black), PosX, PosY);
            }
          }
          else
            MyFont = MyFont - 1;
        }
        for (int x = 1; x < MyPattern.Width; x++)
        {
          for (int y = 1; y < MyPattern.Height; y++)
          {
            int a, re, gr, bl, x1, y1, z1;
            if (MyPattern.GetPixel(x, y).ToArgb() == Color.Black.ToArgb())
            {
              a = MyBitmap.GetPixel(x, y).A;
              re = MyBitmap.GetPixel(x, y).R;
              gr = MyBitmap.GetPixel(x, y).G;
              bl = MyBitmap.GetPixel(x, y).B;
              x1 = re;
              y1 = gr;
              z1 = bl;
              if (bl + 25 < 255)
                bl = bl + 25;
              if (gr + 25 < 255)
                gr = gr + 25;
              if (re + 25 < 255)
                re = re + 25;
              if (x1 - 25 > 0)
                x1 = x1 - 25;
              if (y1 - 25 > 0)
                y1 = y1 - 25;
              if (z1 - 25 > 0)
                z1 = z1 - 25;
              MyGraphics.DrawEllipse(new Pen(new SolidBrush(Color.Cyan)), x, y + 1, 3, 3);
              MyGraphics.DrawEllipse(new Pen(new SolidBrush(Color.FromArgb(a, x1, y1, z1))), x, y, 1, 1);
            }
          }
        }
        MyGraphics.DrawString("公司地址：" + MyAddress, new Font("宋体", 10, FontStyle.Regular), new SolidBrush(Color.White), 5, 10);
        MyGraphics.DrawString("服务电话：" + MyTel, new Font("宋体", 10, FontStyle.Regular), new SolidBrush(Color.White), 5, 30);
        MyGraphics.DrawString("公司网站：" + MyWeb, new Font("宋体", 10, FontStyle.Regular), new SolidBrush(Color.White), 5, 50);
        MyImage.Save(MyBgPhotoShow, System.Drawing.Imaging.ImageFormat.Jpeg);
      }
      this.BackgroundImage = new Bitmap(this.MyBgPhotoShow, true);
      this.Text = MySlogan;
      this.Icon = new Icon(this.MyIcon);
    }
    private void 分配用户权限ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OperatorForm MyDlg = new OperatorForm();
      MyDlg.ShowDialog();
    }
    private void 业主登记管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OwnerForm MyDlg = new OwnerForm();
      MyDlg.ShowDialog();
    }
    private void 业主迁出管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MoveForm MyDlg = new MoveForm();
      MyDlg.ShowDialog();
    }
    private void 楼栋信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      BuildingForm MyDlg = new BuildingForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 公共财产管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CommonPropertyForm MyDlg = new CommonPropertyForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 服务投诉管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ComplainForm MyDlg = new ComplainForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 业主维修管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OwnerRepairForm MyDlg = new OwnerRepairForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 公共维修管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CommonRepairForm MyDlg = new CommonRepairForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 车位使用管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      StationForm MyDlg = new StationForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 突发事件管理ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      EventForm MyDlg = new EventForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 水电气费登记ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      GasRegisterForm MyDlg = new GasRegisterForm();
      MyDlg.ShowDialog();
    }
    private void 水电气费查询ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      GasQueryForm MyDlg = new GasQueryForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 水电气费交纳ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      GasPaymentForm MyDlg = new GasPaymentForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.MyOperator = this.MyOperator;
      MyDlg.ShowDialog();
    }
    private void 物管费用登记ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ManageRegisterForm MyDlg = new ManageRegisterForm();
      MyDlg.ShowDialog();
    }
    private void 物管费用查询ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ManageQueryForm MyDlg = new ManageQueryForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 物管费用交纳ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ManagePaymentForm MyDlg = new ManagePaymentForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.MyOperator = this.MyOperator;
      MyDlg.ShowDialog();
    }
    private void 其他费用交纳ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OtherPaymentForm MyDlg = new OtherPaymentForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.MyOperator = this.MyOperator;
      MyDlg.ShowDialog();
    }
    private void 业主统计报表ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ReportOwnerForm MyDlg = new ReportOwnerForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 投诉统计报表ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ReportComplainForm MyDlg = new ReportComplainForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 业主维修报表ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ReportOwnerRepairForm MyDlg = new ReportOwnerRepairForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 公共维修报表ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ReportCommonRepairForm MyDlg = new ReportCommonRepairForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }
    private void 收入统计报表ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ReportChargeForm MyDlg = new ReportChargeForm();
      MyDlg.MyCommunity = this.MyCommunity;
      MyDlg.ShowDialog();
    }    
  }
}