namespace MyCommunity
{
    partial class ComplainForm
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
            System.Windows.Forms.Label 投诉编号Label;
            System.Windows.Forms.Label 楼栋名称Label;
            System.Windows.Forms.Label 业主编号Label;
            System.Windows.Forms.Label 业主姓名Label;
            System.Windows.Forms.Label 投诉日期Label;
            System.Windows.Forms.Label 接待人员Label;
            System.Windows.Forms.Label 投诉主题Label;
            System.Windows.Forms.Label 投诉内容Label;
            System.Windows.Forms.Label 处理日期Label;
            System.Windows.Forms.Label 处理人员Label;
            System.Windows.Forms.Label 处理意见Label;
            System.Windows.Forms.Label 处理结果Label;
            System.Windows.Forms.Label 业主反馈Label;
            System.Windows.Forms.Label 补充说明Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.服务投诉BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.服务投诉TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.服务投诉TableAdapter();
            this.服务投诉BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.投诉编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.投诉编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.服务投诉BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.投诉编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.服务投诉DataGridView = new System.Windows.Forms.DataGridView();
            this.楼栋名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.投诉日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接待人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.投诉主题DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.投诉内容DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理意见DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理结果DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主反馈DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.业主反馈TextBox = new System.Windows.Forms.TextBox();
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名ComboBox = new System.Windows.Forms.ComboBox();
            this.业主信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.投诉日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.楼栋信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.投诉编号TextBox = new System.Windows.Forms.TextBox();
            this.接待人员TextBox = new System.Windows.Forms.TextBox();
            this.投诉主题TextBox = new System.Windows.Forms.TextBox();
            this.投诉内容TextBox = new System.Windows.Forms.TextBox();
            this.处理日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.处理人员TextBox = new System.Windows.Forms.TextBox();
            this.处理意见TextBox = new System.Windows.Forms.TextBox();
            this.处理结果TextBox = new System.Windows.Forms.TextBox();
            this.楼栋信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter();
            this.业主信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter();
            投诉编号Label = new System.Windows.Forms.Label();
            楼栋名称Label = new System.Windows.Forms.Label();
            业主编号Label = new System.Windows.Forms.Label();
            业主姓名Label = new System.Windows.Forms.Label();
            投诉日期Label = new System.Windows.Forms.Label();
            接待人员Label = new System.Windows.Forms.Label();
            投诉主题Label = new System.Windows.Forms.Label();
            投诉内容Label = new System.Windows.Forms.Label();
            处理日期Label = new System.Windows.Forms.Label();
            处理人员Label = new System.Windows.Forms.Label();
            处理意见Label = new System.Windows.Forms.Label();
            处理结果Label = new System.Windows.Forms.Label();
            业主反馈Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉BindingNavigator)).BeginInit();
            this.服务投诉BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 投诉编号Label
            // 
            投诉编号Label.AutoSize = true;
            投诉编号Label.Location = new System.Drawing.Point(1, 31);
            投诉编号Label.Name = "投诉编号Label";
            投诉编号Label.Size = new System.Drawing.Size(59, 12);
            投诉编号Label.TabIndex = 37;
            投诉编号Label.Text = "投诉编号:";
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(145, 31);
            楼栋名称Label.Name = "楼栋名称Label";
            楼栋名称Label.Size = new System.Drawing.Size(59, 12);
            楼栋名称Label.TabIndex = 39;
            楼栋名称Label.Text = "楼栋名称:";
            // 
            // 业主编号Label
            // 
            业主编号Label.AutoSize = true;
            业主编号Label.Location = new System.Drawing.Point(277, 31);
            业主编号Label.Name = "业主编号Label";
            业主编号Label.Size = new System.Drawing.Size(59, 12);
            业主编号Label.TabIndex = 41;
            业主编号Label.Text = "业主编号:";
            // 
            // 业主姓名Label
            // 
            业主姓名Label.AutoSize = true;
            业主姓名Label.Location = new System.Drawing.Point(398, 31);
            业主姓名Label.Name = "业主姓名Label";
            业主姓名Label.Size = new System.Drawing.Size(59, 12);
            业主姓名Label.TabIndex = 43;
            业主姓名Label.Text = "业主姓名:";
            // 
            // 投诉日期Label
            // 
            投诉日期Label.AutoSize = true;
            投诉日期Label.Location = new System.Drawing.Point(2, 56);
            投诉日期Label.Name = "投诉日期Label";
            投诉日期Label.Size = new System.Drawing.Size(59, 12);
            投诉日期Label.TabIndex = 45;
            投诉日期Label.Text = "投诉日期:";
            // 
            // 接待人员Label
            // 
            接待人员Label.AutoSize = true;
            接待人员Label.Location = new System.Drawing.Point(177, 56);
            接待人员Label.Name = "接待人员Label";
            接待人员Label.Size = new System.Drawing.Size(59, 12);
            接待人员Label.TabIndex = 47;
            接待人员Label.Text = "接待人员:";
            // 
            // 投诉主题Label
            // 
            投诉主题Label.AutoSize = true;
            投诉主题Label.Location = new System.Drawing.Point(300, 56);
            投诉主题Label.Name = "投诉主题Label";
            投诉主题Label.Size = new System.Drawing.Size(59, 12);
            投诉主题Label.TabIndex = 49;
            投诉主题Label.Text = "投诉主题:";
            // 
            // 投诉内容Label
            // 
            投诉内容Label.AutoSize = true;
            投诉内容Label.Location = new System.Drawing.Point(2, 79);
            投诉内容Label.Name = "投诉内容Label";
            投诉内容Label.Size = new System.Drawing.Size(59, 12);
            投诉内容Label.TabIndex = 51;
            投诉内容Label.Text = "投诉内容:";
            // 
            // 处理日期Label
            // 
            处理日期Label.AutoSize = true;
            处理日期Label.Location = new System.Drawing.Point(2, 104);
            处理日期Label.Name = "处理日期Label";
            处理日期Label.Size = new System.Drawing.Size(59, 12);
            处理日期Label.TabIndex = 53;
            处理日期Label.Text = "处理日期:";
            // 
            // 处理人员Label
            // 
            处理人员Label.AutoSize = true;
            处理人员Label.Location = new System.Drawing.Point(267, 104);
            处理人员Label.Name = "处理人员Label";
            处理人员Label.Size = new System.Drawing.Size(59, 12);
            处理人员Label.TabIndex = 55;
            处理人员Label.Text = "处理人员:";
            // 
            // 处理意见Label
            // 
            处理意见Label.AutoSize = true;
            处理意见Label.Location = new System.Drawing.Point(2, 128);
            处理意见Label.Name = "处理意见Label";
            处理意见Label.Size = new System.Drawing.Size(59, 12);
            处理意见Label.TabIndex = 57;
            处理意见Label.Text = "处理意见:";
            // 
            // 处理结果Label
            // 
            处理结果Label.AutoSize = true;
            处理结果Label.Location = new System.Drawing.Point(1, 152);
            处理结果Label.Name = "处理结果Label";
            处理结果Label.Size = new System.Drawing.Size(59, 12);
            处理结果Label.TabIndex = 59;
            处理结果Label.Text = "处理结果:";
            // 
            // 业主反馈Label
            // 
            业主反馈Label.AutoSize = true;
            业主反馈Label.Location = new System.Drawing.Point(1, 177);
            业主反馈Label.Name = "业主反馈Label";
            业主反馈Label.Size = new System.Drawing.Size(59, 12);
            业主反馈Label.TabIndex = 61;
            业主反馈Label.Text = "业主反馈:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(1, 202);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(59, 12);
            补充说明Label.TabIndex = 63;
            补充说明Label.Text = "补充说明:";
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 服务投诉BindingSource
            // 
            this.服务投诉BindingSource.DataMember = "服务投诉";
            this.服务投诉BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 服务投诉TableAdapter
            // 
            this.服务投诉TableAdapter.ClearBeforeFill = true;
            // 
            // 服务投诉BindingNavigator
            // 
            this.服务投诉BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.服务投诉BindingNavigator.BindingSource = this.服务投诉BindingSource;
            this.服务投诉BindingNavigator.CountItem = null;
            this.服务投诉BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.服务投诉BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.投诉编号ToolStripLabel,
            this.投诉编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.服务投诉BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.服务投诉BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.服务投诉BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.服务投诉BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.服务投诉BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.服务投诉BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.服务投诉BindingNavigator.Name = "服务投诉BindingNavigator";
            this.服务投诉BindingNavigator.PositionItem = null;
            this.服务投诉BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.服务投诉BindingNavigator.TabIndex = 0;
            this.服务投诉BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // 投诉编号ToolStripLabel
            // 
            this.投诉编号ToolStripLabel.Name = "投诉编号ToolStripLabel";
            this.投诉编号ToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.投诉编号ToolStripLabel.Text = "投诉编号:";
            // 
            // 投诉编号ToolStripTextBox
            // 
            this.投诉编号ToolStripTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.投诉编号ToolStripTextBox.Name = "投诉编号ToolStripTextBox";
            this.投诉编号ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.投诉编号ToolStripTextBox.Text = "%%";
            // 
            // 查询ToolStripButton
            // 
            this.查询ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripButton.Image")));
            this.查询ToolStripButton.Name = "查询ToolStripButton";
            this.查询ToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.查询ToolStripButton.Text = "查询";
            this.查询ToolStripButton.Click += new System.EventHandler(this.查询ToolStripButton_Click);
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
            // 服务投诉BindingNavigatorSaveItem
            // 
            this.服务投诉BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("服务投诉BindingNavigatorSaveItem.Image")));
            this.服务投诉BindingNavigatorSaveItem.Name = "服务投诉BindingNavigatorSaveItem";
            this.服务投诉BindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 22);
            this.服务投诉BindingNavigatorSaveItem.Text = "保存";
            this.服务投诉BindingNavigatorSaveItem.Click += new System.EventHandler(this.服务投诉BindingNavigatorSaveItem_Click);
            // 
            // 打印ToolStripButton
            // 
            this.打印ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打印ToolStripButton.Image")));
            this.打印ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印ToolStripButton.Name = "打印ToolStripButton";
            this.打印ToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.打印ToolStripButton.Text = "打印";
            this.打印ToolStripButton.Click += new System.EventHandler(this.打印ToolStripButton_Click);
            // 
            // 投诉编号DataGridViewTextBoxColumn
            // 
            this.投诉编号DataGridViewTextBoxColumn.DataPropertyName = "投诉编号";
            this.投诉编号DataGridViewTextBoxColumn.HeaderText = "投诉编号";
            this.投诉编号DataGridViewTextBoxColumn.Name = "投诉编号DataGridViewTextBoxColumn";
            this.投诉编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 服务投诉DataGridView
            // 
            this.服务投诉DataGridView.AllowUserToAddRows = false;
            this.服务投诉DataGridView.AllowUserToDeleteRows = false;
            this.服务投诉DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.服务投诉DataGridView.AutoGenerateColumns = false;
            this.服务投诉DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.服务投诉DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.服务投诉DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.服务投诉DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.投诉编号DataGridViewTextBoxColumn,
            this.楼栋名称DataGridViewTextBoxColumn,
            this.业主编号DataGridViewTextBoxColumn,
            this.业主姓名DataGridViewTextBoxColumn,
            this.投诉日期DataGridViewTextBoxColumn,
            this.接待人员DataGridViewTextBoxColumn,
            this.投诉主题DataGridViewTextBoxColumn,
            this.投诉内容DataGridViewTextBoxColumn,
            this.处理日期DataGridViewTextBoxColumn,
            this.处理人员DataGridViewTextBoxColumn,
            this.处理意见DataGridViewTextBoxColumn,
            this.处理结果DataGridViewTextBoxColumn,
            this.业主反馈DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.服务投诉DataGridView.DataSource = this.服务投诉BindingSource;
            this.服务投诉DataGridView.Location = new System.Drawing.Point(1, 223);
            this.服务投诉DataGridView.MultiSelect = false;
            this.服务投诉DataGridView.Name = "服务投诉DataGridView";
            this.服务投诉DataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.服务投诉DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.服务投诉DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Green;
            this.服务投诉DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.服务投诉DataGridView.RowTemplate.Height = 23;
            this.服务投诉DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.服务投诉DataGridView.Size = new System.Drawing.Size(541, 194);
            this.服务投诉DataGridView.TabIndex = 65;
            // 
            // 楼栋名称DataGridViewTextBoxColumn
            // 
            this.楼栋名称DataGridViewTextBoxColumn.DataPropertyName = "楼栋名称";
            this.楼栋名称DataGridViewTextBoxColumn.HeaderText = "楼栋名称";
            this.楼栋名称DataGridViewTextBoxColumn.Name = "楼栋名称DataGridViewTextBoxColumn";
            this.楼栋名称DataGridViewTextBoxColumn.ReadOnly = true;
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
            // 投诉日期DataGridViewTextBoxColumn
            // 
            this.投诉日期DataGridViewTextBoxColumn.DataPropertyName = "投诉日期";
            this.投诉日期DataGridViewTextBoxColumn.HeaderText = "投诉日期";
            this.投诉日期DataGridViewTextBoxColumn.Name = "投诉日期DataGridViewTextBoxColumn";
            this.投诉日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 接待人员DataGridViewTextBoxColumn
            // 
            this.接待人员DataGridViewTextBoxColumn.DataPropertyName = "接待人员";
            this.接待人员DataGridViewTextBoxColumn.HeaderText = "接待人员";
            this.接待人员DataGridViewTextBoxColumn.Name = "接待人员DataGridViewTextBoxColumn";
            this.接待人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 投诉主题DataGridViewTextBoxColumn
            // 
            this.投诉主题DataGridViewTextBoxColumn.DataPropertyName = "投诉主题";
            this.投诉主题DataGridViewTextBoxColumn.HeaderText = "投诉主题";
            this.投诉主题DataGridViewTextBoxColumn.Name = "投诉主题DataGridViewTextBoxColumn";
            this.投诉主题DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 投诉内容DataGridViewTextBoxColumn
            // 
            this.投诉内容DataGridViewTextBoxColumn.DataPropertyName = "投诉内容";
            this.投诉内容DataGridViewTextBoxColumn.HeaderText = "投诉内容";
            this.投诉内容DataGridViewTextBoxColumn.Name = "投诉内容DataGridViewTextBoxColumn";
            this.投诉内容DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 处理日期DataGridViewTextBoxColumn
            // 
            this.处理日期DataGridViewTextBoxColumn.DataPropertyName = "处理日期";
            this.处理日期DataGridViewTextBoxColumn.HeaderText = "处理日期";
            this.处理日期DataGridViewTextBoxColumn.Name = "处理日期DataGridViewTextBoxColumn";
            this.处理日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 处理人员DataGridViewTextBoxColumn
            // 
            this.处理人员DataGridViewTextBoxColumn.DataPropertyName = "处理人员";
            this.处理人员DataGridViewTextBoxColumn.HeaderText = "处理人员";
            this.处理人员DataGridViewTextBoxColumn.Name = "处理人员DataGridViewTextBoxColumn";
            this.处理人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 处理意见DataGridViewTextBoxColumn
            // 
            this.处理意见DataGridViewTextBoxColumn.DataPropertyName = "处理意见";
            this.处理意见DataGridViewTextBoxColumn.HeaderText = "处理意见";
            this.处理意见DataGridViewTextBoxColumn.Name = "处理意见DataGridViewTextBoxColumn";
            this.处理意见DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 处理结果DataGridViewTextBoxColumn
            // 
            this.处理结果DataGridViewTextBoxColumn.DataPropertyName = "处理结果";
            this.处理结果DataGridViewTextBoxColumn.HeaderText = "处理结果";
            this.处理结果DataGridViewTextBoxColumn.Name = "处理结果DataGridViewTextBoxColumn";
            this.处理结果DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 业主反馈DataGridViewTextBoxColumn
            // 
            this.业主反馈DataGridViewTextBoxColumn.DataPropertyName = "业主反馈";
            this.业主反馈DataGridViewTextBoxColumn.HeaderText = "业主反馈";
            this.业主反馈DataGridViewTextBoxColumn.Name = "业主反馈DataGridViewTextBoxColumn";
            this.业主反馈DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 补充说明DataGridViewTextBoxColumn
            // 
            this.补充说明DataGridViewTextBoxColumn.DataPropertyName = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.Name = "补充说明DataGridViewTextBoxColumn";
            this.补充说明DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(62, 199);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(480, 21);
            this.补充说明TextBox.TabIndex = 64;
            // 
            // 业主反馈TextBox
            // 
            this.业主反馈TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.业主反馈TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "业主反馈", true));
            this.业主反馈TextBox.Location = new System.Drawing.Point(62, 174);
            this.业主反馈TextBox.Name = "业主反馈TextBox";
            this.业主反馈TextBox.Size = new System.Drawing.Size(480, 21);
            this.业主反馈TextBox.TabIndex = 62;
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "业主编号", true));
            this.业主编号TextBox.Location = new System.Drawing.Point(336, 26);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.ReadOnly = true;
            this.业主编号TextBox.Size = new System.Drawing.Size(60, 21);
            this.业主编号TextBox.TabIndex = 42;
            this.业主编号TextBox.TextChanged += new System.EventHandler(this.业主编号TextBox_TextChanged);
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.业主姓名ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "业主姓名", true));
            this.业主姓名ComboBox.DataSource = this.业主信息BindingSource;
            this.业主姓名ComboBox.DisplayMember = "业主姓名";
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(457, 27);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(85, 20);
            this.业主姓名ComboBox.TabIndex = 44;
            this.业主姓名ComboBox.ValueMember = "业主编号";
            this.业主姓名ComboBox.SelectedIndexChanged += new System.EventHandler(this.业主姓名ComboBox_SelectedIndexChanged);
            // 
            // 业主信息BindingSource
            // 
            this.业主信息BindingSource.DataMember = "业主信息";
            this.业主信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 投诉日期DateTimePicker
            // 
            this.投诉日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.服务投诉BindingSource, "投诉日期", true));
            this.投诉日期DateTimePicker.Location = new System.Drawing.Point(62, 51);
            this.投诉日期DateTimePicker.Name = "投诉日期DateTimePicker";
            this.投诉日期DateTimePicker.Size = new System.Drawing.Size(112, 21);
            this.投诉日期DateTimePicker.TabIndex = 46;
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "楼栋名称", true));
            this.楼栋名称ComboBox.DataSource = this.楼栋信息BindingSource;
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(205, 27);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(71, 20);
            this.楼栋名称ComboBox.TabIndex = 40;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 楼栋信息BindingSource
            // 
            this.楼栋信息BindingSource.DataMember = "楼栋信息";
            this.楼栋信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 投诉编号TextBox
            // 
            this.投诉编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "投诉编号", true));
            this.投诉编号TextBox.Location = new System.Drawing.Point(62, 26);
            this.投诉编号TextBox.Name = "投诉编号TextBox";
            this.投诉编号TextBox.Size = new System.Drawing.Size(81, 21);
            this.投诉编号TextBox.TabIndex = 38;
            // 
            // 接待人员TextBox
            // 
            this.接待人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "接待人员", true));
            this.接待人员TextBox.Location = new System.Drawing.Point(236, 51);
            this.接待人员TextBox.Name = "接待人员TextBox";
            this.接待人员TextBox.Size = new System.Drawing.Size(59, 21);
            this.接待人员TextBox.TabIndex = 48;
            // 
            // 投诉主题TextBox
            // 
            this.投诉主题TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.投诉主题TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "投诉主题", true));
            this.投诉主题TextBox.Location = new System.Drawing.Point(362, 51);
            this.投诉主题TextBox.Name = "投诉主题TextBox";
            this.投诉主题TextBox.Size = new System.Drawing.Size(180, 21);
            this.投诉主题TextBox.TabIndex = 50;
            // 
            // 投诉内容TextBox
            // 
            this.投诉内容TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.投诉内容TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "投诉内容", true));
            this.投诉内容TextBox.Location = new System.Drawing.Point(62, 75);
            this.投诉内容TextBox.Name = "投诉内容TextBox";
            this.投诉内容TextBox.Size = new System.Drawing.Size(480, 21);
            this.投诉内容TextBox.TabIndex = 52;
            // 
            // 处理日期DateTimePicker
            // 
            this.处理日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.服务投诉BindingSource, "处理日期", true));
            this.处理日期DateTimePicker.Location = new System.Drawing.Point(62, 100);
            this.处理日期DateTimePicker.Name = "处理日期DateTimePicker";
            this.处理日期DateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.处理日期DateTimePicker.TabIndex = 54;
            // 
            // 处理人员TextBox
            // 
            this.处理人员TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.处理人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "处理人员", true));
            this.处理人员TextBox.Location = new System.Drawing.Point(332, 100);
            this.处理人员TextBox.Name = "处理人员TextBox";
            this.处理人员TextBox.Size = new System.Drawing.Size(210, 21);
            this.处理人员TextBox.TabIndex = 56;
            // 
            // 处理意见TextBox
            // 
            this.处理意见TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.处理意见TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "处理意见", true));
            this.处理意见TextBox.Location = new System.Drawing.Point(62, 124);
            this.处理意见TextBox.Name = "处理意见TextBox";
            this.处理意见TextBox.Size = new System.Drawing.Size(480, 21);
            this.处理意见TextBox.TabIndex = 58;
            // 
            // 处理结果TextBox
            // 
            this.处理结果TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.处理结果TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.服务投诉BindingSource, "处理结果", true));
            this.处理结果TextBox.Location = new System.Drawing.Point(62, 149);
            this.处理结果TextBox.Name = "处理结果TextBox";
            this.处理结果TextBox.Size = new System.Drawing.Size(480, 21);
            this.处理结果TextBox.TabIndex = 60;
            // 
            // 楼栋信息TableAdapter
            // 
            this.楼栋信息TableAdapter.ClearBeforeFill = true;
            // 
            // 业主信息TableAdapter
            // 
            this.业主信息TableAdapter.ClearBeforeFill = true;
            // 
            // ComplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.服务投诉DataGridView);
            this.Controls.Add(投诉编号Label);
            this.Controls.Add(楼栋名称Label);
            this.Controls.Add(业主编号Label);
            this.Controls.Add(业主姓名Label);
            this.Controls.Add(投诉日期Label);
            this.Controls.Add(接待人员Label);
            this.Controls.Add(投诉主题Label);
            this.Controls.Add(投诉内容Label);
            this.Controls.Add(处理日期Label);
            this.Controls.Add(处理人员Label);
            this.Controls.Add(处理意见Label);
            this.Controls.Add(处理结果Label);
            this.Controls.Add(业主反馈Label);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.业主反馈TextBox);
            this.Controls.Add(this.业主编号TextBox);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(this.投诉日期DateTimePicker);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.投诉编号TextBox);
            this.Controls.Add(this.接待人员TextBox);
            this.Controls.Add(this.投诉主题TextBox);
            this.Controls.Add(this.投诉内容TextBox);
            this.Controls.Add(this.处理日期DateTimePicker);
            this.Controls.Add(this.处理人员TextBox);
            this.Controls.Add(this.处理意见TextBox);
            this.Controls.Add(this.处理结果TextBox);
            this.Controls.Add(this.服务投诉BindingNavigator);
            this.Name = "ComplainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "物业管理[服务投诉管理]";
            this.Load += new System.EventHandler(this.ComplainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉BindingNavigator)).EndInit();
            this.服务投诉BindingNavigator.ResumeLayout(false);
            this.服务投诉BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 服务投诉BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.服务投诉TableAdapter 服务投诉TableAdapter;
        private System.Windows.Forms.BindingNavigator 服务投诉BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 服务投诉BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 投诉编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 投诉编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 投诉编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView 服务投诉DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼栋名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 投诉日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接待人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 投诉主题DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 投诉内容DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理意见DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理结果DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主反馈DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.TextBox 业主反馈TextBox;
        private System.Windows.Forms.TextBox 业主编号TextBox;
        private System.Windows.Forms.ComboBox 业主姓名ComboBox;
        private System.Windows.Forms.DateTimePicker 投诉日期DateTimePicker;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.TextBox 投诉编号TextBox;
        private System.Windows.Forms.TextBox 接待人员TextBox;
        private System.Windows.Forms.TextBox 投诉主题TextBox;
        private System.Windows.Forms.TextBox 投诉内容TextBox;
        private System.Windows.Forms.DateTimePicker 处理日期DateTimePicker;
        private System.Windows.Forms.TextBox 处理人员TextBox;
        private System.Windows.Forms.TextBox 处理意见TextBox;
        private System.Windows.Forms.TextBox 处理结果TextBox;
        private System.Windows.Forms.BindingSource 楼栋信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter 楼栋信息TableAdapter;
        private System.Windows.Forms.BindingSource 业主信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter 业主信息TableAdapter;
    }
}