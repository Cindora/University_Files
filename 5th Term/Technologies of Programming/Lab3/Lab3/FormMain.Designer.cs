namespace Lab3
{
    partial class FormMain
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
            this.tableTea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableTea)).BeginInit();
            this.SuspendLayout();
            // 
            // tableTea
            // 
            this.tableTea.AllowUserToAddRows = false;
            this.tableTea.AllowUserToDeleteRows = false;
            this.tableTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTea.Location = new System.Drawing.Point(12, 12);
            this.tableTea.Name = "tableTea";
            this.tableTea.ReadOnly = true;
            this.tableTea.RowHeadersWidth = 51;
            this.tableTea.RowTemplate.Height = 24;
            this.tableTea.Size = new System.Drawing.Size(496, 273);
            this.tableTea.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 297);
            this.Controls.Add(this.tableTea);
            this.Name = "FormMain";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.tableTea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableTea;
    }
}

