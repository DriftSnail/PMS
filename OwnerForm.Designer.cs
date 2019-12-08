namespace MyCommunity
{
    partial class OwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label 业主编号Label;
            System.Windows.Forms.Label 业主姓名Label;
            System.Windows.Forms.Label 身份证号码Label;
            System.Windows.Forms.Label 楼栋名称Label;
            System.Windows.Forms.Label 单元名称Label;
            System.Windows.Forms.Label 房号名称Label;
            System.Windows.Forms.Label 房屋性质Label;
            System.Windows.Forms.Label 房屋类型Label;
            System.Windows.Forms.Label 建筑面积Label;
            System.Windows.Forms.Label 套内面积Label;
            System.Windows.Forms.Label 常住人员Label;
            System.Windows.Forms.Label 联系电话Label;
            System.Windows.Forms.Label 入住日期Label;
            System.Windows.Forms.Label 当前状态Label;
            System.Windows.Forms.Label 补充说明Label;
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.业主信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.业主信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter();
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
            this.业主信息BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.业主信息BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.业主编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.业主编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.公共财产DataGridView = new System.Windows.Forms.DataGridView();
            this.业主编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼栋名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单元名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房号名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋性质DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋类型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑面积DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.套内面积DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.常住人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入住日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入住日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.当前状态ComboBox = new System.Windows.Forms.ComboBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名TextBox = new System.Windows.Forms.TextBox();
            this.身份证号码TextBox = new System.Windows.Forms.TextBox();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.单元名称TextBox = new System.Windows.Forms.TextBox();
            this.房号名称TextBox = new System.Windows.Forms.TextBox();
            this.房屋性质ComboBox = new System.Windows.Forms.ComboBox();
            this.房屋类型TextBox = new System.Windows.Forms.TextBox();
            this.建筑面积TextBox = new System.Windows.Forms.TextBox();
            this.套内面积TextBox = new System.Windows.Forms.TextBox();
            this.常住人员TextBox = new System.Windows.Forms.TextBox();
            this.联系电话TextBox = new System.Windows.Forms.TextBox();
            this.楼栋信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.楼栋信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter();
            业主编号Label = new System.Windows.Forms.Label();
            业主姓名Label = new System.Windows.Forms.Label();
            身份证号码Label = new System.Windows.Forms.Label();
            楼栋名称Label = new System.Windows.Forms.Label();
            单元名称Label = new System.Windows.Forms.Label();
            房号名称Label = new System.Windows.Forms.Label();
            房屋性质Label = new System.Windows.Forms.Label();
            房屋类型Label = new System.Windows.Forms.Label();
            建筑面积Label = new System.Windows.Forms.Label();
            套内面积Label = new System.Windows.Forms.Label();
            常住人员Label = new System.Windows.Forms.Label();
            联系电话Label = new System.Windows.Forms.Label();
            入住日期Label = new System.Windows.Forms.Label();
            当前状态Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingNavigator)).BeginInit();
            this.业主信息BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 业主信息BindingSource
            // 
            this.业主信息BindingSource.DataMember = "业主信息";
            this.业主信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 业主信息TableAdapter
            // 
            this.业主信息TableAdapter.ClearBeforeFill = true;
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
            // 业主信息BindingNavigatorSaveItem
            // 
            this.业主信息BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("业主信息BindingNavigatorSaveItem.Image")));
            this.业主信息BindingNavigatorSaveItem.Name = "业主信息BindingNavigatorSaveItem";
            this.业主信息BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 20);
            this.业主信息BindingNavigatorSaveItem.Text = "保存";
            this.业主信息BindingNavigatorSaveItem.Click += new System.EventHandler(this.业主信息BindingNavigatorSaveItem_Click);
            // 
            // 业主信息BindingNavigator
            // 
            this.业主信息BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.业主信息BindingNavigator.BindingSource = this.业主信息BindingSource;
            this.业主信息BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.业主信息BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.业主信息BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.业主信息BindingNavigatorSaveItem});
            this.业主信息BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.业主信息BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.业主信息BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.业主信息BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.业主信息BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.业主信息BindingNavigator.Name = "业主信息BindingNavigator";
            this.业主信息BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.业主信息BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.业主信息BindingNavigator.TabIndex = 0;
            this.业主信息BindingNavigator.Text = "bindingNavigator1";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共财产DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.公共财产DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.业主编号DataGridViewTextBoxColumn,
            this.业主姓名DataGridViewTextBoxColumn,
            this.身份证号码DataGridViewTextBoxColumn,
            this.楼栋名称DataGridViewTextBoxColumn,
            this.单元名称DataGridViewTextBoxColumn,
            this.房号名称DataGridViewTextBoxColumn,
            this.房屋性质DataGridViewTextBoxColumn,
            this.房屋类型DataGridViewTextBoxColumn,
            this.建筑面积DataGridViewTextBoxColumn,
            this.套内面积DataGridViewTextBoxColumn,
            this.常住人员DataGridViewTextBoxColumn,
            this.联系电话DataGridViewTextBoxColumn,
            this.入住日期DataGridViewTextBoxColumn,
            this.当前状态DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.公共财产DataGridView.DataSource = this.业主信息BindingSource;
            this.公共财产DataGridView.Location = new System.Drawing.Point(1, 153);
            this.公共财产DataGridView.MultiSelect = false;
            this.公共财产DataGridView.Name = "公共财产DataGridView";
            this.公共财产DataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共财产DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.公共财产DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green;
            this.公共财产DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.公共财产DataGridView.RowTemplate.Height = 23;
            this.公共财产DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.公共财产DataGridView.Size = new System.Drawing.Size(541, 263);
            this.公共财产DataGridView.TabIndex = 63;
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
            // 身份证号码DataGridViewTextBoxColumn
            // 
            this.身份证号码DataGridViewTextBoxColumn.DataPropertyName = "身份证号码";
            this.身份证号码DataGridViewTextBoxColumn.HeaderText = "身份证号码";
            this.身份证号码DataGridViewTextBoxColumn.Name = "身份证号码DataGridViewTextBoxColumn";
            this.身份证号码DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 楼栋名称DataGridViewTextBoxColumn
            // 
            this.楼栋名称DataGridViewTextBoxColumn.DataPropertyName = "楼栋名称";
            this.楼栋名称DataGridViewTextBoxColumn.HeaderText = "楼栋名称";
            this.楼栋名称DataGridViewTextBoxColumn.Name = "楼栋名称DataGridViewTextBoxColumn";
            this.楼栋名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 单元名称DataGridViewTextBoxColumn
            // 
            this.单元名称DataGridViewTextBoxColumn.DataPropertyName = "单元名称";
            this.单元名称DataGridViewTextBoxColumn.HeaderText = "单元名称";
            this.单元名称DataGridViewTextBoxColumn.Name = "单元名称DataGridViewTextBoxColumn";
            this.单元名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房号名称DataGridViewTextBoxColumn
            // 
            this.房号名称DataGridViewTextBoxColumn.DataPropertyName = "房号名称";
            this.房号名称DataGridViewTextBoxColumn.HeaderText = "房号名称";
            this.房号名称DataGridViewTextBoxColumn.Name = "房号名称DataGridViewTextBoxColumn";
            this.房号名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋性质DataGridViewTextBoxColumn
            // 
            this.房屋性质DataGridViewTextBoxColumn.DataPropertyName = "房屋性质";
            this.房屋性质DataGridViewTextBoxColumn.HeaderText = "房屋性质";
            this.房屋性质DataGridViewTextBoxColumn.Name = "房屋性质DataGridViewTextBoxColumn";
            this.房屋性质DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋类型DataGridViewTextBoxColumn
            // 
            this.房屋类型DataGridViewTextBoxColumn.DataPropertyName = "房屋类型";
            this.房屋类型DataGridViewTextBoxColumn.HeaderText = "房屋类型";
            this.房屋类型DataGridViewTextBoxColumn.Name = "房屋类型DataGridViewTextBoxColumn";
            this.房屋类型DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 建筑面积DataGridViewTextBoxColumn
            // 
            this.建筑面积DataGridViewTextBoxColumn.DataPropertyName = "建筑面积";
            this.建筑面积DataGridViewTextBoxColumn.HeaderText = "建筑面积";
            this.建筑面积DataGridViewTextBoxColumn.Name = "建筑面积DataGridViewTextBoxColumn";
            this.建筑面积DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 套内面积DataGridViewTextBoxColumn
            // 
            this.套内面积DataGridViewTextBoxColumn.DataPropertyName = "套内面积";
            this.套内面积DataGridViewTextBoxColumn.HeaderText = "套内面积";
            this.套内面积DataGridViewTextBoxColumn.Name = "套内面积DataGridViewTextBoxColumn";
            this.套内面积DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 常住人员DataGridViewTextBoxColumn
            // 
            this.常住人员DataGridViewTextBoxColumn.DataPropertyName = "常住人员";
            this.常住人员DataGridViewTextBoxColumn.HeaderText = "常住人员";
            this.常住人员DataGridViewTextBoxColumn.Name = "常住人员DataGridViewTextBoxColumn";
            this.常住人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 联系电话DataGridViewTextBoxColumn
            // 
            this.联系电话DataGridViewTextBoxColumn.DataPropertyName = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.Name = "联系电话DataGridViewTextBoxColumn";
            this.联系电话DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 入住日期DataGridViewTextBoxColumn
            // 
            this.入住日期DataGridViewTextBoxColumn.DataPropertyName = "入住日期";
            this.入住日期DataGridViewTextBoxColumn.HeaderText = "入住日期";
            this.入住日期DataGridViewTextBoxColumn.Name = "入住日期DataGridViewTextBoxColumn";
            this.入住日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 当前状态DataGridViewTextBoxColumn
            // 
            this.当前状态DataGridViewTextBoxColumn.DataPropertyName = "当前状态";
            this.当前状态DataGridViewTextBoxColumn.HeaderText = "当前状态";
            this.当前状态DataGridViewTextBoxColumn.Name = "当前状态DataGridViewTextBoxColumn";
            this.当前状态DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 补充说明DataGridViewTextBoxColumn
            // 
            this.补充说明DataGridViewTextBoxColumn.DataPropertyName = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.Name = "补充说明DataGridViewTextBoxColumn";
            this.补充说明DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 业主编号Label
            // 
            业主编号Label.AutoSize = true;
            业主编号Label.Location = new System.Drawing.Point(1, 33);
            业主编号Label.Name = "业主编号Label";
            业主编号Label.Size = new System.Drawing.Size(59, 12);
            业主编号Label.TabIndex = 33;
            业主编号Label.Text = "业主编号:";
            // 
            // 业主姓名Label
            // 
            业主姓名Label.AutoSize = true;
            业主姓名Label.Location = new System.Drawing.Point(161, 32);
            业主姓名Label.Name = "业主姓名Label";
            业主姓名Label.Size = new System.Drawing.Size(59, 12);
            业主姓名Label.TabIndex = 35;
            业主姓名Label.Text = "业主姓名:";
            // 
            // 身份证号码Label
            // 
            身份证号码Label.AutoSize = true;
            身份证号码Label.Location = new System.Drawing.Point(304, 32);
            身份证号码Label.Name = "身份证号码Label";
            身份证号码Label.Size = new System.Drawing.Size(71, 12);
            身份证号码Label.TabIndex = 37;
            身份证号码Label.Text = "身份证号码:";
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(1, 57);
            楼栋名称Label.Name = "楼栋名称Label";
            楼栋名称Label.Size = new System.Drawing.Size(59, 12);
            楼栋名称Label.TabIndex = 39;
            楼栋名称Label.Text = "楼栋名称:";
            // 
            // 单元名称Label
            // 
            单元名称Label.AutoSize = true;
            单元名称Label.Location = new System.Drawing.Point(141, 57);
            单元名称Label.Name = "单元名称Label";
            单元名称Label.Size = new System.Drawing.Size(59, 12);
            单元名称Label.TabIndex = 41;
            单元名称Label.Text = "单元名称:";
            // 
            // 房号名称Label
            // 
            房号名称Label.AutoSize = true;
            房号名称Label.Location = new System.Drawing.Point(259, 57);
            房号名称Label.Name = "房号名称Label";
            房号名称Label.Size = new System.Drawing.Size(59, 12);
            房号名称Label.TabIndex = 43;
            房号名称Label.Text = "房号名称:";
            // 
            // 房屋性质Label
            // 
            房屋性质Label.AutoSize = true;
            房屋性质Label.Location = new System.Drawing.Point(394, 57);
            房屋性质Label.Name = "房屋性质Label";
            房屋性质Label.Size = new System.Drawing.Size(59, 12);
            房屋性质Label.TabIndex = 45;
            房屋性质Label.Text = "房屋性质:";
            // 
            // 房屋类型Label
            // 
            房屋类型Label.AutoSize = true;
            房屋类型Label.Location = new System.Drawing.Point(1, 81);
            房屋类型Label.Name = "房屋类型Label";
            房屋类型Label.Size = new System.Drawing.Size(59, 12);
            房屋类型Label.TabIndex = 47;
            房屋类型Label.Text = "房屋类型:";
            // 
            // 建筑面积Label
            // 
            建筑面积Label.AutoSize = true;
            建筑面积Label.Location = new System.Drawing.Point(197, 81);
            建筑面积Label.Name = "建筑面积Label";
            建筑面积Label.Size = new System.Drawing.Size(83, 12);
            建筑面积Label.TabIndex = 49;
            建筑面积Label.Text = "建筑面积(m2):";
            // 
            // 套内面积Label
            // 
            套内面积Label.AutoSize = true;
            套内面积Label.Location = new System.Drawing.Point(361, 81);
            套内面积Label.Name = "套内面积Label";
            套内面积Label.Size = new System.Drawing.Size(83, 12);
            套内面积Label.TabIndex = 51;
            套内面积Label.Text = "套内面积(m2):";
            // 
            // 常住人员Label
            // 
            常住人员Label.AutoSize = true;
            常住人员Label.Location = new System.Drawing.Point(1, 105);
            常住人员Label.Name = "常住人员Label";
            常住人员Label.Size = new System.Drawing.Size(59, 12);
            常住人员Label.TabIndex = 53;
            常住人员Label.Text = "常住人员:";
            // 
            // 联系电话Label
            // 
            联系电话Label.AutoSize = true;
            联系电话Label.Location = new System.Drawing.Point(212, 106);
            联系电话Label.Name = "联系电话Label";
            联系电话Label.Size = new System.Drawing.Size(59, 12);
            联系电话Label.TabIndex = 55;
            联系电话Label.Text = "联系电话:";
            // 
            // 入住日期Label
            // 
            入住日期Label.AutoSize = true;
            入住日期Label.Location = new System.Drawing.Point(359, 106);
            入住日期Label.Name = "入住日期Label";
            入住日期Label.Size = new System.Drawing.Size(59, 12);
            入住日期Label.TabIndex = 57;
            入住日期Label.Text = "入住日期:";
            // 
            // 入住日期DateTimePicker
            // 
            this.入住日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.业主信息BindingSource, "入住日期", true));
            this.入住日期DateTimePicker.Location = new System.Drawing.Point(424, 101);
            this.入住日期DateTimePicker.Name = "入住日期DateTimePicker";
            this.入住日期DateTimePicker.Size = new System.Drawing.Size(118, 21);
            this.入住日期DateTimePicker.TabIndex = 58;
            // 
            // 当前状态Label
            // 
            当前状态Label.AutoSize = true;
            当前状态Label.Location = new System.Drawing.Point(1, 129);
            当前状态Label.Name = "当前状态Label";
            当前状态Label.Size = new System.Drawing.Size(59, 12);
            当前状态Label.TabIndex = 59;
            当前状态Label.Text = "当前状态:";
            // 
            // 当前状态ComboBox
            // 
            this.当前状态ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "当前状态", true));
            this.当前状态ComboBox.FormattingEnabled = true;
            this.当前状态ComboBox.Items.AddRange(new object[] {
            "已入住",
            "未入住",
            "其他"});
            this.当前状态ComboBox.Location = new System.Drawing.Point(61, 125);
            this.当前状态ComboBox.Name = "当前状态ComboBox";
            this.当前状态ComboBox.Size = new System.Drawing.Size(79, 20);
            this.当前状态ComboBox.TabIndex = 60;
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(144, 129);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(59, 12);
            补充说明Label.TabIndex = 61;
            补充说明Label.Text = "补充说明:";
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(203, 125);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(339, 21);
            this.补充说明TextBox.TabIndex = 62;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 业主姓名TextBox
            // 
            this.业主姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "业主姓名", true));
            this.业主姓名TextBox.Location = new System.Drawing.Point(221, 27);
            this.业主姓名TextBox.Name = "业主姓名TextBox";
            this.业主姓名TextBox.Size = new System.Drawing.Size(79, 21);
            this.业主姓名TextBox.TabIndex = 36;
            // 
            // 身份证号码TextBox
            // 
            this.身份证号码TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "身份证号码", true));
            this.身份证号码TextBox.Location = new System.Drawing.Point(377, 27);
            this.身份证号码TextBox.Name = "身份证号码TextBox";
            this.身份证号码TextBox.Size = new System.Drawing.Size(165, 21);
            this.身份证号码TextBox.TabIndex = 38;
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "楼栋名称", true));
            this.楼栋名称ComboBox.DataSource = this.楼栋信息BindingSource;
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(60, 52);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(79, 20);
            this.楼栋名称ComboBox.TabIndex = 40;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "业主编号", true));
            this.业主编号TextBox.Location = new System.Drawing.Point(61, 27);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.Size = new System.Drawing.Size(96, 21);
            this.业主编号TextBox.TabIndex = 34;
            // 
            // 单元名称TextBox
            // 
            this.单元名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "单元名称", true));
            this.单元名称TextBox.Location = new System.Drawing.Point(200, 51);
            this.单元名称TextBox.Name = "单元名称TextBox";
            this.单元名称TextBox.Size = new System.Drawing.Size(56, 21);
            this.单元名称TextBox.TabIndex = 42;
            // 
            // 房号名称TextBox
            // 
            this.房号名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "房号名称", true));
            this.房号名称TextBox.Location = new System.Drawing.Point(324, 51);
            this.房号名称TextBox.Name = "房号名称TextBox";
            this.房号名称TextBox.Size = new System.Drawing.Size(67, 21);
            this.房号名称TextBox.TabIndex = 44;
            // 
            // 房屋性质ComboBox
            // 
            this.房屋性质ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "房屋性质", true));
            this.房屋性质ComboBox.FormattingEnabled = true;
            this.房屋性质ComboBox.Items.AddRange(new object[] {
            "住宅",
            "商用",
            "其他"});
            this.房屋性质ComboBox.Location = new System.Drawing.Point(459, 52);
            this.房屋性质ComboBox.Name = "房屋性质ComboBox";
            this.房屋性质ComboBox.Size = new System.Drawing.Size(83, 20);
            this.房屋性质ComboBox.TabIndex = 46;
            // 
            // 房屋类型TextBox
            // 
            this.房屋类型TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "房屋类型", true));
            this.房屋类型TextBox.Location = new System.Drawing.Point(61, 76);
            this.房屋类型TextBox.Name = "房屋类型TextBox";
            this.房屋类型TextBox.Size = new System.Drawing.Size(131, 21);
            this.房屋类型TextBox.TabIndex = 48;
            // 
            // 建筑面积TextBox
            // 
            this.建筑面积TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "建筑面积", true));
            this.建筑面积TextBox.Location = new System.Drawing.Point(286, 76);
            this.建筑面积TextBox.Name = "建筑面积TextBox";
            this.建筑面积TextBox.Size = new System.Drawing.Size(71, 21);
            this.建筑面积TextBox.TabIndex = 50;
            // 
            // 套内面积TextBox
            // 
            this.套内面积TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "套内面积", true));
            this.套内面积TextBox.Location = new System.Drawing.Point(447, 76);
            this.套内面积TextBox.Name = "套内面积TextBox";
            this.套内面积TextBox.Size = new System.Drawing.Size(95, 21);
            this.套内面积TextBox.TabIndex = 52;
            // 
            // 常住人员TextBox
            // 
            this.常住人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "常住人员", true));
            this.常住人员TextBox.Location = new System.Drawing.Point(61, 101);
            this.常住人员TextBox.Name = "常住人员TextBox";
            this.常住人员TextBox.Size = new System.Drawing.Size(145, 21);
            this.常住人员TextBox.TabIndex = 54;
            // 
            // 联系电话TextBox
            // 
            this.联系电话TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主信息BindingSource, "联系电话", true));
            this.联系电话TextBox.Location = new System.Drawing.Point(277, 101);
            this.联系电话TextBox.Name = "联系电话TextBox";
            this.联系电话TextBox.Size = new System.Drawing.Size(80, 21);
            this.联系电话TextBox.TabIndex = 56;
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
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.公共财产DataGridView);
            this.Controls.Add(业主编号Label);
            this.Controls.Add(业主姓名Label);
            this.Controls.Add(身份证号码Label);
            this.Controls.Add(楼栋名称Label);
            this.Controls.Add(单元名称Label);
            this.Controls.Add(房号名称Label);
            this.Controls.Add(房屋性质Label);
            this.Controls.Add(房屋类型Label);
            this.Controls.Add(建筑面积Label);
            this.Controls.Add(套内面积Label);
            this.Controls.Add(常住人员Label);
            this.Controls.Add(联系电话Label);
            this.Controls.Add(入住日期Label);
            this.Controls.Add(this.入住日期DateTimePicker);
            this.Controls.Add(当前状态Label);
            this.Controls.Add(this.当前状态ComboBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.业主姓名TextBox);
            this.Controls.Add(this.身份证号码TextBox);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.业主编号TextBox);
            this.Controls.Add(this.单元名称TextBox);
            this.Controls.Add(this.房号名称TextBox);
            this.Controls.Add(this.房屋性质ComboBox);
            this.Controls.Add(this.房屋类型TextBox);
            this.Controls.Add(this.建筑面积TextBox);
            this.Controls.Add(this.套内面积TextBox);
            this.Controls.Add(this.常住人员TextBox);
            this.Controls.Add(this.联系电话TextBox);
            this.Controls.Add(this.业主信息BindingNavigator);
            this.Name = "OwnerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本管理[业主登记管理]";
            this.Load += new System.EventHandler(this.OwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingNavigator)).EndInit();
            this.业主信息BindingNavigator.ResumeLayout(false);
            this.业主信息BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 业主信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter 业主信息TableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 业主信息BindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator 业主信息BindingNavigator;
        private System.Windows.Forms.ToolStripLabel 业主编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 业主编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.DataGridView 公共财产DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼栋名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单元名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房号名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋性质DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋类型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑面积DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 套内面积DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 常住人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入住日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker 入住日期DateTimePicker;
        private System.Windows.Forms.ComboBox 当前状态ComboBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.TextBox 业主姓名TextBox;
        private System.Windows.Forms.TextBox 身份证号码TextBox;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.TextBox 业主编号TextBox;
        private System.Windows.Forms.TextBox 单元名称TextBox;
        private System.Windows.Forms.TextBox 房号名称TextBox;
        private System.Windows.Forms.ComboBox 房屋性质ComboBox;
        private System.Windows.Forms.TextBox 房屋类型TextBox;
        private System.Windows.Forms.TextBox 建筑面积TextBox;
        private System.Windows.Forms.TextBox 套内面积TextBox;
        private System.Windows.Forms.TextBox 常住人员TextBox;
        private System.Windows.Forms.TextBox 联系电话TextBox;
        private System.Windows.Forms.BindingSource 楼栋信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter 楼栋信息TableAdapter;
    }
}