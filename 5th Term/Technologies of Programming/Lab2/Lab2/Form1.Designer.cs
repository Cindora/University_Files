namespace Lab2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSort = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDiscount = new System.Windows.Forms.TextBox();
            this.textPriseWithDiscount = new System.Windows.Forms.TextBox();
            this.buttonCalcPriceWithDisc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonNumber2 = new System.Windows.Forms.RadioButton();
            this.radioButtonNumber1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textSelected = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сорт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(104, 37);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 3;
            // 
            // textSort
            // 
            this.textSort.Location = new System.Drawing.Point(104, 77);
            this.textSort.Name = "textSort";
            this.textSort.Size = new System.Drawing.Size(100, 22);
            this.textSort.TabIndex = 4;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(104, 120);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 22);
            this.textPrice.TabIndex = 5;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(116, 167);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 34);
            this.buttonInput.TabIndex = 6;
            this.buttonInput.Text = "Ввод";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Скидка (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цена со скидкой";
            // 
            // textDiscount
            // 
            this.textDiscount.Location = new System.Drawing.Point(148, 242);
            this.textDiscount.Name = "textDiscount";
            this.textDiscount.Size = new System.Drawing.Size(100, 22);
            this.textDiscount.TabIndex = 10;
            // 
            // textPriseWithDiscount
            // 
            this.textPriseWithDiscount.Location = new System.Drawing.Point(148, 313);
            this.textPriseWithDiscount.Name = "textPriseWithDiscount";
            this.textPriseWithDiscount.Size = new System.Drawing.Size(129, 22);
            this.textPriseWithDiscount.TabIndex = 11;
            // 
            // buttonCalcPriceWithDisc
            // 
            this.buttonCalcPriceWithDisc.Location = new System.Drawing.Point(58, 277);
            this.buttonCalcPriceWithDisc.Name = "buttonCalcPriceWithDisc";
            this.buttonCalcPriceWithDisc.Size = new System.Drawing.Size(159, 23);
            this.buttonCalcPriceWithDisc.TabIndex = 12;
            this.buttonCalcPriceWithDisc.Text = "Рассчитать скидку";
            this.buttonCalcPriceWithDisc.UseVisualStyleBackColor = true;
            this.buttonCalcPriceWithDisc.Click += new System.EventHandler(this.buttonCalcPriceWithDisc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNumber2);
            this.panel1.Controls.Add(this.radioButtonNumber1);
            this.panel1.Location = new System.Drawing.Point(333, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 13;
            // 
            // radioButtonNumber2
            // 
            this.radioButtonNumber2.AutoSize = true;
            this.radioButtonNumber2.Location = new System.Drawing.Point(125, 14);
            this.radioButtonNumber2.Name = "radioButtonNumber2";
            this.radioButtonNumber2.Size = new System.Drawing.Size(49, 20);
            this.radioButtonNumber2.TabIndex = 1;
            this.radioButtonNumber2.TabStop = true;
            this.radioButtonNumber2.Text = "№2";
            this.radioButtonNumber2.UseVisualStyleBackColor = true;
            this.radioButtonNumber2.CheckedChanged += new System.EventHandler(this.radioButtonNumber2_CheckedChanged);
            // 
            // radioButtonNumber1
            // 
            this.radioButtonNumber1.AutoSize = true;
            this.radioButtonNumber1.Location = new System.Drawing.Point(27, 14);
            this.radioButtonNumber1.Name = "radioButtonNumber1";
            this.radioButtonNumber1.Size = new System.Drawing.Size(49, 20);
            this.radioButtonNumber1.TabIndex = 0;
            this.radioButtonNumber1.TabStop = true;
            this.radioButtonNumber1.Text = "№1";
            this.radioButtonNumber1.UseVisualStyleBackColor = true;
            this.radioButtonNumber1.CheckedChanged += new System.EventHandler(this.radioButtonNumber1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выбран:";
            // 
            // textSelected
            // 
            this.textSelected.Location = new System.Drawing.Point(423, 108);
            this.textSelected.Name = "textSelected";
            this.textSelected.Size = new System.Drawing.Size(55, 22);
            this.textSelected.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCalcPriceWithDisc);
            this.Controls.Add(this.textPriseWithDiscount);
            this.Controls.Add(this.textDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textSort);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSort;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDiscount;
        private System.Windows.Forms.TextBox textPriseWithDiscount;
        private System.Windows.Forms.Button buttonCalcPriceWithDisc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonNumber2;
        private System.Windows.Forms.RadioButton radioButtonNumber1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSelected;
    }
}

