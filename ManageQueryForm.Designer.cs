namespace MyCommunity
{
    partial class ManageQueryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageQueryForm));
            this.物管费用DataGridView = new System.Windows.Forms.DataGridView();
            this.打印Button = new System.Windows.Forms.Button();
            this.费用状态ComboBox = new System.Windows.Forms.ComboBox();
            this.费用状态Label = new System.Windows.Forms.Label();
            this.业主姓名ComboBox = new System.Windows.Forms.ComboBox();
            this.业主姓名Label = new System.Windows.Forms.Label();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            this.查询Button = new System.Windows.Forms.Button();
            this.计费月份ComboBox = new System.Windows.Forms.ComboBox();
            this.计费月份Label = new System.Windows.Forms.Label();
            this.计费年份ComboBox = new System.Windows.Forms.ComboBox();
            this.计费年份Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.物管费用DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 物管费用DataGridView
            // 
            this.物管费用DataGridView.AllowUserToAddRows = false;
            this.物管费用DataGridView.AllowUserToDeleteRows = false;
            this.物管费用DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.物管费用DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.物管费用DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.物管费用DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.物管费用DataGridView.Location = new System.Drawing.Point(1, 54);
            this.物管费用DataGridView.MultiSelect = false;
            this.物管费用DataGridView.Name = "物管费用DataGridView";
            this.物管费用DataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.物管费用DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.物管费用DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green;
            this.物管费用DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.物管费用DataGridView.RowTemplate.Height = 23;
            this.物管费用DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.物管费用DataGridView.Size = new System.Drawing.Size(541, 363);
            this.物管费用DataGridView.TabIndex = 62;
            // 
            // 打印Button
            // 
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(450, 26);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(80, 23);
            this.打印Button.TabIndex = 61;
            this.打印Button.Text = "打印";
            this.打印Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.打印Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.打印Button.UseVisualStyleBackColor = true;
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 费用状态ComboBox
            // 
            this.费用状态ComboBox.FormattingEnabled = true;
            this.费用状态ComboBox.Location = new System.Drawing.Point(235, 28);
            this.费用状态ComboBox.Name = "费用状态ComboBox";
            this.费用状态ComboBox.Size = new System.Drawing.Size(96, 20);
            this.费用状态ComboBox.TabIndex = 60;
            this.费用状态ComboBox.Text = "全部";
            // 
            // 费用状态Label
            // 
            this.费用状态Label.AutoSize = true;
            this.费用状态Label.Location = new System.Drawing.Point(167, 32);
            this.费用状态Label.Name = "费用状态Label";
            this.费用状态Label.Size = new System.Drawing.Size(65, 12);
            this.费用状态Label.TabIndex = 59;
            this.费用状态Label.Text = "费用状态：";
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(68, 28);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(93, 20);
            this.业主姓名ComboBox.TabIndex = 58;
            this.业主姓名ComboBox.Text = "全部";
            // 
            // 业主姓名Label
            // 
            this.业主姓名Label.AutoSize = true;
            this.业主姓名Label.Location = new System.Drawing.Point(0, 32);
            this.业主姓名Label.Name = "业主姓名Label";
            this.业主姓名Label.Size = new System.Drawing.Size(65, 12);
            this.业主姓名Label.TabIndex = 57;
            this.业主姓名Label.Text = "业主姓名：";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(403, 2);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(136, 20);
            this.楼栋名称ComboBox.TabIndex = 56;
            this.楼栋名称ComboBox.Text = "全部";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(337, 5);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(65, 12);
            this.楼栋名称Label.TabIndex = 55;
            this.楼栋名称Label.Text = "楼栋名称：";
            // 
            // 查询Button
            // 
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(350, 26);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(80, 23);
            this.查询Button.TabIndex = 54;
            this.查询Button.Text = "查询";
            this.查询Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.查询Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.查询Button.UseVisualStyleBackColor = true;
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 计费月份ComboBox
            // 
            this.计费月份ComboBox.FormattingEnabled = true;
            this.计费月份ComboBox.Location = new System.Drawing.Point(235, 2);
            this.计费月份ComboBox.Name = "计费月份ComboBox";
            this.计费月份ComboBox.Size = new System.Drawing.Size(96, 20);
            this.计费月份ComboBox.TabIndex = 53;
            this.计费月份ComboBox.Text = "全年";
            // 
            // 计费月份Label
            // 
            this.计费月份Label.AutoSize = true;
            this.计费月份Label.Location = new System.Drawing.Point(168, 7);
            this.计费月份Label.Name = "计费月份Label";
            this.计费月份Label.Size = new System.Drawing.Size(65, 12);
            this.计费月份Label.TabIndex = 52;
            this.计费月份Label.Text = "计费月份：";
            // 
            // 计费年份ComboBox
            // 
            this.计费年份ComboBox.FormattingEnabled = true;
            this.计费年份ComboBox.Location = new System.Drawing.Point(66, 2);
            this.计费年份ComboBox.Name = "计费年份ComboBox";
            this.计费年份ComboBox.Size = new System.Drawing.Size(95, 20);
            this.计费年份ComboBox.TabIndex = 51;
            this.计费年份ComboBox.Text = "2006";
            // 
            // 计费年份Label
            // 
            this.计费年份Label.AutoSize = true;
            this.计费年份Label.Location = new System.Drawing.Point(1, 7);
            this.计费年份Label.Name = "计费年份Label";
            this.计费年份Label.Size = new System.Drawing.Size(65, 12);
            this.计费年份Label.TabIndex = 50;
            this.计费年份Label.Text = "计费年份：";
            // 
            // ManageQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.物管费用DataGridView);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.费用状态ComboBox);
            this.Controls.Add(this.费用状态Label);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(this.业主姓名Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.楼栋名称Label);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.计费月份ComboBox);
            this.Controls.Add(this.计费月份Label);
            this.Controls.Add(this.计费年份ComboBox);
            this.Controls.Add(this.计费年份Label);
            this.Name = "ManageQueryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用管理[物管费用查询]";
            this.Load += new System.EventHandler(this.ManageQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.物管费用DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView 物管费用DataGridView;
        private System.Windows.Forms.Button 打印Button;
        private System.Windows.Forms.ComboBox 费用状态ComboBox;
        private System.Windows.Forms.Label 费用状态Label;
        private System.Windows.Forms.ComboBox 业主姓名ComboBox;
        private System.Windows.Forms.Label 业主姓名Label;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.Label 楼栋名称Label;
        private System.Windows.Forms.Button 查询Button;
        private System.Windows.Forms.ComboBox 计费月份ComboBox;
        private System.Windows.Forms.Label 计费月份Label;
        private System.Windows.Forms.ComboBox 计费年份ComboBox;
        private System.Windows.Forms.Label 计费年份Label;
    }
}