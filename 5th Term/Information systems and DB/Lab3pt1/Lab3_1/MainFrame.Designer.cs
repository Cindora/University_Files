namespace Lab3_1
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.imgRaspisanie = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгаЗаниятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgRaspisanie)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgRaspisanie
            // 
            this.imgRaspisanie.ErrorImage = null;
            this.imgRaspisanie.Image = ((System.Drawing.Image)(resources.GetObject("imgRaspisanie.Image")));
            this.imgRaspisanie.ImageLocation = "";
            this.imgRaspisanie.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgRaspisanie.InitialImage")));
            this.imgRaspisanie.Location = new System.Drawing.Point(75, 70);
            this.imgRaspisanie.Name = "imgRaspisanie";
            this.imgRaspisanie.Size = new System.Drawing.Size(397, 235);
            this.imgRaspisanie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRaspisanie.TabIndex = 0;
            this.imgRaspisanie.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.miExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Меню";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.справочникToolStripMenuItem.Text = "Справочник";
            this.справочникToolStripMenuItem.Click += new System.EventHandler(this.mSprav_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгаЗаниятийToolStripMenuItem,
            this.отчётToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // книгаЗаниятийToolStripMenuItem
            // 
            this.книгаЗаниятийToolStripMenuItem.Name = "книгаЗаниятийToolStripMenuItem";
            this.книгаЗаниятийToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.книгаЗаниятийToolStripMenuItem.Text = "Книга заниятий";
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(67, 24);
            this.miExit.Text = "Выход";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 352);
            this.Controls.Add(this.imgRaspisanie);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.Text = "Расписание занятий";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRaspisanie)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgRaspisanie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгаЗаниятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
    }
}

