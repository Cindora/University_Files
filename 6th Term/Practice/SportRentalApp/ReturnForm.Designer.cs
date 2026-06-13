namespace SportRentalApp
{
    partial class ReturnForm
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
            this.cmbContract = new System.Windows.Forms.ComboBox();
            this.dgvContractItems = new System.Windows.Forms.DataGridView();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbContract
            // 
            this.cmbContract.FormattingEnabled = true;
            this.cmbContract.Location = new System.Drawing.Point(15, 12);
            this.cmbContract.Name = "cmbContract";
            this.cmbContract.Size = new System.Drawing.Size(467, 24);
            this.cmbContract.TabIndex = 0;
            this.cmbContract.SelectedIndexChanged += new System.EventHandler(this.CmbContract_SelectedIndexChanged);
            // 
            // dgvContractItems
            // 
            this.dgvContractItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContractItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractItems.Location = new System.Drawing.Point(12, 71);
            this.dgvContractItems.Name = "dgvContractItems";
            this.dgvContractItems.RowHeadersWidth = 51;
            this.dgvContractItems.RowTemplate.Height = 24;
            this.dgvContractItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractItems.Size = new System.Drawing.Size(765, 150);
            this.dgvContractItems.TabIndex = 1;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(12, 280);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(140, 16);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "Итоговая стоимость";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 356);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 50);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Рассчитать стоимость";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(163, 356);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(116, 50);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Оформить возврат";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.dgvContractItems);
            this.Controls.Add(this.cmbContract);
            this.Name = "ReturnForm";
            this.Text = "Возврат инвентаря";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbContract;
        private System.Windows.Forms.DataGridView dgvContractItems;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
    }
}