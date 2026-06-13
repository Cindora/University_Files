namespace SportRentalApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnShowAvailable = new System.Windows.Forms.Button();
            this.cmbEquipmentType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOverdueReport = new System.Windows.Forms.Button();
            this.btnRevenueReport = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClients);
            this.groupBox1.Controls.Add(this.btnAddClient);
            this.groupBox1.Controls.Add(this.txtClientSearch);
            this.groupBox1.Location = new System.Drawing.Point(64, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиенты";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(25, 145);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(598, 195);
            this.dgvClients.TabIndex = 2;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(25, 76);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(222, 36);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Добавить нового клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Location = new System.Drawing.Point(25, 34);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(222, 22);
            this.txtClientSearch.TabIndex = 0;
            this.txtClientSearch.Text = "Поиск по телефону/паспорту";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvInventory);
            this.groupBox2.Controls.Add(this.btnShowAvailable);
            this.groupBox2.Controls.Add(this.cmbEquipmentType);
            this.groupBox2.Location = new System.Drawing.Point(64, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Инвентарь";
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(19, 145);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(604, 150);
            this.dgvInventory.TabIndex = 2;
            // 
            // btnShowAvailable
            // 
            this.btnShowAvailable.Location = new System.Drawing.Point(19, 76);
            this.btnShowAvailable.Name = "btnShowAvailable";
            this.btnShowAvailable.Size = new System.Drawing.Size(233, 36);
            this.btnShowAvailable.TabIndex = 1;
            this.btnShowAvailable.Text = "Показать доступные";
            this.btnShowAvailable.UseVisualStyleBackColor = true;
            this.btnShowAvailable.Click += new System.EventHandler(this.btnShowAvailable_Click);
            // 
            // cmbEquipmentType
            // 
            this.cmbEquipmentType.FormattingEnabled = true;
            this.cmbEquipmentType.Items.AddRange(new object[] {
            "лыжи",
            "велосипеды"});
            this.cmbEquipmentType.Location = new System.Drawing.Point(19, 31);
            this.cmbEquipmentType.Name = "cmbEquipmentType";
            this.cmbEquipmentType.Size = new System.Drawing.Size(121, 24);
            this.cmbEquipmentType.TabIndex = 0;
            this.cmbEquipmentType.Text = "лыжи";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReturn);
            this.groupBox3.Controls.Add(this.btnRent);
            this.groupBox3.Location = new System.Drawing.Point(725, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Операции";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(19, 76);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(153, 43);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Принять возврат";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(19, 20);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(123, 41);
            this.btnRent.TabIndex = 0;
            this.btnRent.Text = "Выдать";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOverdueReport);
            this.groupBox4.Controls.Add(this.btnRevenueReport);
            this.groupBox4.Controls.Add(this.dtpEnd);
            this.groupBox4.Controls.Add(this.dtpStart);
            this.groupBox4.Location = new System.Drawing.Point(725, 419);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 191);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Отчёты";
            // 
            // btnOverdueReport
            // 
            this.btnOverdueReport.Location = new System.Drawing.Point(19, 148);
            this.btnOverdueReport.Name = "btnOverdueReport";
            this.btnOverdueReport.Size = new System.Drawing.Size(163, 37);
            this.btnOverdueReport.TabIndex = 3;
            this.btnOverdueReport.Text = "Просроченные";
            this.btnOverdueReport.UseVisualStyleBackColor = true;
            this.btnOverdueReport.Click += new System.EventHandler(this.btnOverdueReport_Click);
            // 
            // btnRevenueReport
            // 
            this.btnRevenueReport.Location = new System.Drawing.Point(19, 115);
            this.btnRevenueReport.Name = "btnRevenueReport";
            this.btnRevenueReport.Size = new System.Drawing.Size(163, 26);
            this.btnRevenueReport.TabIndex = 2;
            this.btnRevenueReport.Text = "Выручка";
            this.btnRevenueReport.UseVisualStyleBackColor = true;
            this.btnRevenueReport.Click += new System.EventHandler(this.btnRevenueReport_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(19, 75);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(19, 35);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.ComboBox cmbEquipmentType;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnShowAvailable;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnOverdueReport;
        private System.Windows.Forms.Button btnRevenueReport;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}

