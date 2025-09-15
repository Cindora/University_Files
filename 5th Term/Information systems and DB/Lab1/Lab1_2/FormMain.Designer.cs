namespace Lab1_2
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
            this.panelTwo = new System.Windows.Forms.Panel();
            this.button2Calculate = new System.Windows.Forms.Button();
            this.button2BackToEnterN = new System.Windows.Forms.Button();
            this.gridXn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOne = new System.Windows.Forms.Panel();
            this.button1EnterN = new System.Windows.Forms.Button();
            this.textN = new System.Windows.Forms.TextBox();
            this.label1N = new System.Windows.Forms.Label();
            this.panelThree = new System.Windows.Forms.Panel();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label3Result = new System.Windows.Forms.Label();
            this.button3BackToEnterXn = new System.Windows.Forms.Button();
            this.gridZn = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridXn)).BeginInit();
            this.panelOne.SuspendLayout();
            this.panelThree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTwo
            // 
            this.panelTwo.Controls.Add(this.button2Calculate);
            this.panelTwo.Controls.Add(this.button2BackToEnterN);
            this.panelTwo.Controls.Add(this.gridXn);
            this.panelTwo.Location = new System.Drawing.Point(13, 88);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(891, 118);
            this.panelTwo.TabIndex = 1;
            // 
            // button2Calculate
            // 
            this.button2Calculate.Location = new System.Drawing.Point(757, 62);
            this.button2Calculate.Name = "button2Calculate";
            this.button2Calculate.Size = new System.Drawing.Size(103, 34);
            this.button2Calculate.TabIndex = 2;
            this.button2Calculate.Text = "Расчёт";
            this.button2Calculate.UseVisualStyleBackColor = true;
            this.button2Calculate.Click += new System.EventHandler(this.button2Calculate_Click);
            // 
            // button2BackToEnterN
            // 
            this.button2BackToEnterN.Location = new System.Drawing.Point(757, 10);
            this.button2BackToEnterN.Name = "button2BackToEnterN";
            this.button2BackToEnterN.Size = new System.Drawing.Size(103, 45);
            this.button2BackToEnterN.TabIndex = 1;
            this.button2BackToEnterN.Text = "Изменить параметры";
            this.button2BackToEnterN.UseVisualStyleBackColor = true;
            this.button2BackToEnterN.Click += new System.EventHandler(this.button2BackToEnterN_Click);
            // 
            // gridXn
            // 
            this.gridXn.BackgroundColor = System.Drawing.Color.White;
            this.gridXn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridXn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gridXn.Location = new System.Drawing.Point(10, 10);
            this.gridXn.Name = "gridXn";
            this.gridXn.RowHeadersWidth = 51;
            this.gridXn.RowTemplate.Height = 24;
            this.gridXn.Size = new System.Drawing.Size(681, 86);
            this.gridXn.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // panelOne
            // 
            this.panelOne.Controls.Add(this.button1EnterN);
            this.panelOne.Controls.Add(this.textN);
            this.panelOne.Controls.Add(this.label1N);
            this.panelOne.Location = new System.Drawing.Point(12, 13);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(891, 69);
            this.panelOne.TabIndex = 0;
            // 
            // button1EnterN
            // 
            this.button1EnterN.Location = new System.Drawing.Point(198, 22);
            this.button1EnterN.Name = "button1EnterN";
            this.button1EnterN.Size = new System.Drawing.Size(75, 23);
            this.button1EnterN.TabIndex = 2;
            this.button1EnterN.Text = "Ввод";
            this.button1EnterN.UseVisualStyleBackColor = true;
            this.button1EnterN.Click += new System.EventHandler(this.button1EnterN_Click);
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(34, 23);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(100, 22);
            this.textN.TabIndex = 1;
            // 
            // label1N
            // 
            this.label1N.AutoSize = true;
            this.label1N.Location = new System.Drawing.Point(10, 23);
            this.label1N.Name = "label1N";
            this.label1N.Size = new System.Drawing.Size(17, 16);
            this.label1N.TabIndex = 0;
            this.label1N.Text = "N";
            // 
            // panelThree
            // 
            this.panelThree.Controls.Add(this.textResult);
            this.panelThree.Controls.Add(this.label3Result);
            this.panelThree.Controls.Add(this.button3BackToEnterXn);
            this.panelThree.Controls.Add(this.gridZn);
            this.panelThree.Location = new System.Drawing.Point(14, 212);
            this.panelThree.Name = "panelThree";
            this.panelThree.Size = new System.Drawing.Size(890, 120);
            this.panelThree.TabIndex = 2;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(737, 32);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(100, 22);
            this.textResult.TabIndex = 3;
            // 
            // label3Result
            // 
            this.label3Result.AutoSize = true;
            this.label3Result.Location = new System.Drawing.Point(650, 4);
            this.label3Result.Name = "label3Result";
            this.label3Result.Size = new System.Drawing.Size(226, 16);
            this.label3Result.TabIndex = 2;
            this.label3Result.Text = "Количество элементов кратных 4";
            // 
            // button3BackToEnterXn
            // 
            this.button3BackToEnterXn.Location = new System.Drawing.Point(718, 69);
            this.button3BackToEnterXn.Name = "button3BackToEnterXn";
            this.button3BackToEnterXn.Size = new System.Drawing.Size(141, 39);
            this.button3BackToEnterXn.TabIndex = 1;
            this.button3BackToEnterXn.Text = "Новый расчёт";
            this.button3BackToEnterXn.UseVisualStyleBackColor = true;
            this.button3BackToEnterXn.Click += new System.EventHandler(this.button3BackToEnterXn_Click);
            // 
            // gridZn
            // 
            this.gridZn.BackgroundColor = System.Drawing.Color.White;
            this.gridZn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridZn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.gridZn.Location = new System.Drawing.Point(9, 4);
            this.gridZn.Name = "gridZn";
            this.gridZn.RowHeadersWidth = 51;
            this.gridZn.RowTemplate.Height = 24;
            this.gridZn.Size = new System.Drawing.Size(584, 104);
            this.gridZn.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 336);
            this.Controls.Add(this.panelThree);
            this.Controls.Add(this.panelOne);
            this.Controls.Add(this.panelTwo);
            this.Name = "FormMain";
            this.Text = "Лабораторная работа 1. Вариант 16";
            this.panelTwo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridXn)).EndInit();
            this.panelOne.ResumeLayout(false);
            this.panelOne.PerformLayout();
            this.panelThree.ResumeLayout(false);
            this.panelThree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTwo;
        private System.Windows.Forms.DataGridView gridXn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panelOne;
        private System.Windows.Forms.Panel panelThree;
        private System.Windows.Forms.Button button1EnterN;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label label1N;
        private System.Windows.Forms.DataGridView gridZn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button2BackToEnterN;
        private System.Windows.Forms.Button button2Calculate;
        private System.Windows.Forms.Button button3BackToEnterXn;
        private System.Windows.Forms.Label label3Result;
        private System.Windows.Forms.TextBox textResult;
    }
}

