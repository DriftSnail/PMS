namespace MyCommunity
{
    partial class ChangeUserPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserPasswordForm));
            this.用户名称TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.返回系统Button = new System.Windows.Forms.Button();
            this.修改密码Button = new System.Windows.Forms.Button();
            this.再输一次新密码TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.新密码TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.旧密码TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 用户名称TextBox
            // 
            this.用户名称TextBox.Location = new System.Drawing.Point(121, 100);
            this.用户名称TextBox.Name = "用户名称TextBox";
            this.用户名称TextBox.PasswordChar = '*';
            this.用户名称TextBox.ReadOnly = true;
            this.用户名称TextBox.Size = new System.Drawing.Size(173, 21);
            this.用户名称TextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "用户名称：";
            // 
            // 返回系统Button
            // 
            this.返回系统Button.Image = ((System.Drawing.Image)(resources.GetObject("返回系统Button.Image")));
            this.返回系统Button.Location = new System.Drawing.Point(178, 127);
            this.返回系统Button.Name = "返回系统Button";
            this.返回系统Button.Size = new System.Drawing.Size(100, 25);
            this.返回系统Button.TabIndex = 27;
            this.返回系统Button.Text = "返回系统";
            this.返回系统Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.返回系统Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.返回系统Button.UseVisualStyleBackColor = true;
            this.返回系统Button.Click += new System.EventHandler(this.返回系统Button_Click);
            // 
            // 修改密码Button
            // 
            this.修改密码Button.Image = ((System.Drawing.Image)(resources.GetObject("修改密码Button.Image")));
            this.修改密码Button.Location = new System.Drawing.Point(68, 127);
            this.修改密码Button.Name = "修改密码Button";
            this.修改密码Button.Size = new System.Drawing.Size(100, 25);
            this.修改密码Button.TabIndex = 26;
            this.修改密码Button.Text = "修改密码";
            this.修改密码Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.修改密码Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.修改密码Button.UseVisualStyleBackColor = true;
            this.修改密码Button.Click += new System.EventHandler(this.修改密码Button_Click);
            // 
            // 再输一次新密码TextBox
            // 
            this.再输一次新密码TextBox.Location = new System.Drawing.Point(166, 73);
            this.再输一次新密码TextBox.Name = "再输一次新密码TextBox";
            this.再输一次新密码TextBox.PasswordChar = '*';
            this.再输一次新密码TextBox.Size = new System.Drawing.Size(128, 21);
            this.再输一次新密码TextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "再输一次新密码：";
            // 
            // 新密码TextBox
            // 
            this.新密码TextBox.Location = new System.Drawing.Point(109, 46);
            this.新密码TextBox.Name = "新密码TextBox";
            this.新密码TextBox.PasswordChar = '*';
            this.新密码TextBox.Size = new System.Drawing.Size(185, 21);
            this.新密码TextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "新密码：";
            // 
            // 旧密码TextBox
            // 
            this.旧密码TextBox.Location = new System.Drawing.Point(109, 19);
            this.旧密码TextBox.Name = "旧密码TextBox";
            this.旧密码TextBox.PasswordChar = '*';
            this.旧密码TextBox.Size = new System.Drawing.Size(185, 21);
            this.旧密码TextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "旧密码：";
            // 
            // ChangeUserPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 168);
            this.ControlBox = false;
            this.Controls.Add(this.用户名称TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.返回系统Button);
            this.Controls.Add(this.修改密码Button);
            this.Controls.Add(this.再输一次新密码TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.新密码TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.旧密码TextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChangeUserPasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统管理[修改用户密码]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox 用户名称TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button 返回系统Button;
        private System.Windows.Forms.Button 修改密码Button;
        private System.Windows.Forms.TextBox 再输一次新密码TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 新密码TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 旧密码TextBox;
        private System.Windows.Forms.Label label1;
    }
}