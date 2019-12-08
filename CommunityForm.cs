//文件名：CommunityForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
  public partial class CommunityForm : Form
  {
    public CommunityForm()
    {
      InitializeComponent();
    }
    private void 小区信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.小区信息BindingSource.EndEdit();
      this.小区信息TableAdapter.Update(this.dBCommunityDataSet.小区信息);
    }
    private void CommunityForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.小区信息”中
      this.小区信息TableAdapter.Fill(this.dBCommunityDataSet.小区信息);
    }
    private void 浏览图像Button_Click(object sender, EventArgs e)
    {
      OpenFileDialog MyDlg = new OpenFileDialog();
      MyDlg.Title = "选择图像";
      MyDlg.Filter = "JPEG图像文件(*.jpg)|*.jpg|所有图像文件(JPeg, Gif, Bmp, etc.)|*.jpg;*.jpeg; *.gif;*.bmp;*.tif; *.tiff; *.png|所有文件(*.*)|*.*";
      if (MyDlg.ShowDialog() == DialogResult.OK)
      {
        this.背景图像TextBox.Text = System.IO.Path.GetFileName(MyDlg.FileName);
        string MySrcPath = MyDlg.FileName;
        string MyDestPath = Application.StartupPath + "\\Data\\" + this.背景图像TextBox.Text;
        System.IO.File.Copy(MySrcPath, MyDestPath);
      }   
    }
    private void 浏览图标Button_Click(object sender, EventArgs e)
    {
      OpenFileDialog MyDlg = new OpenFileDialog();
      MyDlg.Title = "选择图标";
      MyDlg.Filter = "图标文件(*.ico)|*.ico|所有图像文件(JPeg, Gif, Bmp, etc.)|*.jpg;*.jpeg; *.gif;*.bmp;*.tif; *.tiff; *.png| JPeg图像文件(*.jpg;*.jpeg) |*.jpg;*.jpeg |BMP图像文件(*.bmp)|*.bmp|Tiff图像文件(*.tif;*.tiff)| *.tif;*.tiff|Png图像文件(*.png)| *.png |所有文件(*.*)|*.*";
      if (MyDlg.ShowDialog() == DialogResult.OK)
      {
        this.标志图标TextBox.Text = System.IO.Path.GetFileName(MyDlg.FileName);
        string MySrcPath = MyDlg.FileName;
        string MyDestPath = Application.StartupPath + "\\Data\\" + this.标志图标TextBox.Text;
        System.IO.File.Copy(MySrcPath, MyDestPath);
      }   
    }
  }
}