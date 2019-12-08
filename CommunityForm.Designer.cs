namespace MyCommunity
{
    partial class CommunityForm
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
            System.Windows.Forms.Label 小区网站Label;
            System.Windows.Forms.Label 小区名称Label;
            System.Windows.Forms.Label 总负责人Label;
            System.Windows.Forms.Label 小区地址Label;
            System.Windows.Forms.Label 邮政编码Label;
            System.Windows.Forms.Label 服务电话Label;
            System.Windows.Forms.Label 电子信箱Label;
            System.Windows.Forms.Label 背景图像Label;
            System.Windows.Forms.Label 标志图标Label;
            System.Windows.Forms.Label 系统名称Label;
            System.Windows.Forms.Label 优先级Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommunityForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.小区信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.小区信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.小区信息TableAdapter();
            this.小区信息BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.小区信息BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.浏览图标Button = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.浏览图像Button = new System.Windows.Forms.Button();
            this.小区网站TextBox = new System.Windows.Forms.TextBox();
            this.小区信息DataGridView = new System.Windows.Forms.DataGridView();
            this.总负责人TextBox = new System.Windows.Forms.TextBox();
            this.小区地址TextBox = new System.Windows.Forms.TextBox();
            this.邮政编码TextBox = new System.Windows.Forms.TextBox();
            this.小区名称TextBox = new System.Windows.Forms.TextBox();
            this.服务电话TextBox = new System.Windows.Forms.TextBox();
            this.电子信箱TextBox = new System.Windows.Forms.TextBox();
            this.背景图像TextBox = new System.Windows.Forms.TextBox();
            this.标志图标TextBox = new System.Windows.Forms.TextBox();
            this.系统名称TextBox = new System.Windows.Forms.TextBox();
            this.优先级TextBox = new System.Windows.Forms.TextBox();
            小区网站Label = new System.Windows.Forms.Label();
            小区名称Label = new System.Windows.Forms.Label();
            总负责人Label = new System.Windows.Forms.Label();
            小区地址Label = new System.Windows.Forms.Label();
            邮政编码Label = new System.Windows.Forms.Label();
            服务电话Label = new System.Windows.Forms.Label();
            电子信箱Label = new System.Windows.Forms.Label();
            背景图像Label = new System.Windows.Forms.Label();
            标志图标Label = new System.Windows.Forms.Label();
            系统名称Label = new System.Windows.Forms.Label();
            优先级Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.小区信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.小区信息BindingNavigator)).BeginInit();
            this.小区信息BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.小区信息DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 小区网站Label
            // 
            小区网站Label.AutoSize = true;
            小区网站Label.Location = new System.Drawing.Point(2, 111);
            小区网站Label.Name = "小区网站Label";
            小区网站Label.Size = new System.Drawing.Size(59, 12);
            小区网站Label.TabIndex = 49;
            小区网站Label.Text = "小区网站:";
            // 
            // 小区名称Label
            // 
            小区名称Label.AutoSize = true;
            小区名称Label.Location = new System.Drawing.Point(2, 30);
            小区名称Label.Name = "小区名称Label";
            小区名称Label.Size = new System.Drawing.Size(59, 12);
            小区名称Label.TabIndex = 28;
            小区名称Label.Text = "小区名称:";
            // 
            // 总负责人Label
            // 
            总负责人Label.AutoSize = true;
            总负责人Label.Location = new System.Drawing.Point(225, 30);
            总负责人Label.Name = "总负责人Label";
            总负责人Label.Size = new System.Drawing.Size(59, 12);
            总负责人Label.TabIndex = 30;
            总负责人Label.Text = "总负责人:";
            // 
            // 小区地址Label
            // 
            小区地址Label.AutoSize = true;
            小区地址Label.Location = new System.Drawing.Point(2, 57);
            小区地址Label.Name = "小区地址Label";
            小区地址Label.Size = new System.Drawing.Size(59, 12);
            小区地址Label.TabIndex = 32;
            小区地址Label.Text = "小区地址:";
            // 
            // 邮政编码Label
            // 
            邮政编码Label.AutoSize = true;
            邮政编码Label.Location = new System.Drawing.Point(362, 57);
            邮政编码Label.Name = "邮政编码Label";
            邮政编码Label.Size = new System.Drawing.Size(59, 12);
            邮政编码Label.TabIndex = 34;
            邮政编码Label.Text = "邮政编码:";
            // 
            // 服务电话Label
            // 
            服务电话Label.AutoSize = true;
            服务电话Label.Location = new System.Drawing.Point(362, 30);
            服务电话Label.Name = "服务电话Label";
            服务电话Label.Size = new System.Drawing.Size(59, 12);
            服务电话Label.TabIndex = 36;
            服务电话Label.Text = "服务电话:";
            // 
            // 电子信箱Label
            // 
            电子信箱Label.AutoSize = true;
            电子信箱Label.Location = new System.Drawing.Point(2, 84);
            电子信箱Label.Name = "电子信箱Label";
            电子信箱Label.Size = new System.Drawing.Size(59, 12);
            电子信箱Label.TabIndex = 38;
            电子信箱Label.Text = "电子信箱:";
            // 
            // 背景图像Label
            // 
            背景图像Label.AutoSize = true;
            背景图像Label.Location = new System.Drawing.Point(225, 84);
            背景图像Label.Name = "背景图像Label";
            背景图像Label.Size = new System.Drawing.Size(59, 12);
            背景图像Label.TabIndex = 40;
            背景图像Label.Text = "背景图像:";
            // 
            // 标志图标Label
            // 
            标志图标Label.AutoSize = true;
            标志图标Label.Location = new System.Drawing.Point(225, 111);
            标志图标Label.Name = "标志图标Label";
            标志图标Label.Size = new System.Drawing.Size(59, 12);
            标志图标Label.TabIndex = 42;
            标志图标Label.Text = "标志图标:";
            // 
            // 系统名称Label
            // 
            系统名称Label.AutoSize = true;
            系统名称Label.Location = new System.Drawing.Point(2, 138);
            系统名称Label.Name = "系统名称Label";
            系统名称Label.Size = new System.Drawing.Size(59, 12);
            系统名称Label.TabIndex = 44;
            系统名称Label.Text = "系统名称:";
            // 
            // 优先级Label
            // 
            优先级Label.AutoSize = true;
            优先级Label.Location = new System.Drawing.Point(362, 138);
            优先级Label.Name = "优先级Label";
            优先级Label.Size = new System.Drawing.Size(47, 12);
            优先级Label.TabIndex = 46;
            优先级Label.Text = "优先级:";
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 小区信息BindingSource
            // 
            this.小区信息BindingSource.DataMember = "小区信息";
            this.小区信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 小区信息TableAdapter
            // 
            this.小区信息TableAdapter.ClearBeforeFill = true;
            // 
            // 小区信息BindingNavigator
            // 
            this.小区信息BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.小区信息BindingNavigator.BindingSource = this.小区信息BindingSource;
            this.小区信息BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.小区信息BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.小区信息BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.小区信息BindingNavigatorSaveItem});
            this.小区信息BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.小区信息BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.小区信息BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.小区信息BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.小区信息BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.小区信息BindingNavigator.Name = "小区信息BindingNavigator";
            this.小区信息BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.小区信息BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.小区信息BindingNavigator.TabIndex = 0;
            this.小区信息BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(30, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // 小区信息BindingNavigatorSaveItem
            // 
            this.小区信息BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("小区信息BindingNavigatorSaveItem.Image")));
            this.小区信息BindingNavigatorSaveItem.Name = "小区信息BindingNavigatorSaveItem";
            this.小区信息BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.小区信息BindingNavigatorSaveItem.Text = "保存";
            this.小区信息BindingNavigatorSaveItem.Click += new System.EventHandler(this.小区信息BindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "小区名称";
            this.dataGridViewTextBoxColumn1.HeaderText = "小区名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "小区地址";
            this.dataGridViewTextBoxColumn3.HeaderText = "小区地址";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "总负责人";
            this.dataGridViewTextBoxColumn2.HeaderText = "总负责人";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "邮政编码";
            this.dataGridViewTextBoxColumn4.HeaderText = "邮政编码";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "系统名称";
            this.dataGridViewTextBoxColumn10.HeaderText = "系统名称";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "标志图标";
            this.dataGridViewTextBoxColumn9.HeaderText = "标志图标";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // 浏览图标Button
            // 
            this.浏览图标Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.浏览图标Button.Location = new System.Drawing.Point(428, 107);
            this.浏览图标Button.Name = "浏览图标Button";
            this.浏览图标Button.Size = new System.Drawing.Size(109, 23);
            this.浏览图标Button.TabIndex = 52;
            this.浏览图标Button.Text = "浏览图标...";
            this.浏览图标Button.UseVisualStyleBackColor = true;
            this.浏览图标Button.Click += new System.EventHandler(this.浏览图标Button_Click);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "优先级";
            this.dataGridViewTextBoxColumn11.HeaderText = "优先级";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "电子信箱";
            this.dataGridViewTextBoxColumn6.HeaderText = "电子信箱";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "服务电话";
            this.dataGridViewTextBoxColumn5.HeaderText = "服务电话";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "背景图像";
            this.dataGridViewTextBoxColumn8.HeaderText = "背景图像";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "小区网站";
            this.dataGridViewTextBoxColumn7.HeaderText = "小区网站";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // 浏览图像Button
            // 
            this.浏览图像Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.浏览图像Button.Location = new System.Drawing.Point(428, 79);
            this.浏览图像Button.Name = "浏览图像Button";
            this.浏览图像Button.Size = new System.Drawing.Size(109, 23);
            this.浏览图像Button.TabIndex = 51;
            this.浏览图像Button.Text = "浏览图像...";
            this.浏览图像Button.UseVisualStyleBackColor = true;
            this.浏览图像Button.Click += new System.EventHandler(this.浏览图像Button_Click);
            // 
            // 小区网站TextBox
            // 
            this.小区网站TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "小区网站", true));
            this.小区网站TextBox.Location = new System.Drawing.Point(67, 108);
            this.小区网站TextBox.Name = "小区网站TextBox";
            this.小区网站TextBox.Size = new System.Drawing.Size(152, 21);
            this.小区网站TextBox.TabIndex = 6;
            // 
            // 小区信息DataGridView
            // 
            this.小区信息DataGridView.AllowUserToAddRows = false;
            this.小区信息DataGridView.AllowUserToDeleteRows = false;
            this.小区信息DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.小区信息DataGridView.AutoGenerateColumns = false;
            this.小区信息DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.小区信息DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.小区信息DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.小区信息DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.小区信息DataGridView.DataSource = this.小区信息BindingSource;
            this.小区信息DataGridView.Location = new System.Drawing.Point(4, 164);
            this.小区信息DataGridView.MultiSelect = false;
            this.小区信息DataGridView.Name = "小区信息DataGridView";
            this.小区信息DataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.小区信息DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.小区信息DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Green;
            this.小区信息DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.小区信息DataGridView.RowTemplate.Height = 23;
            this.小区信息DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.小区信息DataGridView.Size = new System.Drawing.Size(533, 250);
            this.小区信息DataGridView.TabIndex = 48;
            // 
            // 总负责人TextBox
            // 
            this.总负责人TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "总负责人", true));
            this.总负责人TextBox.Location = new System.Drawing.Point(290, 27);
            this.总负责人TextBox.Name = "总负责人TextBox";
            this.总负责人TextBox.Size = new System.Drawing.Size(66, 21);
            this.总负责人TextBox.TabIndex = 1;
            // 
            // 小区地址TextBox
            // 
            this.小区地址TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "小区地址", true));
            this.小区地址TextBox.Location = new System.Drawing.Point(67, 54);
            this.小区地址TextBox.Name = "小区地址TextBox";
            this.小区地址TextBox.Size = new System.Drawing.Size(289, 21);
            this.小区地址TextBox.TabIndex = 3;
            // 
            // 邮政编码TextBox
            // 
            this.邮政编码TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.邮政编码TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "邮政编码", true));
            this.邮政编码TextBox.Location = new System.Drawing.Point(427, 54);
            this.邮政编码TextBox.Name = "邮政编码TextBox";
            this.邮政编码TextBox.Size = new System.Drawing.Size(110, 21);
            this.邮政编码TextBox.TabIndex = 4;
            // 
            // 小区名称TextBox
            // 
            this.小区名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "小区名称", true));
            this.小区名称TextBox.Location = new System.Drawing.Point(67, 27);
            this.小区名称TextBox.Name = "小区名称TextBox";
            this.小区名称TextBox.Size = new System.Drawing.Size(152, 21);
            this.小区名称TextBox.TabIndex = 0;
            // 
            // 服务电话TextBox
            // 
            this.服务电话TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.服务电话TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "服务电话", true));
            this.服务电话TextBox.Location = new System.Drawing.Point(427, 27);
            this.服务电话TextBox.Name = "服务电话TextBox";
            this.服务电话TextBox.Size = new System.Drawing.Size(110, 21);
            this.服务电话TextBox.TabIndex = 2;
            // 
            // 电子信箱TextBox
            // 
            this.电子信箱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "电子信箱", true));
            this.电子信箱TextBox.Location = new System.Drawing.Point(67, 81);
            this.电子信箱TextBox.Name = "电子信箱TextBox";
            this.电子信箱TextBox.Size = new System.Drawing.Size(152, 21);
            this.电子信箱TextBox.TabIndex = 5;
            // 
            // 背景图像TextBox
            // 
            this.背景图像TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.背景图像TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "背景图像", true));
            this.背景图像TextBox.Location = new System.Drawing.Point(290, 81);
            this.背景图像TextBox.Name = "背景图像TextBox";
            this.背景图像TextBox.ReadOnly = true;
            this.背景图像TextBox.Size = new System.Drawing.Size(131, 21);
            this.背景图像TextBox.TabIndex = 7;
            // 
            // 标志图标TextBox
            // 
            this.标志图标TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.标志图标TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "标志图标", true));
            this.标志图标TextBox.Location = new System.Drawing.Point(290, 108);
            this.标志图标TextBox.Name = "标志图标TextBox";
            this.标志图标TextBox.ReadOnly = true;
            this.标志图标TextBox.Size = new System.Drawing.Size(131, 21);
            this.标志图标TextBox.TabIndex = 8;
            // 
            // 系统名称TextBox
            // 
            this.系统名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "系统名称", true));
            this.系统名称TextBox.Location = new System.Drawing.Point(67, 135);
            this.系统名称TextBox.Name = "系统名称TextBox";
            this.系统名称TextBox.Size = new System.Drawing.Size(289, 21);
            this.系统名称TextBox.TabIndex = 9;
            // 
            // 优先级TextBox
            // 
            this.优先级TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.优先级TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.小区信息BindingSource, "优先级", true));
            this.优先级TextBox.Location = new System.Drawing.Point(427, 135);
            this.优先级TextBox.Name = "优先级TextBox";
            this.优先级TextBox.Size = new System.Drawing.Size(110, 21);
            this.优先级TextBox.TabIndex = 10;
            // 
            // CommunityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.浏览图标Button);
            this.Controls.Add(this.浏览图像Button);
            this.Controls.Add(小区网站Label);
            this.Controls.Add(this.小区网站TextBox);
            this.Controls.Add(this.小区信息DataGridView);
            this.Controls.Add(小区名称Label);
            this.Controls.Add(总负责人Label);
            this.Controls.Add(小区地址Label);
            this.Controls.Add(邮政编码Label);
            this.Controls.Add(服务电话Label);
            this.Controls.Add(电子信箱Label);
            this.Controls.Add(背景图像Label);
            this.Controls.Add(标志图标Label);
            this.Controls.Add(系统名称Label);
            this.Controls.Add(优先级Label);
            this.Controls.Add(this.总负责人TextBox);
            this.Controls.Add(this.小区地址TextBox);
            this.Controls.Add(this.邮政编码TextBox);
            this.Controls.Add(this.小区名称TextBox);
            this.Controls.Add(this.服务电话TextBox);
            this.Controls.Add(this.电子信箱TextBox);
            this.Controls.Add(this.背景图像TextBox);
            this.Controls.Add(this.标志图标TextBox);
            this.Controls.Add(this.系统名称TextBox);
            this.Controls.Add(this.优先级TextBox);
            this.Controls.Add(this.小区信息BindingNavigator);
            this.Name = "CommunityForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统管理[小区信息设置]";
            this.Load += new System.EventHandler(this.CommunityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.小区信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.小区信息BindingNavigator)).EndInit();
            this.小区信息BindingNavigator.ResumeLayout(false);
            this.小区信息BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.小区信息DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 小区信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.小区信息TableAdapter 小区信息TableAdapter;
        private System.Windows.Forms.BindingNavigator 小区信息BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton 小区信息BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button 浏览图标Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button 浏览图像Button;
        private System.Windows.Forms.TextBox 小区网站TextBox;
        private System.Windows.Forms.DataGridView 小区信息DataGridView;
        private System.Windows.Forms.TextBox 总负责人TextBox;
        private System.Windows.Forms.TextBox 小区地址TextBox;
        private System.Windows.Forms.TextBox 邮政编码TextBox;
        private System.Windows.Forms.TextBox 小区名称TextBox;
        private System.Windows.Forms.TextBox 服务电话TextBox;
        private System.Windows.Forms.TextBox 电子信箱TextBox;
        private System.Windows.Forms.TextBox 背景图像TextBox;
        private System.Windows.Forms.TextBox 标志图标TextBox;
        private System.Windows.Forms.TextBox 系统名称TextBox;
        private System.Windows.Forms.TextBox 优先级TextBox;
    }
}