namespace SportRentalApp
{
    partial class RentForm
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
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.labelAvailableInv = new System.Windows.Forms.Label();
            this.dgvAvailableInventory = new System.Windows.Forms.DataGridView();
            this.dtpPlannedReturn = new System.Windows.Forms.DateTimePicker();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(43, 30);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 24);
            this.cmbClient.TabIndex = 0;
            // 
            // labelAvailableInv
            // 
            this.labelAvailableInv.AutoSize = true;
            this.labelAvailableInv.Location = new System.Drawing.Point(43, 84);
            this.labelAvailableInv.Name = "labelAvailableInv";
            this.labelAvailableInv.Size = new System.Drawing.Size(152, 16);
            this.labelAvailableInv.TabIndex = 1;
            this.labelAvailableInv.Text = "Доступный инвентарь";
            // 
            // dgvAvailableInventory
            // 
            this.dgvAvailableInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableInventory.Location = new System.Drawing.Point(43, 133);
            this.dgvAvailableInventory.Name = "dgvAvailableInventory";
            this.dgvAvailableInventory.RowHeadersWidth = 51;
            this.dgvAvailableInventory.RowTemplate.Height = 24;
            this.dgvAvailableInventory.Size = new System.Drawing.Size(240, 150);
            this.dgvAvailableInventory.TabIndex = 2;
            // 
            // dtpPlannedReturn
            // 
            this.dtpPlannedReturn.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPlannedReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPlannedReturn.Location = new System.Drawing.Point(46, 313);
            this.dtpPlannedReturn.Name = "dtpPlannedReturn";
            this.dtpPlannedReturn.ShowUpDown = true;
            this.dtpPlannedReturn.Size = new System.Drawing.Size(200, 22);
            this.dtpPlannedReturn.TabIndex = 3;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(43, 366);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 4;
            this.btnRent.Text = "Оформить выдачу";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(208, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.dtpPlannedReturn);
            this.Controls.Add(this.dgvAvailableInventory);
            this.Controls.Add(this.labelAvailableInv);
            this.Controls.Add(this.cmbClient);
            this.Name = "RentForm";
            this.Text = "RentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label labelAvailableInv;
        private System.Windows.Forms.DataGridView dgvAvailableInventory;
        private System.Windows.Forms.DateTimePicker dtpPlannedReturn;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnCancel;
    }
}