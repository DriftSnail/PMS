namespace MyCommunity
{
    partial class ReportOwnerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOwnerForm));
            this.常住人员TextBox = new System.Windows.Forms.TextBox();
            this.房屋类型TextBox = new System.Windows.Forms.TextBox();
            this.单元名称TextBox = new System.Windows.Forms.TextBox();
            this.业主报表DataGridView = new System.Windows.Forms.DataGridView();
            this.打印Button = new System.Windows.Forms.Button();
            this.当前状态ComboBox = new System.Windows.Forms.ComboBox();
            this.当前状态Label = new System.Windows.Forms.Label();
            this.常住人员Label = new System.Windows.Forms.Label();
            this.房屋类型Label = new System.Windows.Forms.Label();
            this.查询Button = new System.Windows.Forms.Button();
            this.房屋性质ComboBox = new System.Windows.Forms.ComboBox();
            this.费用类型Label = new System.Windows.Forms.Label();
            this.单元名称Label = new System.Windows.Forms.Label();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.业主报表DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 常住人员TextBox
            // 
            this.常住人员TextBox.Location = new System.Drawing.Point(220, 30);
            this.常住人员TextBox.Name = "常住人员TextBox";
            this.常住人员TextBox.Size = new System.Drawing.Size(76, 21);
            this.常住人员TextBox.TabIndex = 67;
            // 
            // 房屋类型TextBox
            // 
            this.房屋类型TextBox.Location = new System.Drawing.Point(65, 30);
            this.房屋类型TextBox.Name = "房屋类型TextBox";
            this.房屋类型TextBox.Size = new System.Drawing.Size(76, 21);
            this.房屋类型TextBox.TabIndex = 66;
            // 
            // 单元名称TextBox
            // 
            this.单元名称TextBox.Location = new System.Drawing.Point(221, 3);
            this.单元名称TextBox.Name = "单元名称TextBox";
            this.单元名称TextBox.Size = new System.Drawing.Size(76, 21);
            this.单元名称TextBox.TabIndex = 65;
            // 
            // 业主报表DataGridView
            // 
            this.业主报表DataGridView.AllowUserToAddRows = false;
            this.业主报表DataGridView.AllowUserToDeleteRows = false;
            this.业主报表DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.业主报表DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.业主报表DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.业主报表DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.业主报表DataGridView.Location = new System.Drawing.Point(0, 56);
            this.业主报表DataGridView.MultiSelect = false;
            this.业主报表DataGridView.Name = "业主报表DataGridView";
            this.业主报表DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.业主报表DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.业主报表DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.业主报表DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.业主报表DataGridView.RowTemplate.Height = 23;
            this.业主报表DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.业主报表DataGridView.Size = new System.Drawing.Size(541, 361);
            this.业主报表DataGridView.TabIndex = 64;
            // 
            // 打印Button
            // 
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(472, 28);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(67, 23);
            this.打印Button.TabIndex = 63;
            this.打印Button.Text = "打印";
            this.打印Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.打印Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.打印Button.UseVisualStyleBackColor = true;
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 当前状态ComboBox
            // 
            this.当前状态ComboBox.FormattingEnabled = true;
            this.当前状态ComboBox.Location = new System.Drawing.Point(370, 31);
            this.当前状态ComboBox.Name = "当前状态ComboBox";
            this.当前状态ComboBox.Size = new System.Drawing.Size(96, 20);
            this.当前状态ComboBox.TabIndex = 62;
            this.当前状态ComboBox.Text = "全部";
            // 
            // 当前状态Label
            // 
            this.当前状态Label.AutoSize = true;
            this.当前状态Label.Location = new System.Drawing.Point(302, 34);
            this.当前状态Label.Name = "当前状态Label";
            this.当前状态Label.Size = new System.Drawing.Size(65, 12);
            this.当前状态Label.TabIndex = 61;
            this.当前状态Label.Text = "当前状态：";
            // 
            // 常住人员Label
            // 
            this.常住人员Label.AutoSize = true;
            this.常住人员Label.Location = new System.Drawing.Point(153, 34);
            this.常住人员Label.Name = "常住人员Label";
            this.常住人员Label.Size = new System.Drawing.Size(65, 12);
            this.常住人员Label.TabIndex = 60;
            this.常住人员Label.Text = "常住人员：";
            // 
            // 房屋类型Label
            // 
            this.房屋类型Label.AutoSize = true;
            this.房屋类型Label.Location = new System.Drawing.Point(-1, 34);
            this.房屋类型Label.Name = "房屋类型Label";
            this.房屋类型Label.Size = new System.Drawing.Size(65, 12);
            this.房屋类型Label.TabIndex = 59;
            this.房屋类型Label.Text = "房屋类型：";
            // 
            // 查询Button
            // 
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(472, 2);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(67, 23);
            this.查询Button.TabIndex = 58;
            this.查询Button.Text = "查询";
            this.查询Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.查询Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.查询Button.UseVisualStyleBackColor = true;
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 房屋性质ComboBox
            // 
            this.房屋性质ComboBox.FormattingEnabled = true;
            this.房屋性质ComboBox.Location = new System.Drawing.Point(371, 4);
            this.房屋性质ComboBox.Name = "房屋性质ComboBox";
            this.房屋性质ComboBox.Size = new System.Drawing.Size(95, 20);
            this.房屋性质ComboBox.TabIndex = 57;
            this.房屋性质ComboBox.Text = "全部";
            // 
            // 费用类型Label
            // 
            this.费用类型Label.AutoSize = true;
            this.费用类型Label.Location = new System.Drawing.Point(303, 9);
            this.费用类型Label.Name = "费用类型Label";
            this.费用类型Label.Size = new System.Drawing.Size(65, 12);
            this.费用类型Label.TabIndex = 56;
            this.费用类型Label.Text = "房屋性质：";
            // 
            // 单元名称Label
            // 
            this.单元名称Label.AutoSize = true;
            this.单元名称Label.Location = new System.Drawing.Point(154, 9);
            this.单元名称Label.Name = "单元名称Label";
            this.单元名称Label.Size = new System.Drawing.Size(65, 12);
            this.单元名称Label.TabIndex = 55;
            this.单元名称Label.Text = "单元名称：";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(65, 4);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(81, 20);
            this.楼栋名称ComboBox.TabIndex = 54;
            this.楼栋名称ComboBox.Text = "全部";
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(0, 9);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(65, 12);
            this.楼栋名称Label.TabIndex = 53;
            this.楼栋名称Label.Text = "楼栋名称：";
            // 
            // ReportOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.常住人员TextBox);
            this.Controls.Add(this.房屋类型TextBox);
            this.Controls.Add(this.单元名称TextBox);
            this.Controls.Add(this.业主报表DataGridView);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.当前状态ComboBox);
            this.Controls.Add(this.当前状态Label);
            this.Controls.Add(this.常住人员Label);
            this.Controls.Add(this.房屋类型Label);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.房屋性质ComboBox);
            this.Controls.Add(this.费用类型Label);
            this.Controls.Add(this.单元名称Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.楼栋名称Label);
            this.Name = "ReportOwnerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报表管理[业主统计报表]";
            this.Load += new System.EventHandler(this.ReportOwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.业主报表DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 常住人员TextBox;
        private System.Windows.Forms.TextBox 房屋类型TextBox;
        private System.Windows.Forms.TextBox 单元名称TextBox;
        private System.Windows.Forms.DataGridView 业主报表DataGridView;
        private System.Windows.Forms.Button 打印Button;
        private System.Windows.Forms.ComboBox 当前状态ComboBox;
        private System.Windows.Forms.Label 当前状态Label;
        private System.Windows.Forms.Label 常住人员Label;
        private System.Windows.Forms.Label 房屋类型Label;
        private System.Windows.Forms.Button 查询Button;
        private System.Windows.Forms.ComboBox 房屋性质ComboBox;
        private System.Windows.Forms.Label 费用类型Label;
        private System.Windows.Forms.Label 单元名称Label;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.Label 楼栋名称Label;
    }
}