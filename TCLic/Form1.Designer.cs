namespace TCLic
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LicencedCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LicencedIndividual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LicencedCompany
            // 
            this.LicencedCompany.Location = new System.Drawing.Point(91, 22);
            this.LicencedCompany.Name = "LicencedCompany";
            this.LicencedCompany.Size = new System.Drawing.Size(357, 21);
            this.LicencedCompany.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // LicencedIndividual
            // 
            this.LicencedIndividual.Location = new System.Drawing.Point(91, 54);
            this.LicencedIndividual.Name = "LicencedIndividual";
            this.LicencedIndividual.Size = new System.Drawing.Size(357, 21);
            this.LicencedIndividual.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // EMail
            // 
            this.EMail.Location = new System.Drawing.Point(91, 86);
            this.EMail.Name = "EMail";
            this.EMail.Size = new System.Drawing.Size(357, 21);
            this.EMail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "ProductKey:";
            // 
            // ProductKey
            // 
            this.ProductKey.Location = new System.Drawing.Point(91, 118);
            this.ProductKey.Name = "ProductKey";
            this.ProductKey.Size = new System.Drawing.Size(357, 21);
            this.ProductKey.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 197);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LicencedIndividual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LicencedCompany);
            this.Name = "Main";
            this.Text = "TC 注册机";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LicencedCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LicencedIndividual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductKey;
    }
}

