namespace MyCommunity
{
    partial class CommonPropertyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonPropertyForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label 财产编号Label;
            System.Windows.Forms.Label 财产名称Label;
            System.Windows.Forms.Label 规格型号Label;
            System.Windows.Forms.Label 所属类别Label;
            System.Windows.Forms.Label 财产原值Label;
            System.Windows.Forms.Label 启用日期Label;
            System.Windows.Forms.Label 存放位置Label;
            System.Windows.Forms.Label 当前状态Label;
            System.Windows.Forms.Label 保管人员Label;
            System.Windows.Forms.Label 补充说明Label;
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.公共财产BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.公共财产TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.公共财产TableAdapter();
            this.公共财产BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.公共财产BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.财产编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公共财产DataGridView = new System.Windows.Forms.DataGridView();
            this.财产名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格型号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属类别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.财产原值DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.启用日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.存放位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.保管人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.保管人员TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.当前状态TextBox = new System.Windows.Forms.TextBox();
            this.财产编号TextBox = new System.Windows.Forms.TextBox();
            this.财产名称TextBox = new System.Windows.Forms.TextBox();
            this.规格型号TextBox = new System.Windows.Forms.TextBox();
            this.所属类别TextBox = new System.Windows.Forms.TextBox();
            this.财产原值TextBox = new System.Windows.Forms.TextBox();
            this.启用日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.存放位置TextBox = new System.Windows.Forms.TextBox();
            财产编号Label = new System.Windows.Forms.Label();
            财产名称Label = new System.Windows.Forms.Label();
            规格型号Label = new System.Windows.Forms.Label();
            所属类别Label = new System.Windows.Forms.Label();
            财产原值Label = new System.Windows.Forms.Label();
            启用日期Label = new System.Windows.Forms.Label();
            存放位置Label = new System.Windows.Forms.Label();
            当前状态Label = new System.Windows.Forms.Label();
            保管人员Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产BindingNavigator)).BeginInit();
            this.公共财产BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 公共财产BindingSource
            // 
            this.公共财产BindingSource.DataMember = "公共财产";
            this.公共财产BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 公共财产TableAdapter
            // 
            this.公共财产TableAdapter.ClearBeforeFill = true;
            // 
            // 公共财产BindingNavigator
            // 
            this.公共财产BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.公共财产BindingNavigator.BindingSource = this.公共财产BindingSource;
            this.公共财产BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.公共财产BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.公共财产BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.公共财产BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.公共财产BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.公共财产BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.公共财产BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.公共财产BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.公共财产BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.公共财产BindingNavigator.Name = "公共财产BindingNavigator";
            this.公共财产BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.公共财产BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.公共财产BindingNavigator.TabIndex = 0;
            this.公共财产BindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(30, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // 公共财产BindingNavigatorSaveItem
            // 
            this.公共财产BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("公共财产BindingNavigatorSaveItem.Image")));
            this.公共财产BindingNavigatorSaveItem.Name = "公共财产BindingNavigatorSaveItem";
            this.公共财产BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.公共财产BindingNavigatorSaveItem.Text = "保存";
            this.公共财产BindingNavigatorSaveItem.Click += new System.EventHandler(this.公共财产BindingNavigatorSaveItem_Click);
            // 
            // 打印ToolStripButton
            // 
            this.打印ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打印ToolStripButton.Image")));
            this.打印ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印ToolStripButton.Name = "打印ToolStripButton";
            this.打印ToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.打印ToolStripButton.Text = "打印";
            this.打印ToolStripButton.Click += new System.EventHandler(this.打印ToolStripButton_Click);
            // 
            // 财产编号DataGridViewTextBoxColumn
            // 
            this.财产编号DataGridViewTextBoxColumn.DataPropertyName = "财产编号";
            this.财产编号DataGridViewTextBoxColumn.HeaderText = "财产编号";
            this.财产编号DataGridViewTextBoxColumn.Name = "财产编号DataGridViewTextBoxColumn";
            this.财产编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 公共财产DataGridView
            // 
            this.公共财产DataGridView.AllowUserToAddRows = false;
            this.公共财产DataGridView.AllowUserToDeleteRows = false;
            this.公共财产DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.公共财产DataGridView.AutoGenerateColumns = false;
            this.公共财产DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.公共财产DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共财产DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.公共财产DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.财产编号DataGridViewTextBoxColumn,
            this.财产名称DataGridViewTextBoxColumn,
            this.规格型号DataGridViewTextBoxColumn,
            this.所属类别DataGridViewTextBoxColumn,
            this.财产原值DataGridViewTextBoxColumn,
            this.启用日期DataGridViewTextBoxColumn,
            this.存放位置DataGridViewTextBoxColumn,
            this.当前状态DataGridViewTextBoxColumn,
            this.保管人员DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.公共财产DataGridView.DataSource = this.公共财产BindingSource;
            this.公共财产DataGridView.Location = new System.Drawing.Point(1, 125);
            this.公共财产DataGridView.MultiSelect = false;
            this.公共财产DataGridView.Name = "公共财产DataGridView";
            this.公共财产DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共财产DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.公共财产DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.公共财产DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.公共财产DataGridView.RowTemplate.Height = 23;
            this.公共财产DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.公共财产DataGridView.Size = new System.Drawing.Size(540, 290);
            this.公共财产DataGridView.TabIndex = 46;
            // 
            // 财产名称DataGridViewTextBoxColumn
            // 
            this.财产名称DataGridViewTextBoxColumn.DataPropertyName = "财产名称";
            this.财产名称DataGridViewTextBoxColumn.HeaderText = "财产名称";
            this.财产名称DataGridViewTextBoxColumn.Name = "财产名称DataGridViewTextBoxColumn";
            this.财产名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 规格型号DataGridViewTextBoxColumn
            // 
            this.规格型号DataGridViewTextBoxColumn.DataPropertyName = "规格型号";
            this.规格型号DataGridViewTextBoxColumn.HeaderText = "规格型号";
            this.规格型号DataGridViewTextBoxColumn.Name = "规格型号DataGridViewTextBoxColumn";
            this.规格型号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 所属类别DataGridViewTextBoxColumn
            // 
            this.所属类别DataGridViewTextBoxColumn.DataPropertyName = "所属类别";
            this.所属类别DataGridViewTextBoxColumn.HeaderText = "所属类别";
            this.所属类别DataGridViewTextBoxColumn.Name = "所属类别DataGridViewTextBoxColumn";
            this.所属类别DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 财产原值DataGridViewTextBoxColumn
            // 
            this.财产原值DataGridViewTextBoxColumn.DataPropertyName = "财产原值";
            this.财产原值DataGridViewTextBoxColumn.HeaderText = "财产原值";
            this.财产原值DataGridViewTextBoxColumn.Name = "财产原值DataGridViewTextBoxColumn";
            this.财产原值DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 启用日期DataGridViewTextBoxColumn
            // 
            this.启用日期DataGridViewTextBoxColumn.DataPropertyName = "启用日期";
            this.启用日期DataGridViewTextBoxColumn.HeaderText = "启用日期";
            this.启用日期DataGridViewTextBoxColumn.Name = "启用日期DataGridViewTextBoxColumn";
            this.启用日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 存放位置DataGridViewTextBoxColumn
            // 
            this.存放位置DataGridViewTextBoxColumn.DataPropertyName = "存放位置";
            this.存放位置DataGridViewTextBoxColumn.HeaderText = "存放位置";
            this.存放位置DataGridViewTextBoxColumn.Name = "存放位置DataGridViewTextBoxColumn";
            this.存放位置DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 当前状态DataGridViewTextBoxColumn
            // 
            this.当前状态DataGridViewTextBoxColumn.DataPropertyName = "当前状态";
            this.当前状态DataGridViewTextBoxColumn.HeaderText = "当前状态";
            this.当前状态DataGridViewTextBoxColumn.Name = "当前状态DataGridViewTextBoxColumn";
            this.当前状态DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 保管人员DataGridViewTextBoxColumn
            // 
            this.保管人员DataGridViewTextBoxColumn.DataPropertyName = "保管人员";
            this.保管人员DataGridViewTextBoxColumn.HeaderText = "保管人员";
            this.保管人员DataGridViewTextBoxColumn.Name = "保管人员DataGridViewTextBoxColumn";
            this.保管人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 补充说明DataGridViewTextBoxColumn
            // 
            this.补充说明DataGridViewTextBoxColumn.DataPropertyName = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.Name = "补充说明DataGridViewTextBoxColumn";
            this.补充说明DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 财产编号Label
            // 
            财产编号Label.AutoSize = true;
            财产编号Label.Location = new System.Drawing.Point(0, 31);
            财产编号Label.Name = "财产编号Label";
            财产编号Label.Size = new System.Drawing.Size(59, 12);
            财产编号Label.TabIndex = 26;
            财产编号Label.Text = "财产编号:";
            // 
            // 财产名称Label
            // 
            财产名称Label.AutoSize = true;
            财产名称Label.Location = new System.Drawing.Point(181, 31);
            财产名称Label.Name = "财产名称Label";
            财产名称Label.Size = new System.Drawing.Size(59, 12);
            财产名称Label.TabIndex = 28;
            财产名称Label.Text = "财产名称:";
            // 
            // 规格型号Label
            // 
            规格型号Label.AutoSize = true;
            规格型号Label.Location = new System.Drawing.Point(354, 31);
            规格型号Label.Name = "规格型号Label";
            规格型号Label.Size = new System.Drawing.Size(59, 12);
            规格型号Label.TabIndex = 30;
            规格型号Label.Text = "规格型号:";
            // 
            // 所属类别Label
            // 
            所属类别Label.AutoSize = true;
            所属类别Label.Location = new System.Drawing.Point(-1, 54);
            所属类别Label.Name = "所属类别Label";
            所属类别Label.Size = new System.Drawing.Size(59, 12);
            所属类别Label.TabIndex = 32;
            所属类别Label.Text = "所属类别:";
            // 
            // 财产原值Label
            // 
            财产原值Label.AutoSize = true;
            财产原值Label.Location = new System.Drawing.Point(158, 55);
            财产原值Label.Name = "财产原值Label";
            财产原值Label.Size = new System.Drawing.Size(83, 12);
            财产原值Label.TabIndex = 34;
            财产原值Label.Text = "财产原值(元):";
            // 
            // 启用日期Label
            // 
            启用日期Label.AutoSize = true;
            启用日期Label.Location = new System.Drawing.Point(335, 55);
            启用日期Label.Name = "启用日期Label";
            启用日期Label.Size = new System.Drawing.Size(59, 12);
            启用日期Label.TabIndex = 36;
            启用日期Label.Text = "启用日期:";
            // 
            // 存放位置Label
            // 
            存放位置Label.AutoSize = true;
            存放位置Label.Location = new System.Drawing.Point(-2, 77);
            存放位置Label.Name = "存放位置Label";
            存放位置Label.Size = new System.Drawing.Size(59, 12);
            存放位置Label.TabIndex = 38;
            存放位置Label.Text = "存放位置:";
            // 
            // 当前状态Label
            // 
            当前状态Label.AutoSize = true;
            当前状态Label.Location = new System.Drawing.Point(231, 77);
            当前状态Label.Name = "当前状态Label";
            当前状态Label.Size = new System.Drawing.Size(59, 12);
            当前状态Label.TabIndex = 40;
            当前状态Label.Text = "当前状态:";
            // 
            // 保管人员Label
            // 
            保管人员Label.AutoSize = true;
            保管人员Label.Location = new System.Drawing.Point(374, 77);
            保管人员Label.Name = "保管人员Label";
            保管人员Label.Size = new System.Drawing.Size(59, 12);
            保管人员Label.TabIndex = 42;
            保管人员Label.Text = "保管人员:";
            // 
            // 保管人员TextBox
            // 
            this.保管人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "保管人员", true));
            this.保管人员TextBox.Location = new System.Drawing.Point(439, 73);
            this.保管人员TextBox.Name = "保管人员TextBox";
            this.保管人员TextBox.Size = new System.Drawing.Size(102, 21);
            this.保管人员TextBox.TabIndex = 8;
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(-2, 100);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(59, 12);
            补充说明Label.TabIndex = 44;
            补充说明Label.Text = "补充说明:";
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(63, 98);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(478, 21);
            this.补充说明TextBox.TabIndex = 9;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 当前状态TextBox
            // 
            this.当前状态TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "当前状态", true));
            this.当前状态TextBox.Location = new System.Drawing.Point(295, 73);
            this.当前状态TextBox.Name = "当前状态TextBox";
            this.当前状态TextBox.Size = new System.Drawing.Size(73, 21);
            this.当前状态TextBox.TabIndex = 7;
            // 
            // 财产编号TextBox
            // 
            this.财产编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "财产编号", true));
            this.财产编号TextBox.Location = new System.Drawing.Point(62, 25);
            this.财产编号TextBox.Name = "财产编号TextBox";
            this.财产编号TextBox.Size = new System.Drawing.Size(113, 21);
            this.财产编号TextBox.TabIndex = 0;
            // 
            // 财产名称TextBox
            // 
            this.财产名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "财产名称", true));
            this.财产名称TextBox.Location = new System.Drawing.Point(241, 25);
            this.财产名称TextBox.Name = "财产名称TextBox";
            this.财产名称TextBox.Size = new System.Drawing.Size(107, 21);
            this.财产名称TextBox.TabIndex = 1;
            // 
            // 规格型号TextBox
            // 
            this.规格型号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "规格型号", true));
            this.规格型号TextBox.Location = new System.Drawing.Point(416, 25);
            this.规格型号TextBox.Name = "规格型号TextBox";
            this.规格型号TextBox.Size = new System.Drawing.Size(125, 21);
            this.规格型号TextBox.TabIndex = 2;
            // 
            // 所属类别TextBox
            // 
            this.所属类别TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "所属类别", true));
            this.所属类别TextBox.Location = new System.Drawing.Point(62, 49);
            this.所属类别TextBox.Name = "所属类别TextBox";
            this.所属类别TextBox.Size = new System.Drawing.Size(87, 21);
            this.所属类别TextBox.TabIndex = 3;
            // 
            // 财产原值TextBox
            // 
            this.财产原值TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "财产原值", true));
            this.财产原值TextBox.Location = new System.Drawing.Point(241, 49);
            this.财产原值TextBox.Name = "财产原值TextBox";
            this.财产原值TextBox.Size = new System.Drawing.Size(88, 21);
            this.财产原值TextBox.TabIndex = 4;
            // 
            // 启用日期DateTimePicker
            // 
            this.启用日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.公共财产BindingSource, "启用日期", true));
            this.启用日期DateTimePicker.Location = new System.Drawing.Point(400, 49);
            this.启用日期DateTimePicker.Name = "启用日期DateTimePicker";
            this.启用日期DateTimePicker.Size = new System.Drawing.Size(141, 21);
            this.启用日期DateTimePicker.TabIndex = 5;
            // 
            // 存放位置TextBox
            // 
            this.存放位置TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共财产BindingSource, "存放位置", true));
            this.存放位置TextBox.Location = new System.Drawing.Point(62, 73);
            this.存放位置TextBox.Name = "存放位置TextBox";
            this.存放位置TextBox.Size = new System.Drawing.Size(163, 21);
            this.存放位置TextBox.TabIndex = 6;
            // 
            // CommonPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.公共财产DataGridView);
            this.Controls.Add(财产编号Label);
            this.Controls.Add(财产名称Label);
            this.Controls.Add(规格型号Label);
            this.Controls.Add(所属类别Label);
            this.Controls.Add(财产原值Label);
            this.Controls.Add(启用日期Label);
            this.Controls.Add(存放位置Label);
            this.Controls.Add(当前状态Label);
            this.Controls.Add(保管人员Label);
            this.Controls.Add(this.保管人员TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.当前状态TextBox);
            this.Controls.Add(this.财产编号TextBox);
            this.Controls.Add(this.财产名称TextBox);
            this.Controls.Add(this.规格型号TextBox);
            this.Controls.Add(this.所属类别TextBox);
            this.Controls.Add(this.财产原值TextBox);
            this.Controls.Add(this.启用日期DateTimePicker);
            this.Controls.Add(this.存放位置TextBox);
            this.Controls.Add(this.公共财产BindingNavigator);
            this.Name = "CommonPropertyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本管理[公共财产管理]";
            this.Load += new System.EventHandler(this.CommonPropertyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产BindingNavigator)).EndInit();
            this.公共财产BindingNavigator.ResumeLayout(false);
            this.公共财产BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 公共财产BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.公共财产TableAdapter 公共财产TableAdapter;
        private System.Windows.Forms.BindingNavigator 公共财产BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton 公共财产BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 财产编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView 公共财产DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 财产名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格型号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属类别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 财产原值DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 启用日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 存放位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 保管人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox 保管人员TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.TextBox 当前状态TextBox;
        private System.Windows.Forms.TextBox 财产编号TextBox;
        private System.Windows.Forms.TextBox 财产名称TextBox;
        private System.Windows.Forms.TextBox 规格型号TextBox;
        private System.Windows.Forms.TextBox 所属类别TextBox;
        private System.Windows.Forms.TextBox 财产原值TextBox;
        private System.Windows.Forms.DateTimePicker 启用日期DateTimePicker;
        private System.Windows.Forms.TextBox 存放位置TextBox;
    }
}