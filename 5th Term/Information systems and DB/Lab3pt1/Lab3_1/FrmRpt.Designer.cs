namespace Lab3_1
{
    partial class FrmRpt
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Head = new System.Windows.Forms.Label();
            this.SubHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 95);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1120, 626);
            this.reportViewer1.TabIndex = 0;
            // 
            // Head
            // 
            this.Head.AutoSize = true;
            this.Head.Location = new System.Drawing.Point(13, 13);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(41, 16);
            this.Head.TabIndex = 1;
            this.Head.Text = "Head";
            // 
            // SubHead
            // 
            this.SubHead.AutoSize = true;
            this.SubHead.Location = new System.Drawing.Point(13, 46);
            this.SubHead.Name = "SubHead";
            this.SubHead.Size = new System.Drawing.Size(65, 16);
            this.SubHead.TabIndex = 2;
            this.SubHead.Text = "SubHead";
            // 
            // FrmRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 733);
            this.Controls.Add(this.SubHead);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRpt";
            this.Text = "Отчёт";
            this.Load += new System.EventHandler(this.FrmRpt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.Label Head;
        public System.Windows.Forms.Label SubHead;
    }
}