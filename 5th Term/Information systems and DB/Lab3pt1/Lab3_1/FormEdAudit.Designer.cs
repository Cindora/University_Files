namespace Lab3_1
{
    partial class FormEdAudit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edAudit = new System.Windows.Forms.TextBox();
            this.edCorps = new System.Windows.Forms.TextBox();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер аудитории";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер корпуса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Этаж";
            // 
            // edAudit
            // 
            this.edAudit.Location = new System.Drawing.Point(219, 37);
            this.edAudit.Name = "edAudit";
            this.edAudit.Size = new System.Drawing.Size(160, 22);
            this.edAudit.TabIndex = 5;
            // 
            // edCorps
            // 
            this.edCorps.Location = new System.Drawing.Point(219, 100);
            this.edCorps.Name = "edCorps";
            this.edCorps.Size = new System.Drawing.Size(160, 22);
            this.edCorps.TabIndex = 6;
            // 
            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbFloor.Location = new System.Drawing.Point(219, 152);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(160, 24);
            this.cbFloor.TabIndex = 7;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(112, 236);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(103, 38);
            this.bOk.TabIndex = 8;
            this.bOk.Text = "Сохранить";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(310, 236);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(101, 38);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // FormEdAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.edCorps);
            this.Controls.Add(this.edAudit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormEdAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEdAudit";
            this.Load += new System.EventHandler(this.FormEdAudit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox edAudit;
        public System.Windows.Forms.TextBox edCorps;
        public System.Windows.Forms.ComboBox cbFloor;
        public System.Windows.Forms.Button bOk;
        public System.Windows.Forms.Button bCancel;
    }
}