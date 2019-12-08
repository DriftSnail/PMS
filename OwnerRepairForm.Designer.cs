namespace MyCommunity
{
    partial class OwnerRepairForm
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
            System.Windows.Forms.Label 维修编号Label;
            System.Windows.Forms.Label 楼栋名称Label;
            System.Windows.Forms.Label 业主编号Label;
            System.Windows.Forms.Label 业主姓名Label;
            System.Windows.Forms.Label 报修日期Label;
            System.Windows.Forms.Label 接待人员Label;
            System.Windows.Forms.Label 故障现象Label;
            System.Windows.Forms.Label 处理意见Label;
            System.Windows.Forms.Label 修理日期Label;
            System.Windows.Forms.Label 修理人员Label;
            System.Windows.Forms.Label 修理费用Label;
            System.Windows.Forms.Label 材料费用Label;
            System.Windows.Forms.Label 修理结果Label;
            System.Windows.Forms.Label 补充说明Label;
            System.Windows.Forms.Label 费用合计Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerRepairForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.业主维修BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.业主维修TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.业主维修TableAdapter();
            this.业主维修BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.维修编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.维修编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.业主维修BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.维修编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主维修DataGridView = new System.Windows.Forms.DataGridView();
            this.楼栋名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报修日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接待人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.故障现象DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理意见DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修理日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修理人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修理费用DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材料费用DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修理结果DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.修理结果TextBox = new System.Windows.Forms.TextBox();
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名ComboBox = new System.Windows.Forms.ComboBox();
            this.业主信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.报修日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.楼栋信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.维修编号TextBox = new System.Windows.Forms.TextBox();
            this.接待人员TextBox = new System.Windows.Forms.TextBox();
            this.故障现象TextBox = new System.Windows.Forms.TextBox();
            this.处理意见TextBox = new System.Windows.Forms.TextBox();
            this.修理日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.修理人员TextBox = new System.Windows.Forms.TextBox();
            this.修理费用TextBox = new System.Windows.Forms.TextBox();
            this.材料费用TextBox = new System.Windows.Forms.TextBox();
            this.费用合计TextBox = new System.Windows.Forms.TextBox();
            this.楼栋信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter();
            this.业主信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter();
            维修编号Label = new System.Windows.Forms.Label();
            楼栋名称Label = new System.Windows.Forms.Label();
            业主编号Label = new System.Windows.Forms.Label();
            业主姓名Label = new System.Windows.Forms.Label();
            报修日期Label = new System.Windows.Forms.Label();
            接待人员Label = new System.Windows.Forms.Label();
            故障现象Label = new System.Windows.Forms.Label();
            处理意见Label = new System.Windows.Forms.Label();
            修理日期Label = new System.Windows.Forms.Label();
            修理人员Label = new System.Windows.Forms.Label();
            修理费用Label = new System.Windows.Forms.Label();
            材料费用Label = new System.Windows.Forms.Label();
            修理结果Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            费用合计Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主维修BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主维修BindingNavigator)).BeginInit();
            this.业主维修BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.业主维修DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 维修编号Label
            // 
            维修编号Label.AutoSize = true;
            维修编号Label.Location = new System.Drawing.Point(2, 32);
            维修编号Label.Name = "维修编号Label";
            维修编号Label.Size = new System.Drawing.Size(59, 12);
            维修编号Label.TabIndex = 36;
            维修编号Label.Text = "维修编号:";
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(191, 32);
            楼栋名称Label.Name = "楼栋名称Label";
            楼栋名称Label.Size = new System.Drawing.Size(59, 12);
            楼栋名称Label.TabIndex = 38;
            楼栋名称Label.Text = "楼栋名称:";
            // 
            // 业主编号Label
            // 
            业主编号Label.AutoSize = true;
            业主编号Label.Location = new System.Drawing.Point(2, 56);
            业主编号Label.Name = "业主编号Label";
            业主编号Label.Size = new System.Drawing.Size(59, 12);
            业主编号Label.TabIndex = 40;
            业主编号Label.Text = "业主编号:";
            // 
            // 业主姓名Label
            // 
            业主姓名Label.AutoSize = true;
            业主姓名Label.Location = new System.Drawing.Point(379, 32);
            业主姓名Label.Name = "业主姓名Label";
            业主姓名Label.Size = new System.Drawing.Size(59, 12);
            业主姓名Label.TabIndex = 42;
            业主姓名Label.Text = "业主姓名:";
            // 
            // 报修日期Label
            // 
            报修日期Label.AutoSize = true;
            报修日期Label.Location = new System.Drawing.Point(191, 56);
            报修日期Label.Name = "报修日期Label";
            报修日期Label.Size = new System.Drawing.Size(59, 12);
            报修日期Label.TabIndex = 44;
            报修日期Label.Text = "报修日期:";
            // 
            // 接待人员Label
            // 
            接待人员Label.AutoSize = true;
            接待人员Label.Location = new System.Drawing.Point(379, 56);
            接待人员Label.Name = "接待人员Label";
            接待人员Label.Size = new System.Drawing.Size(59, 12);
            接待人员Label.TabIndex = 46;
            接待人员Label.Text = "接待人员:";
            // 
            // 故障现象Label
            // 
            故障现象Label.AutoSize = true;
            故障现象Label.Location = new System.Drawing.Point(2, 80);
            故障现象Label.Name = "故障现象Label";
            故障现象Label.Size = new System.Drawing.Size(59, 12);
            故障现象Label.TabIndex = 48;
            故障现象Label.Text = "故障现象:";
            // 
            // 处理意见Label
            // 
            处理意见Label.AutoSize = true;
            处理意见Label.Location = new System.Drawing.Point(2, 104);
            处理意见Label.Name = "处理意见Label";
            处理意见Label.Size = new System.Drawing.Size(59, 12);
            处理意见Label.TabIndex = 50;
            处理意见Label.Text = "处理意见:";
            // 
            // 修理日期Label
            // 
            修理日期Label.AutoSize = true;
            修理日期Label.Location = new System.Drawing.Point(357, 104);
            修理日期Label.Name = "修理日期Label";
            修理日期Label.Size = new System.Drawing.Size(59, 12);
            修理日期Label.TabIndex = 52;
            修理日期Label.Text = "修理日期:";
            // 
            // 修理人员Label
            // 
            修理人员Label.AutoSize = true;
            修理人员Label.Location = new System.Drawing.Point(2, 128);
            修理人员Label.Name = "修理人员Label";
            修理人员Label.Size = new System.Drawing.Size(59, 12);
            修理人员Label.TabIndex = 54;
            修理人员Label.Text = "修理人员:";
            // 
            // 修理费用Label
            // 
            修理费用Label.AutoSize = true;
            修理费用Label.Location = new System.Drawing.Point(117, 128);
            修理费用Label.Name = "修理费用Label";
            修理费用Label.Size = new System.Drawing.Size(83, 12);
            修理费用Label.TabIndex = 56;
            修理费用Label.Text = "修理费用(元):";
            // 
            // 材料费用Label
            // 
            材料费用Label.AutoSize = true;
            材料费用Label.Location = new System.Drawing.Point(260, 128);
            材料费用Label.Name = "材料费用Label";
            材料费用Label.Size = new System.Drawing.Size(83, 12);
            材料费用Label.TabIndex = 58;
            材料费用Label.Text = "材料费用(元):";
            // 
            // 修理结果Label
            // 
            修理结果Label.AutoSize = true;
            修理结果Label.Location = new System.Drawing.Point(2, 152);
            修理结果Label.Name = "修理结果Label";
            修理结果Label.Size = new System.Drawing.Size(59, 12);
            修理结果Label.TabIndex = 60;
            修理结果Label.Text = "修理结果:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(2, 176);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(59, 12);
            补充说明Label.TabIndex = 62;
            补充说明Label.Text = "补充说明:";
            // 
            // 费用合计Label
            // 
            费用合计Label.AutoSize = true;
            费用合计Label.Location = new System.Drawing.Point(393, 126);
            费用合计Label.Name = "费用合计Label";
            费用合计Label.Size = new System.Drawing.Size(83, 12);
            费用合计Label.TabIndex = 64;
            费用合计Label.Text = "费用合计(元):";
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 业主维修BindingSource
            // 
            this.业主维修BindingSource.DataMember = "业主维修";
            this.业主维修BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 业主维修TableAdapter
            // 
            this.业主维修TableAdapter.ClearBeforeFill = true;
            // 
            // 业主维修BindingNavigator
            // 
            this.业主维修BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.业主维修BindingNavigator.BindingSource = this.业主维修BindingSource;
            this.业主维修BindingNavigator.CountItem = null;
            this.业主维修BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.业主维修BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维修编号ToolStripLabel,
            this.维修编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.业主维修BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.业主维修BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.业主维修BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.业主维修BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.业主维修BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.业主维修BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.业主维修BindingNavigator.Name = "业主维修BindingNavigator";
            this.业主维修BindingNavigator.PositionItem = null;
            this.业主维修BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.业主维修BindingNavigator.TabIndex = 0;
            this.业主维修BindingNavigator.Text = "bindingNavigator1";
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
            // 维修编号ToolStripLabel
            // 
            this.维修编号ToolStripLabel.Name = "维修编号ToolStripLabel";
            this.维修编号ToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.维修编号ToolStripLabel.Text = "维修编号:";
            // 
            // 维修编号ToolStripTextBox
            // 
            this.维修编号ToolStripTextBox.Name = "维修编号ToolStripTextBox";
            this.维修编号ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.维修编号ToolStripTextBox.Text = "%%";
            // 
            // 查询ToolStripButton
            // 
            this.查询ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripButton.Image")));
            this.查询ToolStripButton.Name = "查询ToolStripButton";
            this.查询ToolStripButton.Size = new System.Drawing.Size(51, 22);
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
            // 业主维修BindingNavigatorSaveItem
            // 
            this.业主维修BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("业主维修BindingNavigatorSaveItem.Image")));
            this.业主维修BindingNavigatorSaveItem.Name = "业主维修BindingNavigatorSaveItem";
            this.业主维修BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.业主维修BindingNavigatorSaveItem.Text = "保存";
            this.业主维修BindingNavigatorSaveItem.Click += new System.EventHandler(this.业主维修BindingNavigatorSaveItem_Click);
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
            // 维修编号DataGridViewTextBoxColumn
            // 
            this.维修编号DataGridViewTextBoxColumn.DataPropertyName = "维修编号";
            this.维修编号DataGridViewTextBoxColumn.HeaderText = "维修编号";
            this.维修编号DataGridViewTextBoxColumn.Name = "维修编号DataGridViewTextBoxColumn";
            this.维修编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 业主维修DataGridView
            // 
            this.业主维修DataGridView.AllowUserToAddRows = false;
            this.业主维修DataGridView.AllowUserToDeleteRows = false;
            this.业主维修DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.业主维修DataGridView.AutoGenerateColumns = false;
            this.业主维修DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.业主维修DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.业主维修DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.业主维修DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.维修编号DataGridViewTextBoxColumn,
            this.楼栋名称DataGridViewTextBoxColumn,
            this.业主编号DataGridViewTextBoxColumn,
            this.业主姓名DataGridViewTextBoxColumn,
            this.报修日期DataGridViewTextBoxColumn,
            this.接待人员DataGridViewTextBoxColumn,
            this.故障现象DataGridViewTextBoxColumn,
            this.处理意见DataGridViewTextBoxColumn,
            this.修理日期DataGridViewTextBoxColumn,
            this.修理人员DataGridViewTextBoxColumn,
            this.修理费用DataGridViewTextBoxColumn,
            this.材料费用DataGridViewTextBoxColumn,
            this.修理结果DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.业主维修DataGridView.DataSource = this.业主维修BindingSource;
            this.业主维修DataGridView.Location = new System.Drawing.Point(1, 194);
            this.业主维修DataGridView.MultiSelect = false;
            this.业主维修DataGridView.Name = "业主维修DataGridView";
            this.业主维修DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.业主维修DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.业主维修DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.业主维修DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.业主维修DataGridView.RowTemplate.Height = 23;
            this.业主维修DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.业主维修DataGridView.Size = new System.Drawing.Size(541, 223);
            this.业主维修DataGridView.TabIndex = 64;
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
            // 报修日期DataGridViewTextBoxColumn
            // 
            this.报修日期DataGridViewTextBoxColumn.DataPropertyName = "报修日期";
            this.报修日期DataGridViewTextBoxColumn.HeaderText = "报修日期";
            this.报修日期DataGridViewTextBoxColumn.Name = "报修日期DataGridViewTextBoxColumn";
            this.报修日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 接待人员DataGridViewTextBoxColumn
            // 
            this.接待人员DataGridViewTextBoxColumn.DataPropertyName = "接待人员";
            this.接待人员DataGridViewTextBoxColumn.HeaderText = "接待人员";
            this.接待人员DataGridViewTextBoxColumn.Name = "接待人员DataGridViewTextBoxColumn";
            this.接待人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 故障现象DataGridViewTextBoxColumn
            // 
            this.故障现象DataGridViewTextBoxColumn.DataPropertyName = "故障现象";
            this.故障现象DataGridViewTextBoxColumn.HeaderText = "故障现象";
            this.故障现象DataGridViewTextBoxColumn.Name = "故障现象DataGridViewTextBoxColumn";
            this.故障现象DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 处理意见DataGridViewTextBoxColumn
            // 
            this.处理意见DataGridViewTextBoxColumn.DataPropertyName = "处理意见";
            this.处理意见DataGridViewTextBoxColumn.HeaderText = "处理意见";
            this.处理意见DataGridViewTextBoxColumn.Name = "处理意见DataGridViewTextBoxColumn";
            this.处理意见DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修理日期DataGridViewTextBoxColumn
            // 
            this.修理日期DataGridViewTextBoxColumn.DataPropertyName = "修理日期";
            this.修理日期DataGridViewTextBoxColumn.HeaderText = "修理日期";
            this.修理日期DataGridViewTextBoxColumn.Name = "修理日期DataGridViewTextBoxColumn";
            this.修理日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修理人员DataGridViewTextBoxColumn
            // 
            this.修理人员DataGridViewTextBoxColumn.DataPropertyName = "修理人员";
            this.修理人员DataGridViewTextBoxColumn.HeaderText = "修理人员";
            this.修理人员DataGridViewTextBoxColumn.Name = "修理人员DataGridViewTextBoxColumn";
            this.修理人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修理费用DataGridViewTextBoxColumn
            // 
            this.修理费用DataGridViewTextBoxColumn.DataPropertyName = "修理费用";
            this.修理费用DataGridViewTextBoxColumn.HeaderText = "修理费用";
            this.修理费用DataGridViewTextBoxColumn.Name = "修理费用DataGridViewTextBoxColumn";
            this.修理费用DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 材料费用DataGridViewTextBoxColumn
            // 
            this.材料费用DataGridViewTextBoxColumn.DataPropertyName = "材料费用";
            this.材料费用DataGridViewTextBoxColumn.HeaderText = "材料费用";
            this.材料费用DataGridViewTextBoxColumn.Name = "材料费用DataGridViewTextBoxColumn";
            this.材料费用DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修理结果DataGridViewTextBoxColumn
            // 
            this.修理结果DataGridViewTextBoxColumn.DataPropertyName = "修理结果";
            this.修理结果DataGridViewTextBoxColumn.HeaderText = "修理结果";
            this.修理结果DataGridViewTextBoxColumn.Name = "修理结果DataGridViewTextBoxColumn";
            this.修理结果DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 补充说明DataGridViewTextBoxColumn
            // 
            this.补充说明DataGridViewTextBoxColumn.DataPropertyName = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.Name = "补充说明DataGridViewTextBoxColumn";
            this.补充说明DataGridViewTextBoxColumn.ReadOnly = true;
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(62, 171);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(480, 21);
            this.补充说明TextBox.TabIndex = 14;
            // 
            // 修理结果TextBox
            // 
            this.修理结果TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "修理结果", true));
            this.修理结果TextBox.Location = new System.Drawing.Point(62, 147);
            this.修理结果TextBox.Name = "修理结果TextBox";
            this.修理结果TextBox.Size = new System.Drawing.Size(480, 21);
            this.修理结果TextBox.TabIndex = 13;
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "业主编号", true));
            this.业主编号TextBox.Location = new System.Drawing.Point(62, 51);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.ReadOnly = true;
            this.业主编号TextBox.Size = new System.Drawing.Size(121, 21);
            this.业主编号TextBox.TabIndex = 3;
            this.业主编号TextBox.TextChanged += new System.EventHandler(this.业主编号TextBox_TextChanged);
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "业主姓名", true));
            this.业主姓名ComboBox.DataSource = this.业主信息BindingSource;
            this.业主姓名ComboBox.DisplayMember = "业主姓名";
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(444, 28);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(98, 20);
            this.业主姓名ComboBox.TabIndex = 2;
            this.业主姓名ComboBox.ValueMember = "业主编号";
            this.业主姓名ComboBox.SelectedIndexChanged += new System.EventHandler(this.业主姓名ComboBox_SelectedIndexChanged);
            // 
            // 业主信息BindingSource
            // 
            this.业主信息BindingSource.DataMember = "业主信息";
            this.业主信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 报修日期DateTimePicker
            // 
            this.报修日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.业主维修BindingSource, "报修日期", true));
            this.报修日期DateTimePicker.Location = new System.Drawing.Point(251, 51);
            this.报修日期DateTimePicker.Name = "报修日期DateTimePicker";
            this.报修日期DateTimePicker.Size = new System.Drawing.Size(122, 21);
            this.报修日期DateTimePicker.TabIndex = 4;
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "楼栋名称", true));
            this.楼栋名称ComboBox.DataSource = this.楼栋信息BindingSource;
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(251, 28);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(122, 20);
            this.楼栋名称ComboBox.TabIndex = 1;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 楼栋信息BindingSource
            // 
            this.楼栋信息BindingSource.DataMember = "楼栋信息";
            this.楼栋信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 维修编号TextBox
            // 
            this.维修编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "维修编号", true));
            this.维修编号TextBox.Location = new System.Drawing.Point(62, 27);
            this.维修编号TextBox.Name = "维修编号TextBox";
            this.维修编号TextBox.Size = new System.Drawing.Size(121, 21);
            this.维修编号TextBox.TabIndex = 0;
            // 
            // 接待人员TextBox
            // 
            this.接待人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "接待人员", true));
            this.接待人员TextBox.Location = new System.Drawing.Point(444, 51);
            this.接待人员TextBox.Name = "接待人员TextBox";
            this.接待人员TextBox.Size = new System.Drawing.Size(98, 21);
            this.接待人员TextBox.TabIndex = 5;
            // 
            // 故障现象TextBox
            // 
            this.故障现象TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "故障现象", true));
            this.故障现象TextBox.Location = new System.Drawing.Point(62, 75);
            this.故障现象TextBox.Name = "故障现象TextBox";
            this.故障现象TextBox.Size = new System.Drawing.Size(480, 21);
            this.故障现象TextBox.TabIndex = 6;
            // 
            // 处理意见TextBox
            // 
            this.处理意见TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "处理意见", true));
            this.处理意见TextBox.Location = new System.Drawing.Point(62, 99);
            this.处理意见TextBox.Name = "处理意见TextBox";
            this.处理意见TextBox.Size = new System.Drawing.Size(289, 21);
            this.处理意见TextBox.TabIndex = 7;
            // 
            // 修理日期DateTimePicker
            // 
            this.修理日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.业主维修BindingSource, "修理日期", true));
            this.修理日期DateTimePicker.Location = new System.Drawing.Point(417, 99);
            this.修理日期DateTimePicker.Name = "修理日期DateTimePicker";
            this.修理日期DateTimePicker.Size = new System.Drawing.Size(125, 21);
            this.修理日期DateTimePicker.TabIndex = 8;
            // 
            // 修理人员TextBox
            // 
            this.修理人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "修理人员", true));
            this.修理人员TextBox.Location = new System.Drawing.Point(62, 123);
            this.修理人员TextBox.Name = "修理人员TextBox";
            this.修理人员TextBox.Size = new System.Drawing.Size(53, 21);
            this.修理人员TextBox.TabIndex = 9;
            // 
            // 修理费用TextBox
            // 
            this.修理费用TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "修理费用", true));
            this.修理费用TextBox.Location = new System.Drawing.Point(202, 123);
            this.修理费用TextBox.Name = "修理费用TextBox";
            this.修理费用TextBox.Size = new System.Drawing.Size(56, 21);
            this.修理费用TextBox.TabIndex = 10;
            // 
            // 材料费用TextBox
            // 
            this.材料费用TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "材料费用", true));
            this.材料费用TextBox.Location = new System.Drawing.Point(345, 123);
            this.材料费用TextBox.Name = "材料费用TextBox";
            this.材料费用TextBox.Size = new System.Drawing.Size(46, 21);
            this.材料费用TextBox.TabIndex = 11;
            // 
            // 费用合计TextBox
            // 
            this.费用合计TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.业主维修BindingSource, "费用合计", true));
            this.费用合计TextBox.Location = new System.Drawing.Point(478, 123);
            this.费用合计TextBox.Name = "费用合计TextBox";
            this.费用合计TextBox.Size = new System.Drawing.Size(64, 21);
            this.费用合计TextBox.TabIndex = 12;
            // 
            // 楼栋信息TableAdapter
            // 
            this.楼栋信息TableAdapter.ClearBeforeFill = true;
            // 
            // 业主信息TableAdapter
            // 
            this.业主信息TableAdapter.ClearBeforeFill = true;
            // 
            // OwnerRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(费用合计Label);
            this.Controls.Add(this.费用合计TextBox);
            this.Controls.Add(this.业主维修DataGridView);
            this.Controls.Add(维修编号Label);
            this.Controls.Add(楼栋名称Label);
            this.Controls.Add(业主编号Label);
            this.Controls.Add(业主姓名Label);
            this.Controls.Add(报修日期Label);
            this.Controls.Add(接待人员Label);
            this.Controls.Add(故障现象Label);
            this.Controls.Add(处理意见Label);
            this.Controls.Add(修理日期Label);
            this.Controls.Add(修理人员Label);
            this.Controls.Add(修理费用Label);
            this.Controls.Add(材料费用Label);
            this.Controls.Add(修理结果Label);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.修理结果TextBox);
            this.Controls.Add(this.业主编号TextBox);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(this.报修日期DateTimePicker);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.维修编号TextBox);
            this.Controls.Add(this.接待人员TextBox);
            this.Controls.Add(this.故障现象TextBox);
            this.Controls.Add(this.处理意见TextBox);
            this.Controls.Add(this.修理日期DateTimePicker);
            this.Controls.Add(this.修理人员TextBox);
            this.Controls.Add(this.修理费用TextBox);
            this.Controls.Add(this.材料费用TextBox);
            this.Controls.Add(this.业主维修BindingNavigator);
            this.Name = "OwnerRepairForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "物业管理[业主维修管理]";
            this.Load += new System.EventHandler(this.OwnerRepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主维修BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主维修BindingNavigator)).EndInit();
            this.业主维修BindingNavigator.ResumeLayout(false);
            this.业主维修BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.业主维修DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 业主维修BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.业主维修TableAdapter 业主维修TableAdapter;
        private System.Windows.Forms.BindingNavigator 业主维修BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 业主维修BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 维修编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 维修编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 维修编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView 业主维修DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼栋名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报修日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接待人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 故障现象DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理意见DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修理日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修理人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修理费用DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料费用DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修理结果DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.TextBox 修理结果TextBox;
        private System.Windows.Forms.TextBox 业主编号TextBox;
        private System.Windows.Forms.ComboBox 业主姓名ComboBox;
        private System.Windows.Forms.DateTimePicker 报修日期DateTimePicker;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.TextBox 维修编号TextBox;
        private System.Windows.Forms.TextBox 接待人员TextBox;
        private System.Windows.Forms.TextBox 故障现象TextBox;
        private System.Windows.Forms.TextBox 处理意见TextBox;
        private System.Windows.Forms.DateTimePicker 修理日期DateTimePicker;
        private System.Windows.Forms.TextBox 修理人员TextBox;
        private System.Windows.Forms.TextBox 修理费用TextBox;
        private System.Windows.Forms.TextBox 材料费用TextBox;
        private System.Windows.Forms.TextBox 费用合计TextBox;
        private System.Windows.Forms.BindingSource 楼栋信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter 楼栋信息TableAdapter;
        private System.Windows.Forms.BindingSource 业主信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter 业主信息TableAdapter;
    }
}