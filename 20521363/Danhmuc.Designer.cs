namespace _20521363
{
    partial class Danhmuc
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
            this.SuspendLayout();
            // 
            // lbshow
            // 
            this.lbshow.AutoSize = true;
            this.lbshow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbshow.Location = new System.Drawing.Point(0, 1);
            this.lbshow.Name = "lbshow";
            this.lbshow.Size = new System.Drawing.Size(70, 25);
            this.lbshow.TabIndex = 0;
            this.lbshow.Text = "label1";
            // 
            // lstShow
            // 
            this.lstShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstShow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstShow.HideSelection = false;
            this.lstShow.Location = new System.Drawing.Point(0, 30);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(1162, 369);
            this.lstShow.TabIndex = 1;
            this.lstShow.UseCompatibleStateImageBehavior = false;
            this.lstShow.SelectedIndexChanged += new System.EventHandler(this.lstShow_SelectedIndexChanged);
            // 
            // Danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.lbshow);
            this.Name = "Danhmuc";
            this.Size = new System.Drawing.Size(1162, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbshow;
        private System.Windows.Forms.ListView lstShow;
    }
}
