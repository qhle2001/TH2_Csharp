namespace _20521363
{
    partial class UserCart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbshow = new System.Windows.Forms.Label();
            this.lstShow = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btmua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbshow
            // 
            this.lbshow.AutoSize = true;
            this.lbshow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbshow.ForeColor = System.Drawing.Color.Black;
            this.lbshow.Location = new System.Drawing.Point(317, -3);
            this.lbshow.Name = "lbshow";
            this.lbshow.Size = new System.Drawing.Size(86, 32);
            this.lbshow.TabIndex = 0;
            this.lbshow.Text = "label1";
            // 
            // lstShow
            // 
            this.lstShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstShow.ForeColor = System.Drawing.Color.Red;
            this.lstShow.HideSelection = false;
            this.lstShow.Location = new System.Drawing.Point(323, 30);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(1390, 496);
            this.lstShow.TabIndex = 1;
            this.lstShow.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1744, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1744, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thay đổi số lượng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Red;
            this.numericUpDown1.Location = new System.Drawing.Point(1882, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 34);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1741, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng:";
            // 
            // btmua
            // 
            this.btmua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmua.ForeColor = System.Drawing.Color.Black;
            this.btmua.Location = new System.Drawing.Point(1747, 462);
            this.btmua.Name = "btmua";
            this.btmua.Size = new System.Drawing.Size(273, 43);
            this.btmua.TabIndex = 6;
            this.btmua.Text = "Chọn mua";
            this.btmua.UseVisualStyleBackColor = true;
            this.btmua.Click += new System.EventHandler(this.btmua_Click);
            // 
            // UserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btmua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.lbshow);
            this.Name = "UserCart";
            this.Size = new System.Drawing.Size(2001, 526);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbshow;
        private System.Windows.Forms.ListView lstShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmua;
    }
}
