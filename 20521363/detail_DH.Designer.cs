namespace _20521363
{
    partial class detail_DH
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsv_show = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsv_show
            // 
            this.lsv_show.HideSelection = false;
            this.lsv_show.Location = new System.Drawing.Point(0, 38);
            this.lsv_show.Name = "lsv_show";
            this.lsv_show.Size = new System.Drawing.Size(1281, 629);
            this.lsv_show.TabIndex = 0;
            this.lsv_show.UseCompatibleStateImageBehavior = false;
            // 
            // detail_DH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 664);
            this.Controls.Add(this.lsv_show);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "detail_DH";
            this.Text = "detail_DH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsv_show;
    }
}