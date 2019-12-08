//文件名：OwnerForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
  public partial class OwnerForm : Form
  {
    public OwnerForm()
    {
      InitializeComponent();
    }
    private void 业主信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.业主信息BindingSource.EndEdit();
      this.业主信息TableAdapter.Update(this.dBCommunityDataSet.业主信息);
    }
    private void OwnerForm_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
      this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息);
      // TODO: 这行代码将数据加载到表“dBCommunityDataSet.业主信息”中
      this.业主信息TableAdapter.Fill(this.dBCommunityDataSet.业主信息);
    }
    private void 查询ToolStripButton_Click(object sender, EventArgs e)
    {
      this.业主信息BindingSource.Filter = "业主编号 LIKE '" + this.业主编号ToolStripTextBox.Text + "'";
    }
  }
}