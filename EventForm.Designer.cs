namespace MyCommunity
{
    partial class EventForm
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
            System.Windows.Forms.Label 事件编号Label;
            System.Windows.Forms.Label 发生日期Label;
            System.Windows.Forms.Label 处理人员Label;
            System.Windows.Forms.Label 事件主题Label;
            System.Windows.Forms.Label 事件内容Label;
            System.Windows.Forms.Label 处理结果Label;
            System.Windows.Forms.Label 补充说明Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.突发事件BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.突发事件TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.突发事件TableAdapter();
            this.突发事件BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.事件编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.事件编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.突发事件BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.事件编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.突发事件DataGridView = new System.Windows.Forms.DataGridView();
            this.发生日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.事件主题DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.事件内容DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理结果DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.处理结果TextBox = new System.Windows.Forms.TextBox();
            this.事件编号TextBox = new System.Windows.Forms.TextBox();
            this.发生日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.处理人员TextBox = new System.Windows.Forms.TextBox();
            this.事件主题TextBox = new System.Windows.Forms.TextBox();
            this.事件内容TextBox = new System.Windows.Forms.TextBox();
            事件编号Label = new System.Windows.Forms.Label();
            发生日期Label = new System.Windows.Forms.Label();
            处理人员Label = new System.Windows.Forms.Label();
            事件主题Label = new System.Windows.Forms.Label();
            事件内容Label = new System.Windows.Forms.Label();
            处理结果Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件BindingNavigator)).BeginInit();
            this.突发事件BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 事件编号Label
            // 
            事件编号Label.AutoSize = true;
            事件编号Label.Location = new System.Drawing.Point(0, 29);
            事件编号Label.Name = "事件编号Label";
            事件编号Label.Size = new System.Drawing.Size(59, 12);
            事件编号Label.TabIndex = 38;
            事件编号Label.Text = "事件编号:";
            // 
            // 发生日期Label
            // 
            发生日期Label.AutoSize = true;
            发生日期Label.Location = new System.Drawing.Point(196, 29);
            发生日期Label.Name = "发生日期Label";
            发生日期Label.Size = new System.Drawing.Size(59, 12);
            发生日期Label.TabIndex = 40;
            发生日期Label.Text = "发生日期:";
            // 
            // 处理人员Label
            // 
            处理人员Label.AutoSize = true;
            处理人员Label.Location = new System.Drawing.Point(388, 29);
            处理人员Label.Name = "处理人员Label";
            处理人员Label.Size = new System.Drawing.Size(59, 12);
            处理人员Label.TabIndex = 42;
            处理人员Label.Text = "处理人员:";
            // 
            // 事件主题Label
            // 
            事件主题Label.AutoSize = true;
            事件主题Label.Location = new System.Drawing.Point(0, 54);
            事件主题Label.Name = "事件主题Label";
            事件主题Label.Size = new System.Drawing.Size(59, 12);
            事件主题Label.TabIndex = 44;
            事件主题Label.Text = "事件主题:";
            // 
            // 事件内容Label
            // 
            事件内容Label.AutoSize = true;
            事件内容Label.Location = new System.Drawing.Point(0, 79);
            事件内容Label.Name = "事件内容Label";
            事件内容Label.Size = new System.Drawing.Size(59, 12);
            事件内容Label.TabIndex = 46;
            事件内容Label.Text = "事件内容:";
            // 
            // 处理结果Label
            // 
            处理结果Label.AutoSize = true;
            处理结果Label.Location = new System.Drawing.Point(0, 104);
            处理结果Label.Name = "处理结果Label";
            处理结果Label.Size = new System.Drawing.Size(59, 12);
            处理结果Label.TabIndex = 48;
            处理结果Label.Text = "处理结果:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(0, 129);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(59, 12);
            补充说明Label.TabIndex = 50;
            补充说明Label.Text = "补充说明:";
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 突发事件BindingSource
            // 
            this.突发事件BindingSource.DataMember = "突发事件";
            this.突发事件BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 突发事件TableAdapter
            // 
            this.突发事件TableAdapter.ClearBeforeFill = true;
            // 
            // 突发事件BindingNavigator
            // 
            this.突发事件BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.突发事件BindingNavigator.BindingSource = this.突发事件BindingSource;
            this.突发事件BindingNavigator.CountItem = null;
            this.突发事件BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.突发事件BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.事件编号ToolStripLabel,
            this.事件编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.突发事件BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.突发事件BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.突发事件BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.突发事件BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.突发事件BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.突发事件BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.突发事件BindingNavigator.Name = "突发事件BindingNavigator";
            this.突发事件BindingNavigator.PositionItem = null;
            this.突发事件BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.突发事件BindingNavigator.TabIndex = 0;
            this.突发事件BindingNavigator.Text = "bindingNavigator1";
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
            // 事件编号ToolStripLabel
            // 
            this.事件编号ToolStripLabel.Name = "事件编号ToolStripLabel";
            this.事件编号ToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.事件编号ToolStripLabel.Text = "事件编号:";
            // 
            // 事件编号ToolStripTextBox
            // 
            this.事件编号ToolStripTextBox.Name = "事件编号ToolStripTextBox";
            this.事件编号ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.事件编号ToolStripTextBox.Text = "%%";
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
            // 突发事件BindingNavigatorSaveItem
            // 
            this.突发事件BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("突发事件BindingNavigatorSaveItem.Image")));
            this.突发事件BindingNavigatorSaveItem.Name = "突发事件BindingNavigatorSaveItem";
            this.突发事件BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.突发事件BindingNavigatorSaveItem.Text = "保存";
            this.突发事件BindingNavigatorSaveItem.Click += new System.EventHandler(this.突发事件BindingNavigatorSaveItem_Click);
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
            // 事件编号DataGridViewTextBoxColumn
            // 
            this.事件编号DataGridViewTextBoxColumn.DataPropertyName = "事件编号";
            this.事件编号DataGridViewTextBoxColumn.HeaderText = "事件编号";
            this.事件编号DataGridViewTextBoxColumn.Name = "事件编号DataGridViewTextBoxColumn";
            this.事件编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 突发事件DataGridView
            // 
            this.突发事件DataGridView.AllowUserToAddRows = false;
            this.突发事件DataGridView.AllowUserToDeleteRows = false;
            this.突发事件DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.突发事件DataGridView.AutoGenerateColumns = false;
            this.突发事件DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.突发事件DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.突发事件DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.突发事件DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.事件编号DataGridViewTextBoxColumn,
            this.发生日期DataGridViewTextBoxColumn,
            this.处理人员DataGridViewTextBoxColumn,
            this.事件主题DataGridViewTextBoxColumn,
            this.事件内容DataGridViewTextBoxColumn,
            this.处理结果DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.突发事件DataGridView.DataSource = this.突发事件BindingSource;
            this.突发事件DataGridView.Location = new System.Drawing.Point(1, 148);
            this.突发事件DataGridView.MultiSelect = false;
            this.突发事件DataGridView.Name = "突发事件DataGridView";
            this.突发事件DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.突发事件DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.突发事件DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.突发事件DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.突发事件DataGridView.RowTemplate.Height = 23;
            this.突发事件DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.突发事件DataGridView.Size = new System.Drawing.Size(541, 268);
            this.突发事件DataGridView.TabIndex = 52;
            // 
            // 发生日期DataGridViewTextBoxColumn
            // 
            this.发生日期DataGridViewTextBoxColumn.DataPropertyName = "发生日期";
            this.发生日期DataGridViewTextBoxColumn.HeaderText = "发生日期";
            this.发生日期DataGridViewTextBoxColumn.Name = "发生日期DataGridViewTextBoxColumn";
            this.发生日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 处理人员DataGridViewTextBoxColumn
            // 
            this.处理人员DataGridViewTextBoxColumn.DataPropertyName = "处理人员";
            this.处理人员DataGridViewTextBoxColumn.HeaderText = "处理人员";
            this.处理人员DataGridViewTextBoxColumn.Name = "处理人员DataGridViewTextBoxColumn";
            this.处理人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 事件主题DataGridViewTextBoxColumn
            // 
            this.事件主题DataGridViewTextBoxColumn.DataPropertyName = "事件主题";
            this.事件主题DataGridViewTextBoxColumn.HeaderText = "事件主题";
            this.事件主题DataGridViewTextBoxColumn.Name = "事件主题DataGridViewTextBoxColumn";
            this.事件主题DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 事件内容DataGridViewTextBoxColumn
            // 
            this.事件内容DataGridViewTextBoxColumn.DataPropertyName = "事件内容";
            this.事件内容DataGridViewTextBoxColumn.HeaderText = "事件内容";
            this.事件内容DataGridViewTextBoxColumn.Name = "事件内容DataGridViewTextBoxColumn";
            this.事件内容DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 处理结果DataGridViewTextBoxColumn
            // 
            this.处理结果DataGridViewTextBoxColumn.DataPropertyName = "处理结果";
            this.处理结果DataGridViewTextBoxColumn.HeaderText = "处理结果";
            this.处理结果DataGridViewTextBoxColumn.Name = "处理结果DataGridViewTextBoxColumn";
            this.处理结果DataGridViewTextBoxColumn.ReadOnly = true;
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
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.突发事件BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(60, 123);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(482, 21);
            this.补充说明TextBox.TabIndex = 51;
            // 
            // 处理结果TextBox
            // 
            this.处理结果TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.处理结果TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.突发事件BindingSource, "处理结果", true));
            this.处理结果TextBox.Location = new System.Drawing.Point(60, 98);
            this.处理结果TextBox.Name = "处理结果TextBox";
            this.处理结果TextBox.Size = new System.Drawing.Size(482, 21);
            this.处理结果TextBox.TabIndex = 49;
            // 
            // 事件编号TextBox
            // 
            this.事件编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.突发事件BindingSource, "事件编号", true));
            this.事件编号TextBox.Location = new System.Drawing.Point(60, 25);
            this.事件编号TextBox.Name = "事件编号TextBox";
            this.事件编号TextBox.Size = new System.Drawing.Size(133, 21);
            this.事件编号TextBox.TabIndex = 39;
            // 
            // 发生日期DateTimePicker
            // 
            this.发生日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.突发事件BindingSource, "发生日期", true));
            this.发生日期DateTimePicker.Location = new System.Drawing.Point(255, 25);
            this.发生日期DateTimePicker.Name = "发生日期DateTimePicker";
            this.发生日期DateTimePicker.Size = new System.Drawing.Size(129, 21);
            this.发生日期DateTimePicker.TabIndex = 41;
            // 
            // 处理人员TextBox
            // 
            this.处理人员TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.处理人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.突发事件BindingSource, "处理人员", true));
            this.处理人员TextBox.Location = new System.Drawing.Point(448, 25);
            this.处理人员TextBox.Name = "处理人员TextBox";
            this.处理人员TextBox.Size = new System.Drawing.Size(94, 21);
            this.处理人员TextBox.TabIndex = 43;
            // 
            // 事件主题TextBox
            // 
            this.事件主题TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.事件主题TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.突发事件BindingSource, "事件主题", true));
            this.事件主题TextBox.Location = new System.Drawing.Point(60, 50);
            this.事件主题TextBox.Name = "事件主题TextBox";
            this.事件主题TextBox.Size = new System.Drawing.Size(482, 21);
            this.事件主题TextBox.TabIndex = 45;
            // 
            // 事件内容TextBox
            // 
            this.事件内容TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.事件内容TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.突发事件BindingSource, "事件内容", true));
            this.事件内容TextBox.Location = new System.Drawing.Point(60, 74);
            this.事件内容TextBox.Name = "事件内容TextBox";
            this.事件内容TextBox.Size = new System.Drawing.Size(482, 21);
            this.事件内容TextBox.TabIndex = 47;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.突发事件DataGridView);
            this.Controls.Add(事件编号Label);
            this.Controls.Add(发生日期Label);
            this.Controls.Add(处理人员Label);
            this.Controls.Add(事件主题Label);
            this.Controls.Add(事件内容Label);
            this.Controls.Add(处理结果Label);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.处理结果TextBox);
            this.Controls.Add(this.事件编号TextBox);
            this.Controls.Add(this.发生日期DateTimePicker);
            this.Controls.Add(this.处理人员TextBox);
            this.Controls.Add(this.事件主题TextBox);
            this.Controls.Add(this.事件内容TextBox);
            this.Controls.Add(this.突发事件BindingNavigator);
            this.Name = "EventForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "物业管理[突发事件管理]";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件BindingNavigator)).EndInit();
            this.突发事件BindingNavigator.ResumeLayout(false);
            this.突发事件BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 突发事件BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.突发事件TableAdapter 突发事件TableAdapter;
        private System.Windows.Forms.BindingNavigator 突发事件BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 突发事件BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 事件编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 事件编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 事件编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView 突发事件DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发生日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 事件主题DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 事件内容DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理结果DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.TextBox 处理结果TextBox;
        private System.Windows.Forms.TextBox 事件编号TextBox;
        private System.Windows.Forms.DateTimePicker 发生日期DateTimePicker;
        private System.Windows.Forms.TextBox 处理人员TextBox;
        private System.Windows.Forms.TextBox 事件主题TextBox;
        private System.Windows.Forms.TextBox 事件内容TextBox;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
    }
}