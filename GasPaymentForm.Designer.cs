namespace MyCommunity
{
    partial class GasPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasPaymentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.移除Button = new System.Windows.Forms.Button();
            this.添加Button = new System.Windows.Forms.Button();
            this.明细DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.未交DataGridView = new System.Windows.Forms.DataGridView();
            this.查询Button = new System.Windows.Forms.Button();
            this.业主姓名ComboBox = new System.Windows.Forms.ComboBox();
            this.业主姓名Label = new System.Windows.Forms.Label();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            this.保存Button = new System.Windows.Forms.Button();
            this.打印Button = new System.Windows.Forms.Button();
            this.新增Button = new System.Windows.Forms.Button();
            this.补充说明Label = new System.Windows.Forms.Label();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.收款事由TextBox = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.收款事由Label = new System.Windows.Forms.Label();
            this.收款人员TextBox = new System.Windows.Forms.TextBox();
            this.收款人员Label = new System.Windows.Forms.Label();
            this.收款形式TextBox = new System.Windows.Forms.TextBox();
            this.收款形式Label = new System.Windows.Forms.Label();
            this.收款金额TextBox = new System.Windows.Forms.TextBox();
            this.收款金额Label = new System.Windows.Forms.Label();
            this.交款人员TextBox = new System.Windows.Forms.TextBox();
            this.交款人员Label = new System.Windows.Forms.Label();
            this.收款日期TextBox = new System.Windows.Forms.TextBox();
            this.收款日期Label = new System.Windows.Forms.Label();
            this.收据编号TextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.收据编号Label = new System.Windows.Forms.Label();
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.楼栋信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.楼栋信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.明细DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.未交DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 移除Button
            // 
            this.移除Button.Image = ((System.Drawing.Image)(resources.GetObject("移除Button.Image")));
            this.移除Button.Location = new System.Drawing.Point(460, 246);
            this.移除Button.Name = "移除Button";
            this.移除Button.Size = new System.Drawing.Size(80, 23);
            this.移除Button.TabIndex = 75;
            this.移除Button.Text = "移除";
            this.移除Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.移除Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.移除Button.UseVisualStyleBackColor = true;
            this.移除Button.Click += new System.EventHandler(this.移除Button_Click);
            // 
            // 添加Button
            // 
            this.添加Button.Image = ((System.Drawing.Image)(resources.GetObject("添加Button.Image")));
            this.添加Button.Location = new System.Drawing.Point(374, 246);
            this.添加Button.Name = "添加Button";
            this.添加Button.Size = new System.Drawing.Size(80, 23);
            this.添加Button.TabIndex = 74;
            this.添加Button.Text = "添加";
            this.添加Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.添加Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.添加Button.UseVisualStyleBackColor = true;
            this.添加Button.Click += new System.EventHandler(this.添加Button_Click);
            // 
            // 明细DataGridView
            // 
            this.明细DataGridView.AllowUserToAddRows = false;
            this.明细DataGridView.AllowUserToDeleteRows = false;
            this.明细DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.明细DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.明细DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.明细DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.明细DataGridView.Location = new System.Drawing.Point(2, 275);
            this.明细DataGridView.MultiSelect = false;
            this.明细DataGridView.Name = "明细DataGridView";
            this.明细DataGridView.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.明细DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.明细DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Green;
            this.明细DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.明细DataGridView.RowTemplate.Height = 23;
            this.明细DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.明细DataGridView.Size = new System.Drawing.Size(540, 142);
            this.明细DataGridView.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "未交费业主即将交纳的水电气费明细：";
            // 
            // 未交DataGridView
            // 
            this.未交DataGridView.AllowUserToAddRows = false;
            this.未交DataGridView.AllowUserToDeleteRows = false;
            this.未交DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.未交DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.未交DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.未交DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.未交DataGridView.Location = new System.Drawing.Point(2, 102);
            this.未交DataGridView.MultiSelect = false;
            this.未交DataGridView.Name = "未交DataGridView";
            this.未交DataGridView.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.未交DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.未交DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Green;
            this.未交DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.未交DataGridView.RowTemplate.Height = 23;
            this.未交DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.未交DataGridView.Size = new System.Drawing.Size(540, 139);
            this.未交DataGridView.TabIndex = 71;
            // 
            // 查询Button
            // 
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(461, 75);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(80, 23);
            this.查询Button.TabIndex = 70;
            this.查询Button.Text = "查询";
            this.查询Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.查询Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.查询Button.UseVisualStyleBackColor = true;
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(364, 77);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(93, 20);
            this.业主姓名ComboBox.TabIndex = 69;
            // 
            // 业主姓名Label
            // 
            this.业主姓名Label.AutoSize = true;
            this.业主姓名Label.Location = new System.Drawing.Point(300, 81);
            this.业主姓名Label.Name = "业主姓名Label";
            this.业主姓名Label.Size = new System.Drawing.Size(65, 12);
            this.业主姓名Label.TabIndex = 68;
            this.业主姓名Label.Text = "业主姓名：";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DataSource = this.楼栋信息BindingSource;
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(199, 77);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(95, 20);
            this.楼栋名称ComboBox.TabIndex = 67;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(2, 81);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(197, 12);
            this.楼栋名称Label.TabIndex = 66;
            this.楼栋名称Label.Text = "请选择未交费业主所在的楼栋名称：";
            // 
            // 保存Button
            // 
            this.保存Button.Image = ((System.Drawing.Image)(resources.GetObject("保存Button.Image")));
            this.保存Button.Location = new System.Drawing.Point(461, 51);
            this.保存Button.Name = "保存Button";
            this.保存Button.Size = new System.Drawing.Size(80, 23);
            this.保存Button.TabIndex = 65;
            this.保存Button.Text = "保存";
            this.保存Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.保存Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.保存Button.UseVisualStyleBackColor = true;
            this.保存Button.Click += new System.EventHandler(this.保存Button_Click);
            // 
            // 打印Button
            // 
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(377, 51);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(80, 23);
            this.打印Button.TabIndex = 64;
            this.打印Button.Text = "打印";
            this.打印Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.打印Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.打印Button.UseVisualStyleBackColor = true;
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 新增Button
            // 
            this.新增Button.Image = ((System.Drawing.Image)(resources.GetObject("新增Button.Image")));
            this.新增Button.Location = new System.Drawing.Point(293, 51);
            this.新增Button.Name = "新增Button";
            this.新增Button.Size = new System.Drawing.Size(80, 23);
            this.新增Button.TabIndex = 63;
            this.新增Button.Text = "新增";
            this.新增Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.新增Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.新增Button.UseVisualStyleBackColor = true;
            this.新增Button.Click += new System.EventHandler(this.新增Button_Click);
            // 
            // 补充说明Label
            // 
            this.补充说明Label.AutoSize = true;
            this.补充说明Label.Location = new System.Drawing.Point(3, 59);
            this.补充说明Label.Name = "补充说明Label";
            this.补充说明Label.Size = new System.Drawing.Size(65, 12);
            this.补充说明Label.TabIndex = 61;
            this.补充说明Label.Text = "补充说明：";
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Location = new System.Drawing.Point(70, 52);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(217, 21);
            this.补充说明TextBox.TabIndex = 62;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 收款事由TextBox
            // 
            this.收款事由TextBox.Location = new System.Drawing.Point(454, 28);
            this.收款事由TextBox.Name = "收款事由TextBox";
            this.收款事由TextBox.Size = new System.Drawing.Size(88, 21);
            this.收款事由TextBox.TabIndex = 60;
            this.收款事由TextBox.Text = "交水电气费";
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
            // 收款事由Label
            // 
            this.收款事由Label.AutoSize = true;
            this.收款事由Label.Location = new System.Drawing.Point(387, 34);
            this.收款事由Label.Name = "收款事由Label";
            this.收款事由Label.Size = new System.Drawing.Size(65, 12);
            this.收款事由Label.TabIndex = 59;
            this.收款事由Label.Text = "收款事由：";
            // 
            // 收款人员TextBox
            // 
            this.收款人员TextBox.Location = new System.Drawing.Point(326, 28);
            this.收款人员TextBox.Name = "收款人员TextBox";
            this.收款人员TextBox.Size = new System.Drawing.Size(57, 21);
            this.收款人员TextBox.TabIndex = 58;
            // 
            // 收款人员Label
            // 
            this.收款人员Label.AutoSize = true;
            this.收款人员Label.Location = new System.Drawing.Point(262, 34);
            this.收款人员Label.Name = "收款人员Label";
            this.收款人员Label.Size = new System.Drawing.Size(65, 12);
            this.收款人员Label.TabIndex = 57;
            this.收款人员Label.Text = "收款人员：";
            // 
            // 收款形式TextBox
            // 
            this.收款形式TextBox.Location = new System.Drawing.Point(199, 28);
            this.收款形式TextBox.Name = "收款形式TextBox";
            this.收款形式TextBox.Size = new System.Drawing.Size(57, 21);
            this.收款形式TextBox.TabIndex = 56;
            this.收款形式TextBox.Text = "现金";
            // 
            // 收款形式Label
            // 
            this.收款形式Label.AutoSize = true;
            this.收款形式Label.Location = new System.Drawing.Point(132, 33);
            this.收款形式Label.Name = "收款形式Label";
            this.收款形式Label.Size = new System.Drawing.Size(65, 12);
            this.收款形式Label.TabIndex = 55;
            this.收款形式Label.Text = "收款形式：";
            // 
            // 收款金额TextBox
            // 
            this.收款金额TextBox.Location = new System.Drawing.Point(70, 28);
            this.收款金额TextBox.Name = "收款金额TextBox";
            this.收款金额TextBox.ReadOnly = true;
            this.收款金额TextBox.Size = new System.Drawing.Size(57, 21);
            this.收款金额TextBox.TabIndex = 54;
            // 
            // 收款金额Label
            // 
            this.收款金额Label.AutoSize = true;
            this.收款金额Label.Location = new System.Drawing.Point(3, 34);
            this.收款金额Label.Name = "收款金额Label";
            this.收款金额Label.Size = new System.Drawing.Size(65, 12);
            this.收款金额Label.TabIndex = 53;
            this.收款金额Label.Text = "收款金额：";
            // 
            // 交款人员TextBox
            // 
            this.交款人员TextBox.Location = new System.Drawing.Point(476, 4);
            this.交款人员TextBox.Name = "交款人员TextBox";
            this.交款人员TextBox.Size = new System.Drawing.Size(66, 21);
            this.交款人员TextBox.TabIndex = 52;
            // 
            // 交款人员Label
            // 
            this.交款人员Label.AutoSize = true;
            this.交款人员Label.Location = new System.Drawing.Point(410, 8);
            this.交款人员Label.Name = "交款人员Label";
            this.交款人员Label.Size = new System.Drawing.Size(65, 12);
            this.交款人员Label.TabIndex = 51;
            this.交款人员Label.Text = "交款人员：";
            // 
            // 收款日期TextBox
            // 
            this.收款日期TextBox.Location = new System.Drawing.Point(338, 4);
            this.收款日期TextBox.Name = "收款日期TextBox";
            this.收款日期TextBox.Size = new System.Drawing.Size(66, 21);
            this.收款日期TextBox.TabIndex = 50;
            this.收款日期TextBox.Text = "2006-6-1";
            // 
            // 收款日期Label
            // 
            this.收款日期Label.AutoSize = true;
            this.收款日期Label.Location = new System.Drawing.Point(275, 8);
            this.收款日期Label.Name = "收款日期Label";
            this.收款日期Label.Size = new System.Drawing.Size(65, 12);
            this.收款日期Label.TabIndex = 49;
            this.收款日期Label.Text = "收款日期：";
            // 
            // 收据编号TextBox
            // 
            this.收据编号TextBox.Location = new System.Drawing.Point(70, 4);
            this.收据编号TextBox.Name = "收据编号TextBox";
            this.收据编号TextBox.Size = new System.Drawing.Size(203, 21);
            this.收据编号TextBox.TabIndex = 48;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // 收据编号Label
            // 
            this.收据编号Label.AutoSize = true;
            this.收据编号Label.Location = new System.Drawing.Point(3, 9);
            this.收据编号Label.Name = "收据编号Label";
            this.收据编号Label.Size = new System.Drawing.Size(65, 12);
            this.收据编号Label.TabIndex = 47;
            this.收据编号Label.Text = "收据编号：";
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // GasPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.移除Button);
            this.Controls.Add(this.添加Button);
            this.Controls.Add(this.明细DataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.未交DataGridView);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(this.业主姓名Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.楼栋名称Label);
            this.Controls.Add(this.保存Button);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.新增Button);
            this.Controls.Add(this.补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.收款事由TextBox);
            this.Controls.Add(this.收款事由Label);
            this.Controls.Add(this.收款人员TextBox);
            this.Controls.Add(this.收款人员Label);
            this.Controls.Add(this.收款形式TextBox);
            this.Controls.Add(this.收款形式Label);
            this.Controls.Add(this.收款金额TextBox);
            this.Controls.Add(this.收款金额Label);
            this.Controls.Add(this.交款人员TextBox);
            this.Controls.Add(this.交款人员Label);
            this.Controls.Add(this.收款日期TextBox);
            this.Controls.Add(this.收款日期Label);
            this.Controls.Add(this.收据编号TextBox);
            this.Controls.Add(this.收据编号Label);
            this.Name = "GasPaymentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用管理[水电气费交纳]";
            this.Load += new System.EventHandler(this.GasPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.明细DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.未交DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 移除Button;
        private System.Windows.Forms.Button 添加Button;
        private System.Windows.Forms.DataGridView 明细DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView 未交DataGridView;
        private System.Windows.Forms.Button 查询Button;
        private System.Windows.Forms.ComboBox 业主姓名ComboBox;
        private System.Windows.Forms.Label 业主姓名Label;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.Label 楼栋名称Label;
        private System.Windows.Forms.Button 保存Button;
        private System.Windows.Forms.Button 打印Button;
        private System.Windows.Forms.Button 新增Button;
        private System.Windows.Forms.Label 补充说明Label;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.TextBox 收款事由TextBox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label 收款事由Label;
        private System.Windows.Forms.TextBox 收款人员TextBox;
        private System.Windows.Forms.Label 收款人员Label;
        private System.Windows.Forms.TextBox 收款形式TextBox;
        private System.Windows.Forms.Label 收款形式Label;
        private System.Windows.Forms.TextBox 收款金额TextBox;
        private System.Windows.Forms.Label 收款金额Label;
        private System.Windows.Forms.TextBox 交款人员TextBox;
        private System.Windows.Forms.Label 交款人员Label;
        private System.Windows.Forms.TextBox 收款日期TextBox;
        private System.Windows.Forms.Label 收款日期Label;
        private System.Windows.Forms.TextBox 收据编号TextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label 收据编号Label;
        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 楼栋信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter 楼栋信息TableAdapter;
    }
}