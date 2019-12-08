namespace MyCommunity
{
    partial class GasRegisterForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasRegisterForm));
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.水电气费BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.水电气费TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.水电气费TableAdapter();
            this.水电气费BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.水电气费BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.楼栋名称ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.楼栋名称ToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.计费年份ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.计费年份ToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.计费月份ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.计费月份ToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.费用类型ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.费用类型ToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.新增ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.登记ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.水电气费DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.水电气费BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.水电气费BindingNavigator)).BeginInit();
            this.水电气费BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.水电气费DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 水电气费BindingSource
            // 
            this.水电气费BindingSource.DataMember = "水电气费";
            this.水电气费BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 水电气费TableAdapter
            // 
            this.水电气费TableAdapter.ClearBeforeFill = true;
            // 
            // 水电气费BindingNavigator
            // 
            this.水电气费BindingNavigator.AddNewItem = null;
            this.水电气费BindingNavigator.BindingSource = this.水电气费BindingSource;
            this.水电气费BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.水电气费BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.水电气费BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.楼栋名称ToolStripLabel,
            this.楼栋名称ToolStripComboBox,
            this.计费年份ToolStripLabel,
            this.计费年份ToolStripComboBox,
            this.计费月份ToolStripLabel,
            this.计费月份ToolStripComboBox,
            this.费用类型ToolStripLabel,
            this.费用类型ToolStripComboBox,
            this.查询ToolStripButton,
            this.新增ToolStripButton,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.水电气费BindingNavigatorSaveItem,
            this.登记ToolStripButton,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.水电气费BindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.水电气费BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.水电气费BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.水电气费BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.水电气费BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.水电气费BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.水电气费BindingNavigator.Name = "水电气费BindingNavigator";
            this.水电气费BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.水电气费BindingNavigator.Size = new System.Drawing.Size(549, 63);
            this.水电气费BindingNavigator.TabIndex = 0;
            this.水电气费BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(150, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(30, 13);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(51, 20);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // 水电气费BindingNavigatorSaveItem
            // 
            this.水电气费BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("水电气费BindingNavigatorSaveItem.Image")));
            this.水电气费BindingNavigatorSaveItem.Name = "水电气费BindingNavigatorSaveItem";
            this.水电气费BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 20);
            this.水电气费BindingNavigatorSaveItem.Text = "保存";
            this.水电气费BindingNavigatorSaveItem.Click += new System.EventHandler(this.水电气费BindingNavigatorSaveItem_Click);
            // 
            // 楼栋名称ToolStripLabel
            // 
            this.楼栋名称ToolStripLabel.Name = "楼栋名称ToolStripLabel";
            this.楼栋名称ToolStripLabel.Size = new System.Drawing.Size(59, 13);
            this.楼栋名称ToolStripLabel.Text = "楼栋名称:";
            // 
            // 楼栋名称ToolStripComboBox
            // 
            this.楼栋名称ToolStripComboBox.Name = "楼栋名称ToolStripComboBox";
            this.楼栋名称ToolStripComboBox.Size = new System.Drawing.Size(75, 21);
            // 
            // 计费年份ToolStripLabel
            // 
            this.计费年份ToolStripLabel.Name = "计费年份ToolStripLabel";
            this.计费年份ToolStripLabel.Size = new System.Drawing.Size(59, 13);
            this.计费年份ToolStripLabel.Text = "计费年份:";
            // 
            // 计费年份ToolStripComboBox
            // 
            this.计费年份ToolStripComboBox.Name = "计费年份ToolStripComboBox";
            this.计费年份ToolStripComboBox.Size = new System.Drawing.Size(75, 21);
            // 
            // 计费月份ToolStripLabel
            // 
            this.计费月份ToolStripLabel.Name = "计费月份ToolStripLabel";
            this.计费月份ToolStripLabel.Size = new System.Drawing.Size(59, 13);
            this.计费月份ToolStripLabel.Text = "计费月份:";
            // 
            // 计费月份ToolStripComboBox
            // 
            this.计费月份ToolStripComboBox.Name = "计费月份ToolStripComboBox";
            this.计费月份ToolStripComboBox.Size = new System.Drawing.Size(75, 21);
            // 
            // 费用类型ToolStripLabel
            // 
            this.费用类型ToolStripLabel.Name = "费用类型ToolStripLabel";
            this.费用类型ToolStripLabel.Size = new System.Drawing.Size(59, 13);
            this.费用类型ToolStripLabel.Text = "费用类型:";
            // 
            // 费用类型ToolStripComboBox
            // 
            this.费用类型ToolStripComboBox.Name = "费用类型ToolStripComboBox";
            this.费用类型ToolStripComboBox.Size = new System.Drawing.Size(75, 21);
            // 
            // 查询ToolStripButton
            // 
            this.查询ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripButton.Image")));
            this.查询ToolStripButton.Name = "查询ToolStripButton";
            this.查询ToolStripButton.Size = new System.Drawing.Size(51, 20);
            this.查询ToolStripButton.Text = "查询";
            this.查询ToolStripButton.Click += new System.EventHandler(this.查询ToolStripButton_Click);
            // 
            // 新增ToolStripButton
            // 
            this.新增ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新增ToolStripButton.Image")));
            this.新增ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增ToolStripButton.Name = "新增ToolStripButton";
            this.新增ToolStripButton.Size = new System.Drawing.Size(51, 20);
            this.新增ToolStripButton.Text = "新增";
            this.新增ToolStripButton.Click += new System.EventHandler(this.新增ToolStripButton_Click);
            // 
            // 登记ToolStripButton
            // 
            this.登记ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("登记ToolStripButton.Image")));
            this.登记ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.登记ToolStripButton.Name = "登记ToolStripButton";
            this.登记ToolStripButton.Size = new System.Drawing.Size(51, 20);
            this.登记ToolStripButton.Text = "登记";
            this.登记ToolStripButton.Click += new System.EventHandler(this.登记ToolStripButton_Click);
            // 
            // 水电气费DataGridView
            // 
            this.水电气费DataGridView.AutoGenerateColumns = false;
            this.水电气费DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.水电气费DataGridView.DataSource = this.水电气费BindingSource;
            this.水电气费DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.水电气费DataGridView.Location = new System.Drawing.Point(0, 63);
            this.水电气费DataGridView.Name = "水电气费DataGridView";
            this.水电气费DataGridView.RowTemplate.Height = 23;
            this.水电气费DataGridView.Size = new System.Drawing.Size(549, 355);
            this.水电气费DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "业主姓名";
            this.dataGridViewTextBoxColumn4.HeaderText = "业主姓名";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "表编号";
            this.dataGridViewTextBoxColumn8.HeaderText = "表编号";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "表底数";
            this.dataGridViewTextBoxColumn9.HeaderText = "表底数";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "表止数";
            this.dataGridViewTextBoxColumn10.HeaderText = "表止数";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "计费单价";
            this.dataGridViewTextBoxColumn11.HeaderText = "计费单价";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "费用类型";
            this.dataGridViewTextBoxColumn7.HeaderText = "费用类型";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "计费年份";
            this.dataGridViewTextBoxColumn5.HeaderText = "计费年份";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "计费月份";
            this.dataGridViewTextBoxColumn6.HeaderText = "计费月份";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "楼栋名称";
            this.dataGridViewTextBoxColumn2.HeaderText = "楼栋名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "业主编号";
            this.dataGridViewTextBoxColumn3.HeaderText = "业主编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "自动编号";
            this.dataGridViewTextBoxColumn1.HeaderText = "自动编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "登记标志";
            this.dataGridViewTextBoxColumn12.HeaderText = "登记标志";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "费用状态";
            this.dataGridViewTextBoxColumn13.HeaderText = "费用状态";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "收据编号";
            this.dataGridViewTextBoxColumn14.HeaderText = "收据编号";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // GasRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 418);
            this.Controls.Add(this.水电气费DataGridView);
            this.Controls.Add(this.水电气费BindingNavigator);
            this.Name = "GasRegisterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用管理[水电气费登记]";
            this.Load += new System.EventHandler(this.GasRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.水电气费BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.水电气费BindingNavigator)).EndInit();
            this.水电气费BindingNavigator.ResumeLayout(false);
            this.水电气费BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.水电气费DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 水电气费BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.水电气费TableAdapter 水电气费TableAdapter;
        private System.Windows.Forms.BindingNavigator 水电气费BindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 水电气费BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 楼栋名称ToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox 楼栋名称ToolStripComboBox;
        private System.Windows.Forms.ToolStripLabel 计费年份ToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox 计费年份ToolStripComboBox;
        private System.Windows.Forms.ToolStripLabel 计费月份ToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox 计费月份ToolStripComboBox;
        private System.Windows.Forms.ToolStripLabel 费用类型ToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox 费用类型ToolStripComboBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton 新增ToolStripButton;
        private System.Windows.Forms.ToolStripButton 登记ToolStripButton;
        private System.Windows.Forms.DataGridView 水电气费DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}