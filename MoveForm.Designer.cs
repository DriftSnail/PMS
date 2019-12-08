namespace MyCommunity
{
    partial class MoveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label 业主编号Label;
            System.Windows.Forms.Label 业主姓名Label;
            System.Windows.Forms.Label 迁出日期Label;
            System.Windows.Forms.Label 迁出原因Label;
            System.Windows.Forms.Label 补充说明Label;
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.迁出信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.迁出信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.迁出信息TableAdapter();
            this.迁出信息BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.迁出信息BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.业主编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.业主编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            this.迁出原因DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.迁出日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.迁出信息DataGridView = new System.Windows.Forms.DataGridView();
            this.业主编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.迁出原因TextBox = new System.Windows.Forms.TextBox();
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名ComboBox = new System.Windows.Forms.ComboBox();
            this.迁出日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.楼栋信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.楼栋信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter();
            业主编号Label = new System.Windows.Forms.Label();
            业主姓名Label = new System.Windows.Forms.Label();
            迁出日期Label = new System.Windows.Forms.Label();
            迁出原因Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息BindingNavigator)).BeginInit();
            this.迁出信息BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 迁出信息BindingSource
            // 
            this.迁出信息BindingSource.DataMember = "迁出信息";
            this.迁出信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 迁出信息TableAdapter
            // 
            this.迁出信息TableAdapter.ClearBeforeFill = true;
            // 
            // 迁出信息BindingNavigator
            // 
            this.迁出信息BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.迁出信息BindingNavigator.BindingSource = this.迁出信息BindingSource;
            this.迁出信息BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.迁出信息BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.迁出信息BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.业主编号ToolStripLabel,
            this.业主编号ToolStripTextBox,
            this.查询ToolStripButton,
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
            this.迁出信息BindingNavigatorSaveItem});
            this.迁出信息BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.迁出信息BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.迁出信息BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.迁出信息BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.迁出信息BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.迁出信息BindingNavigator.Name = "迁出信息BindingNavigator";
            this.迁出信息BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.迁出信息BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.迁出信息BindingNavigator.TabIndex = 0;
            this.迁出信息BindingNavigator.Text = "bindingNavigator1";
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
            // 迁出信息BindingNavigatorSaveItem
            // 
            this.迁出信息BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("迁出信息BindingNavigatorSaveItem.Image")));
            this.迁出信息BindingNavigatorSaveItem.Name = "迁出信息BindingNavigatorSaveItem";
            this.迁出信息BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.迁出信息BindingNavigatorSaveItem.Text = "保存";
            this.迁出信息BindingNavigatorSaveItem.Click += new System.EventHandler(this.迁出信息BindingNavigatorSaveItem_Click);
            // 
            // 业主编号ToolStripLabel
            // 
            this.业主编号ToolStripLabel.Name = "业主编号ToolStripLabel";
            this.业主编号ToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.业主编号ToolStripLabel.Text = "业主编号:";
            // 
            // 业主编号ToolStripTextBox
            // 
            this.业主编号ToolStripTextBox.Name = "业主编号ToolStripTextBox";
            this.业主编号ToolStripTextBox.Size = new System.Drawing.Size(60, 25);
            this.业主编号ToolStripTextBox.Text = "%%";
            // 
            // 查询ToolStripButton
            // 
            this.查询ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripButton.Image")));
            this.查询ToolStripButton.Name = "查询ToolStripButton";
            this.查询ToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.查询ToolStripButton.Text = "查询";
            this.查询ToolStripButton.Click += new System.EventHandler(this.查询ToolStripButton_Click);
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(1, 34);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(59, 12);
            this.楼栋名称Label.TabIndex = 44;
            this.楼栋名称Label.Text = "楼栋名称:";
            // 
            // 迁出原因DataGridViewTextBoxColumn
            // 
            this.迁出原因DataGridViewTextBoxColumn.DataPropertyName = "迁出原因";
            this.迁出原因DataGridViewTextBoxColumn.HeaderText = "迁出原因";
            this.迁出原因DataGridViewTextBoxColumn.Name = "迁出原因DataGridViewTextBoxColumn";
            this.迁出原因DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 迁出日期DataGridViewTextBoxColumn
            // 
            this.迁出日期DataGridViewTextBoxColumn.DataPropertyName = "迁出日期";
            this.迁出日期DataGridViewTextBoxColumn.HeaderText = "迁出日期";
            this.迁出日期DataGridViewTextBoxColumn.Name = "迁出日期DataGridViewTextBoxColumn";
            this.迁出日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 补充说明DataGridViewTextBoxColumn
            // 
            this.补充说明DataGridViewTextBoxColumn.DataPropertyName = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.Name = "补充说明DataGridViewTextBoxColumn";
            this.补充说明DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 迁出信息DataGridView
            // 
            this.迁出信息DataGridView.AllowUserToAddRows = false;
            this.迁出信息DataGridView.AllowUserToDeleteRows = false;
            this.迁出信息DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.迁出信息DataGridView.AutoGenerateColumns = false;
            this.迁出信息DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.迁出信息DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.迁出信息DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.迁出信息DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.业主编号DataGridViewTextBoxColumn,
            this.业主姓名DataGridViewTextBoxColumn,
            this.迁出日期DataGridViewTextBoxColumn,
            this.迁出原因DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.迁出信息DataGridView.DataSource = this.迁出信息BindingSource;
            this.迁出信息DataGridView.Location = new System.Drawing.Point(1, 106);
            this.迁出信息DataGridView.MultiSelect = false;
            this.迁出信息DataGridView.Name = "迁出信息DataGridView";
            this.迁出信息DataGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.迁出信息DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.迁出信息DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Green;
            this.迁出信息DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.迁出信息DataGridView.RowTemplate.Height = 23;
            this.迁出信息DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.迁出信息DataGridView.Size = new System.Drawing.Size(541, 310);
            this.迁出信息DataGridView.TabIndex = 46;
            // 
            // 业主编号DataGridViewTextBoxColumn
            // 
            this.业主编号DataGridViewTextBoxColumn.DataPropertyName = "业主编号";
            this.业主编号DataGridViewTextBoxColumn.HeaderText = "业主编号";
            this.业主编号DataGridViewTextBoxColumn.Name = "业主编号DataGridViewTextBoxColumn";
            this.业主编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 业主姓名DataGridViewTextBoxColumn
            // 
            this.业主姓名DataGridViewTextBoxColumn.DataPropertyName = "业主姓名";
            this.业主姓名DataGridViewTextBoxColumn.HeaderText = "业主姓名";
            this.业主姓名DataGridViewTextBoxColumn.Name = "业主姓名DataGridViewTextBoxColumn";
            this.业主姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DataSource = this.楼栋信息BindingSource;
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(66, 29);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(87, 20);
            this.楼栋名称ComboBox.TabIndex = 45;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 业主编号Label
            // 
            业主编号Label.AutoSize = true;
            业主编号Label.Location = new System.Drawing.Point(303, 34);
            业主编号Label.Name = "业主编号Label";
            业主编号Label.Size = new System.Drawing.Size(59, 12);
            业主编号Label.TabIndex = 34;
            业主编号Label.Text = "业主编号:";
            // 
            // 业主姓名Label
            // 
            业主姓名Label.AutoSize = true;
            业主姓名Label.Location = new System.Drawing.Point(161, 34);
            业主姓名Label.Name = "业主姓名Label";
            业主姓名Label.Size = new System.Drawing.Size(59, 12);
            业主姓名Label.TabIndex = 36;
            业主姓名Label.Text = "业主姓名:";
            // 
            // 迁出日期Label
            // 
            迁出日期Label.AutoSize = true;
            迁出日期Label.Location = new System.Drawing.Point(0, 59);
            迁出日期Label.Name = "迁出日期Label";
            迁出日期Label.Size = new System.Drawing.Size(59, 12);
            迁出日期Label.TabIndex = 38;
            迁出日期Label.Text = "迁出日期:";
            // 
            // 迁出原因Label
            // 
            迁出原因Label.AutoSize = true;
            迁出原因Label.Location = new System.Drawing.Point(188, 59);
            迁出原因Label.Name = "迁出原因Label";
            迁出原因Label.Size = new System.Drawing.Size(59, 12);
            迁出原因Label.TabIndex = 40;
            迁出原因Label.Text = "迁出原因:";
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.迁出信息BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(65, 80);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(477, 21);
            this.补充说明TextBox.TabIndex = 43;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(0, 84);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(59, 12);
            补充说明Label.TabIndex = 42;
            补充说明Label.Text = "补充说明:";
            // 
            // 迁出原因TextBox
            // 
            this.迁出原因TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.迁出信息BindingSource, "迁出原因", true));
            this.迁出原因TextBox.Location = new System.Drawing.Point(253, 54);
            this.迁出原因TextBox.Name = "迁出原因TextBox";
            this.迁出原因TextBox.Size = new System.Drawing.Size(289, 21);
            this.迁出原因TextBox.TabIndex = 41;
            this.迁出原因TextBox.Text = "售房";
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.迁出信息BindingSource, "业主编号", true));
            this.业主编号TextBox.Location = new System.Drawing.Point(366, 28);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.ReadOnly = true;
            this.业主编号TextBox.Size = new System.Drawing.Size(176, 21);
            this.业主编号TextBox.TabIndex = 35;
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.迁出信息BindingSource, "业主姓名", true));
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(223, 29);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(74, 20);
            this.业主姓名ComboBox.TabIndex = 37;
            this.业主姓名ComboBox.SelectedIndexChanged += new System.EventHandler(this.业主姓名ComboBox_SelectedIndexChanged);
            // 
            // 迁出日期DateTimePicker
            // 
            this.迁出日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.迁出信息BindingSource, "迁出日期", true));
            this.迁出日期DateTimePicker.Location = new System.Drawing.Point(65, 54);
            this.迁出日期DateTimePicker.Name = "迁出日期DateTimePicker";
            this.迁出日期DateTimePicker.Size = new System.Drawing.Size(117, 21);
            this.迁出日期DateTimePicker.TabIndex = 39;
            // 
            // 楼栋信息BindingSource
            // 
            this.楼栋信息BindingSource.DataMember = "楼栋信息";
            this.楼栋信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 楼栋信息TableAdapter
            // 
            this.楼栋信息TableAdapter.ClearBeforeFill = true;
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.楼栋名称Label);
            this.Controls.Add(this.迁出信息DataGridView);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(业主编号Label);
            this.Controls.Add(业主姓名Label);
            this.Controls.Add(迁出日期Label);
            this.Controls.Add(迁出原因Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.迁出原因TextBox);
            this.Controls.Add(this.业主编号TextBox);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(this.迁出日期DateTimePicker);
            this.Controls.Add(this.迁出信息BindingNavigator);
            this.Name = "MoveForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本管理[业主迁出管理]";
            this.Load += new System.EventHandler(this.MoveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息BindingNavigator)).EndInit();
            this.迁出信息BindingNavigator.ResumeLayout(false);
            this.迁出信息BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 迁出信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.迁出信息TableAdapter 迁出信息TableAdapter;
        private System.Windows.Forms.BindingNavigator 迁出信息BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton 迁出信息BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 业主编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 业主编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.Label 楼栋名称Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn 迁出原因DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 迁出日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView 迁出信息DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.TextBox 迁出原因TextBox;
        private System.Windows.Forms.TextBox 业主编号TextBox;
        private System.Windows.Forms.ComboBox 业主姓名ComboBox;
        private System.Windows.Forms.DateTimePicker 迁出日期DateTimePicker;
        private System.Windows.Forms.BindingSource 楼栋信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter 楼栋信息TableAdapter;
    }
}