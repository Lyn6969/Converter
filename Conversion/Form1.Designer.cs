namespace Conversion
{
    partial class Frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.cbox_input = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_output = new System.Windows.Forms.ComboBox();
            this.btn_transform = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_output);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_transform);
            this.groupBox1.Controls.Add(this.cbox_output);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbox_input);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_input);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进制转换";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入数值：";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(87, 36);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(70, 21);
            this.txt_input.TabIndex = 0;
            // 
            // cbox_input
            // 
            this.cbox_input.FormattingEnabled = true;
            this.cbox_input.Items.AddRange(new object[] {
            "十进制",
            "二进制",
            "八进制",
            "十六进制"});
            this.cbox_input.Location = new System.Drawing.Point(177, 36);
            this.cbox_input.Name = "cbox_input";
            this.cbox_input.Size = new System.Drawing.Size(78, 20);
            this.cbox_input.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "转换为：";
            // 
            // cbox_output
            // 
            this.cbox_output.FormattingEnabled = true;
            this.cbox_output.Items.AddRange(new object[] {
            "十进制",
            "二进制",
            "八进制",
            "十六进制"});
            this.cbox_output.Location = new System.Drawing.Point(87, 79);
            this.cbox_output.Name = "cbox_output";
            this.cbox_output.Size = new System.Drawing.Size(70, 20);
            this.cbox_output.TabIndex = 4;
            // 
            // btn_transform
            // 
            this.btn_transform.Location = new System.Drawing.Point(177, 76);
            this.btn_transform.Name = "btn_transform";
            this.btn_transform.Size = new System.Drawing.Size(78, 23);
            this.btn_transform.TabIndex = 5;
            this.btn_transform.Text = "转换";
            this.btn_transform.UseVisualStyleBackColor = true;
            this.btn_transform.Click += new System.EventHandler(this.btn_transform_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "转换结果：";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(87, 119);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(168, 21);
            this.txt_output.TabIndex = 7;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 194);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_main";
            this.Text = "进制转换器";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_transform;
        private System.Windows.Forms.ComboBox cbox_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_input;
    }
}

