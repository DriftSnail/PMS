namespace MyCommunity
{
    partial class OtherPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherPaymentForm));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.补充说明Label = new System.Windows.Forms.Label();
            this.收款事由TextBox = new System.Windows.Forms.TextBox();
            this.收款事由Label = new System.Windows.Forms.Label();
            this.收款形式TextBox = new System.Windows.Forms.TextBox();
            this.收款形式Label = new System.Windows.Forms.Label();
            this.收款人员Label = new System.Windows.Forms.Label();
            this.收款人员TextBox = new System.Windows.Forms.TextBox();
            this.收款金额TextBox = new System.Windows.Forms.TextBox();
            this.收款金额Label = new System.Windows.Forms.Label();
            this.交款人员TextBox = new System.Windows.Forms.TextBox();
            this.交款人员Label = new System.Windows.Forms.Label();
            this.收款日期TextBox = new System.Windows.Forms.TextBox();
            this.收款日期Label = new System.Windows.Forms.Label();
            this.收据编号TextBox = new System.Windows.Forms.TextBox();
            this.收据编号Label = new System.Windows.Forms.Label();
            this.保存Button = new System.Windows.Forms.Button();
            this.打印Button = new System.Windows.Forms.Button();
            this.新增Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.补充说明TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.补充说明TextBox.Location = new System.Drawing.Point(65, 147);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(475, 21);
            this.补充说明TextBox.TabIndex = 110;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 补充说明Label
            // 
            this.补充说明Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.补充说明Label.AutoSize = true;
            this.补充说明Label.Location = new System.Drawing.Point(4, 151);
            this.补充说明Label.Name = "补充说明Label";
            this.补充说明Label.Size = new System.Drawing.Size(65, 12);
            this.补充说明Label.TabIndex = 109;
            this.补充说明Label.Text = "补充说明：";
            // 
            // 收款事由TextBox
            // 
            this.收款事由TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.收款事由TextBox.Location = new System.Drawing.Point(2, 78);
            this.收款事由TextBox.Multiline = true;
            this.收款事由TextBox.Name = "收款事由TextBox";
            this.收款事由TextBox.Size = new System.Drawing.Size(538, 65);
            this.收款事由TextBox.TabIndex = 108;
            this.收款事由TextBox.Text = "交维修费";
            // 
            // 收款事由Label
            // 
            this.收款事由Label.AutoSize = true;
            this.收款事由Label.Location = new System.Drawing.Point(3, 60);
            this.收款事由Label.Name = "收款事由Label";
            this.收款事由Label.Size = new System.Drawing.Size(65, 12);
            this.收款事由Label.TabIndex = 107;
            this.收款事由Label.Text = "收款事由：";
            // 
            // 收款形式TextBox
            // 
            this.收款形式TextBox.Location = new System.Drawing.Point(330, 30);
            this.收款形式TextBox.Name = "收款形式TextBox";
            this.收款形式TextBox.Size = new System.Drawing.Size(57, 21);
            this.收款形式TextBox.TabIndex = 104;
            this.收款形式TextBox.Text = "现金";
            // 
            // 收款形式Label
            // 
            this.收款形式Label.AutoSize = true;
            this.收款形式Label.Location = new System.Drawing.Point(266, 35);
            this.收款形式Label.Name = "收款形式Label";
            this.收款形式Label.Size = new System.Drawing.Size(65, 12);
            this.收款形式Label.TabIndex = 103;
            this.收款形式Label.Text = "收款形式：";
            // 
            // 收款人员Label
            // 
            this.收款人员Label.AutoSize = true;
            this.收款人员Label.Location = new System.Drawing.Point(389, 35);
            this.收款人员Label.Name = "收款人员Label";
            this.收款人员Label.Size = new System.Drawing.Size(65, 12);
            this.收款人员Label.TabIndex = 105;
            this.收款人员Label.Text = "收款人员：";
            // 
            // 收款人员TextBox
            // 
            this.收款人员TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.收款人员TextBox.Location = new System.Drawing.Point(454, 30);
            this.收款人员TextBox.Name = "收款人员TextBox";
            this.收款人员TextBox.Size = new System.Drawing.Size(86, 21);
            this.收款人员TextBox.TabIndex = 106;
            // 
            // 收款金额TextBox
            // 
            this.收款金额TextBox.Location = new System.Drawing.Point(202, 30);
            this.收款金额TextBox.Name = "收款金额TextBox";
            this.收款金额TextBox.Size = new System.Drawing.Size(57, 21);
            this.收款金额TextBox.TabIndex = 102;
            this.收款金额TextBox.Text = "0";
            // 
            // 收款金额Label
            // 
            this.收款金额Label.AutoSize = true;
            this.收款金额Label.Location = new System.Drawing.Point(134, 35);
            this.收款金额Label.Name = "收款金额Label";
            this.收款金额Label.Size = new System.Drawing.Size(65, 12);
            this.收款金额Label.TabIndex = 101;
            this.收款金额Label.Text = "收款金额：";
            // 
            // 交款人员TextBox
            // 
            this.交款人员TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.交款人员TextBox.Location = new System.Drawing.Point(454, 5);
            this.交款人员TextBox.Name = "交款人员TextBox";
            this.交款人员TextBox.Size = new System.Drawing.Size(86, 21);
            this.交款人员TextBox.TabIndex = 100;
            // 
            // 交款人员Label
            // 
            this.交款人员Label.AutoSize = true;
            this.交款人员Label.Location = new System.Drawing.Point(391, 10);
            this.交款人员Label.Name = "交款人员Label";
            this.交款人员Label.Size = new System.Drawing.Size(65, 12);
            this.交款人员Label.TabIndex = 99;
            this.交款人员Label.Text = "交款人员：";
            // 
            // 收款日期TextBox
            // 
            this.收款日期TextBox.Location = new System.Drawing.Point(65, 30);
            this.收款日期TextBox.Name = "收款日期TextBox";
            this.收款日期TextBox.Size = new System.Drawing.Size(66, 21);
            this.收款日期TextBox.TabIndex = 98;
            this.收款日期TextBox.Text = "2006-6-1";
            // 
            // 收款日期Label
            // 
            this.收款日期Label.AutoSize = true;
            this.收款日期Label.Location = new System.Drawing.Point(4, 35);
            this.收款日期Label.Name = "收款日期Label";
            this.收款日期Label.Size = new System.Drawing.Size(65, 12);
            this.收款日期Label.TabIndex = 97;
            this.收款日期Label.Text = "收款日期：";
            // 
            // 收据编号TextBox
            // 
            this.收据编号TextBox.Location = new System.Drawing.Point(65, 5);
            this.收据编号TextBox.Name = "收据编号TextBox";
            this.收据编号TextBox.Size = new System.Drawing.Size(322, 21);
            this.收据编号TextBox.TabIndex = 96;
            // 
            // 收据编号Label
            // 
            this.收据编号Label.AutoSize = true;
            this.收据编号Label.Location = new System.Drawing.Point(4, 10);
            this.收据编号Label.Name = "收据编号Label";
            this.收据编号Label.Size = new System.Drawing.Size(65, 12);
            this.收据编号Label.TabIndex = 95;
            this.收据编号Label.Text = "收据编号：";
            // 
            // 保存Button
            // 
            this.保存Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.保存Button.Image = ((System.Drawing.Image)(resources.GetObject("保存Button.Image")));
            this.保存Button.Location = new System.Drawing.Point(459, 54);
            this.保存Button.Name = "保存Button";
            this.保存Button.Size = new System.Drawing.Size(80, 23);
            this.保存Button.TabIndex = 113;
            this.保存Button.Text = "保存";
            this.保存Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.保存Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.保存Button.UseVisualStyleBackColor = true;
            this.保存Button.Click += new System.EventHandler(this.保存Button_Click);
            // 
            // 打印Button
            // 
            this.打印Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(373, 54);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(80, 23);
            this.打印Button.TabIndex = 112;
            this.打印Button.Text = "打印";
            this.打印Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.打印Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.打印Button.UseVisualStyleBackColor = true;
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 新增Button
            // 
            this.新增Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.新增Button.Image = ((System.Drawing.Image)(resources.GetObject("新增Button.Image")));
            this.新增Button.Location = new System.Drawing.Point(287, 54);
            this.新增Button.Name = "新增Button";
            this.新增Button.Size = new System.Drawing.Size(80, 23);
            this.新增Button.TabIndex = 111;
            this.新增Button.Text = "新增";
            this.新增Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.新增Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.新增Button.UseVisualStyleBackColor = true;
            this.新增Button.Click += new System.EventHandler(this.新增Button_Click);
            // 
            // OtherPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 168);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.补充说明Label);
            this.Controls.Add(this.收款事由TextBox);
            this.Controls.Add(this.收款事由Label);
            this.Controls.Add(this.收款形式TextBox);
            this.Controls.Add(this.收款形式Label);
            this.Controls.Add(this.收款人员Label);
            this.Controls.Add(this.收款人员TextBox);
            this.Controls.Add(this.收款金额TextBox);
            this.Controls.Add(this.收款金额Label);
            this.Controls.Add(this.交款人员TextBox);
            this.Controls.Add(this.交款人员Label);
            this.Controls.Add(this.收款日期TextBox);
            this.Controls.Add(this.收款日期Label);
            this.Controls.Add(this.收据编号TextBox);
            this.Controls.Add(this.收据编号Label);
            this.Controls.Add(this.保存Button);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.新增Button);
            this.Name = "OtherPaymentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用管理[其他费用交纳]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.Label 补充说明Label;
        private System.Windows.Forms.TextBox 收款事由TextBox;
        private System.Windows.Forms.Label 收款事由Label;
        private System.Windows.Forms.TextBox 收款形式TextBox;
        private System.Windows.Forms.Label 收款形式Label;
        private System.Windows.Forms.Label 收款人员Label;
        private System.Windows.Forms.TextBox 收款人员TextBox;
        private System.Windows.Forms.TextBox 收款金额TextBox;
        private System.Windows.Forms.Label 收款金额Label;
        private System.Windows.Forms.TextBox 交款人员TextBox;
        private System.Windows.Forms.Label 交款人员Label;
        private System.Windows.Forms.TextBox 收款日期TextBox;
        private System.Windows.Forms.Label 收款日期Label;
        private System.Windows.Forms.TextBox 收据编号TextBox;
        private System.Windows.Forms.Label 收据编号Label;
        private System.Windows.Forms.Button 保存Button;
        private System.Windows.Forms.Button 打印Button;
        private System.Windows.Forms.Button 新增Button;

    }
}