namespace MyCommunity
{
    partial class ReportCommonRepairForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCommonRepairForm));
            this.故障现象TextBox = new System.Windows.Forms.TextBox();
            this.开始日期TextBox = new System.Windows.Forms.TextBox();
            this.结束日期TextBox = new System.Windows.Forms.TextBox();
            this.公共维修报表DataGridView = new System.Windows.Forms.DataGridView();
            this.打印Button = new System.Windows.Forms.Button();
            this.故障现象Label = new System.Windows.Forms.Label();
            this.开始日期Label = new System.Windows.Forms.Label();
            this.查询Button = new System.Windows.Forms.Button();
            this.结束日期Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.公共维修报表DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 故障现象TextBox
            // 
            this.故障现象TextBox.Location = new System.Drawing.Point(66, 26);
            this.故障现象TextBox.Name = "故障现象TextBox";
            this.故障现象TextBox.Size = new System.Drawing.Size(476, 21);
            this.故障现象TextBox.TabIndex = 94;
            // 
            // 开始日期TextBox
            // 
            this.开始日期TextBox.Location = new System.Drawing.Point(63, 3);
            this.开始日期TextBox.Name = "开始日期TextBox";
            this.开始日期TextBox.Size = new System.Drawing.Size(103, 21);
            this.开始日期TextBox.TabIndex = 93;
            this.开始日期TextBox.Text = "2006-1-1";
            // 
            // 结束日期TextBox
            // 
            this.结束日期TextBox.Location = new System.Drawing.Point(235, 3);
            this.结束日期TextBox.Name = "结束日期TextBox";
            this.结束日期TextBox.Size = new System.Drawing.Size(135, 21);
            this.结束日期TextBox.TabIndex = 92;
            this.结束日期TextBox.Text = "2010-12-31";
            // 
            // 公共维修报表DataGridView
            // 
            this.公共维修报表DataGridView.AllowUserToAddRows = false;
            this.公共维修报表DataGridView.AllowUserToDeleteRows = false;
            this.公共维修报表DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.公共维修报表DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.公共维修报表DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共维修报表DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.公共维修报表DataGridView.Location = new System.Drawing.Point(1, 52);
            this.公共维修报表DataGridView.MultiSelect = false;
            this.公共维修报表DataGridView.Name = "公共维修报表DataGridView";
            this.公共维修报表DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共维修报表DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.公共维修报表DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.公共维修报表DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.公共维修报表DataGridView.RowTemplate.Height = 23;
            this.公共维修报表DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.公共维修报表DataGridView.Size = new System.Drawing.Size(541, 365);
            this.公共维修报表DataGridView.TabIndex = 91;
            // 
            // 打印Button
            // 
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(462, 1);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(80, 23);
            this.打印Button.TabIndex = 90;
            this.打印Button.Text = "打印";
            this.打印Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.打印Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.打印Button.UseVisualStyleBackColor = true;
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 故障现象Label
            // 
            this.故障现象Label.AutoSize = true;
            this.故障现象Label.Location = new System.Drawing.Point(0, 31);
            this.故障现象Label.Name = "故障现象Label";
            this.故障现象Label.Size = new System.Drawing.Size(65, 12);
            this.故障现象Label.TabIndex = 89;
            this.故障现象Label.Text = "故障现象：";
            // 
            // 开始日期Label
            // 
            this.开始日期Label.AutoSize = true;
            this.开始日期Label.Location = new System.Drawing.Point(-1, 9);
            this.开始日期Label.Name = "开始日期Label";
            this.开始日期Label.Size = new System.Drawing.Size(65, 12);
            this.开始日期Label.TabIndex = 88;
            this.开始日期Label.Text = "开始日期：";
            // 
            // 查询Button
            // 
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(376, 1);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(80, 23);
            this.查询Button.TabIndex = 87;
            this.查询Button.Text = "查询";
            this.查询Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.查询Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.查询Button.UseVisualStyleBackColor = true;
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 结束日期Label
            // 
            this.结束日期Label.AutoSize = true;
            this.结束日期Label.Location = new System.Drawing.Point(172, 9);
            this.结束日期Label.Name = "结束日期Label";
            this.结束日期Label.Size = new System.Drawing.Size(65, 12);
            this.结束日期Label.TabIndex = 86;
            this.结束日期Label.Text = "结束日期：";
            // 
            // ReportCommonRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 418);
            this.Controls.Add(this.故障现象TextBox);
            this.Controls.Add(this.开始日期TextBox);
            this.Controls.Add(this.结束日期TextBox);
            this.Controls.Add(this.公共维修报表DataGridView);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.故障现象Label);
            this.Controls.Add(this.开始日期Label);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.结束日期Label);
            this.Name = "ReportCommonRepairForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报表管理[公共维修报表]";
            ((System.ComponentModel.ISupportInitialize)(this.公共维修报表DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 故障现象TextBox;
        private System.Windows.Forms.TextBox 开始日期TextBox;
        private System.Windows.Forms.TextBox 结束日期TextBox;
        private System.Windows.Forms.DataGridView 公共维修报表DataGridView;
        private System.Windows.Forms.Button 打印Button;
        private System.Windows.Forms.Label 故障现象Label;
        private System.Windows.Forms.Label 开始日期Label;
        private System.Windows.Forms.Button 查询Button;
        private System.Windows.Forms.Label 结束日期Label;
    }
}