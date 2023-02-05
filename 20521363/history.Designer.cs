namespace _20521363
{
    partial class history
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
            this.lbhistory = new System.Windows.Forms.Label();
            this.lsvhistory = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbhistory
            // 
            this.lbhistory.AutoSize = true;
            this.lbhistory.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhistory.Location = new System.Drawing.Point(0, 0);
            this.lbhistory.Name = "lbhistory";
            this.lbhistory.Size = new System.Drawing.Size(86, 32);
            this.lbhistory.TabIndex = 0;
            this.lbhistory.Text = "label1";
            // 
            // lsvhistory
            // 
            this.lsvhistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvhistory.HideSelection = false;
            this.lsvhistory.Location = new System.Drawing.Point(0, 35);
            this.lsvhistory.Name = "lsvhistory";
            this.lsvhistory.Size = new System.Drawing.Size(2050, 687);
            this.lsvhistory.TabIndex = 1;
            this.lsvhistory.UseCompatibleStateImageBehavior = false;
            this.lsvhistory.SelectedIndexChanged += new System.EventHandler(this.lsvhistory_SelectedIndexChanged);
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsvhistory);
            this.Controls.Add(this.lbhistory);
            this.Name = "history";
            this.Size = new System.Drawing.Size(2050, 722);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhistory;
        private System.Windows.Forms.ListView lsvhistory;
    }
}
