namespace Lab7
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
            this.btnBars = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBars
            // 
            this.btnBars.Location = new System.Drawing.Point(103, 12);
            this.btnBars.Name = "btnBars";
            this.btnBars.Size = new System.Drawing.Size(206, 39);
            this.btnBars.TabIndex = 0;
            this.btnBars.Text = "Построить столбцы";
            this.btnBars.UseVisualStyleBackColor = true;
            this.btnBars.Click += new System.EventHandler(this.btnBars_Click_1);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(518, 13);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(211, 40);
            this.btnGraph.TabIndex = 1;
            this.btnGraph.Text = "Построить график";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnBars);
            this.Name = "MainForm";
            this.Text = "Lab7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBars;
        private System.Windows.Forms.Button btnGraph;
    }
}

