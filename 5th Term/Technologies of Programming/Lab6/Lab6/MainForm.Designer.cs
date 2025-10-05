namespace Lab6
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
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnDuplicates = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(341, 41);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(125, 50);
            this.btnGroup.TabIndex = 0;
            this.btnGroup.Text = "Группировать по улице";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnDuplicates
            // 
            this.btnDuplicates.Location = new System.Drawing.Point(341, 109);
            this.btnDuplicates.Name = "btnDuplicates";
            this.btnDuplicates.Size = new System.Drawing.Size(125, 50);
            this.btnDuplicates.TabIndex = 1;
            this.btnDuplicates.Text = "Найти повторы";
            this.btnDuplicates.UseVisualStyleBackColor = true;
            this.btnDuplicates.Click += new System.EventHandler(this.btnDuplicates_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.Location = new System.Drawing.Point(341, 177);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(125, 50);
            this.btnOdd.TabIndex = 2;
            this.btnOdd.Text = "Нечётные номера";
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(16, 41);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 350);
            this.txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(488, 41);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(300, 350);
            this.txtOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Массив адресов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результат";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 45);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить результат";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 423);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.btnDuplicates);
            this.Controls.Add(this.btnGroup);
            this.Name = "MainForm";
            this.Text = "Lab6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnDuplicates;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
    }
}

