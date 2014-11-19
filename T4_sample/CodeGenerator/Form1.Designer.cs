namespace CodeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.generate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtdbContext = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.panelDLL = new System.Windows.Forms.Panel();
            this.panelDLL.SuspendLayout();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(21, 238);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 0;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(209, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(717, 571);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DLL",
            "BLL",
            "Controller",
            "View_Index",
            "View_Page"});
            this.comboBox1.Location = new System.Drawing.Point(21, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "請選選擇樣版";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Namespace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "ClassName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "dbContext";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "ModelName";
            // 
            // txtNamespace
            // 
            this.txtNamespace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtNamespace.Location = new System.Drawing.Point(67, 4);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(100, 22);
            this.txtNamespace.TabIndex = 8;
            this.txtNamespace.Text = "namespace";
            // 
            // txtModelName
            // 
            this.txtModelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtModelName.Location = new System.Drawing.Point(67, 88);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(100, 22);
            this.txtModelName.TabIndex = 9;
            this.txtModelName.Text = "模型名稱";
            // 
            // txtdbContext
            // 
            this.txtdbContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtdbContext.Location = new System.Drawing.Point(67, 60);
            this.txtdbContext.Name = "txtdbContext";
            this.txtdbContext.Size = new System.Drawing.Size(100, 22);
            this.txtdbContext.TabIndex = 10;
            this.txtdbContext.Text = "EF連線名稱";
            // 
            // txtClassName
            // 
            this.txtClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtClassName.Location = new System.Drawing.Point(67, 32);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 22);
            this.txtClassName.TabIndex = 11;
            this.txtClassName.Text = "類別名稱";
            // 
            // panelDLL
            // 
            this.panelDLL.Controls.Add(this.label3);
            this.panelDLL.Controls.Add(this.txtClassName);
            this.panelDLL.Controls.Add(this.label2);
            this.panelDLL.Controls.Add(this.txtdbContext);
            this.panelDLL.Controls.Add(this.label4);
            this.panelDLL.Controls.Add(this.txtModelName);
            this.panelDLL.Controls.Add(this.label5);
            this.panelDLL.Controls.Add(this.txtNamespace);
            this.panelDLL.Location = new System.Drawing.Point(23, 87);
            this.panelDLL.Name = "panelDLL";
            this.panelDLL.Size = new System.Drawing.Size(180, 127);
            this.panelDLL.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 611);
            this.Controls.Add(this.panelDLL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.generate);
            this.Name = "Form1";
            this.Text = "MVC版 程式碼產生器";
            this.panelDLL.ResumeLayout(false);
            this.panelDLL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtdbContext;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Panel panelDLL;
    }
}

