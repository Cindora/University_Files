namespace Lab3_1
{
    partial class FormEdClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edNumOfStudents = new System.Windows.Forms.TextBox();
            this.edGroupNum = new System.Windows.Forms.TextBox();
            this.edCapacity = new System.Windows.Forms.TextBox();
            this.edPairNumber = new System.Windows.Forms.TextBox();
            this.edSubject = new System.Windows.Forms.TextBox();
            this.cbLessonType = new System.Windows.Forms.ComboBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.cbWeekDay = new System.Windows.Forms.ComboBox();
            this.cbAudit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер пары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "День недели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Группа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Предмет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип занятия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вместимость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Число студентов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Номер аудитории";
            // 
            // edNumOfStudents
            // 
            this.edNumOfStudents.Location = new System.Drawing.Point(208, 304);
            this.edNumOfStudents.Name = "edNumOfStudents";
            this.edNumOfStudents.Size = new System.Drawing.Size(121, 22);
            this.edNumOfStudents.TabIndex = 9;
            // 
            // edGroupNum
            // 
            this.edGroupNum.Location = new System.Drawing.Point(208, 224);
            this.edGroupNum.Name = "edGroupNum";
            this.edGroupNum.Size = new System.Drawing.Size(121, 22);
            this.edGroupNum.TabIndex = 10;
            // 
            // edCapacity
            // 
            this.edCapacity.Location = new System.Drawing.Point(208, 184);
            this.edCapacity.Name = "edCapacity";
            this.edCapacity.Size = new System.Drawing.Size(121, 22);
            this.edCapacity.TabIndex = 11;
            // 
            // edPairNumber
            // 
            this.edPairNumber.Location = new System.Drawing.Point(208, 64);
            this.edPairNumber.Name = "edPairNumber";
            this.edPairNumber.Size = new System.Drawing.Size(121, 22);
            this.edPairNumber.TabIndex = 12;
            // 
            // edSubject
            // 
            this.edSubject.Location = new System.Drawing.Point(208, 147);
            this.edSubject.Name = "edSubject";
            this.edSubject.Size = new System.Drawing.Size(121, 22);
            this.edSubject.TabIndex = 14;
            // 
            // cbLessonType
            // 
            this.cbLessonType.FormattingEnabled = true;
            this.cbLessonType.Items.AddRange(new object[] {
            "Лекция",
            "Практика",
            "Лабораторная работа"});
            this.cbLessonType.Location = new System.Drawing.Point(208, 264);
            this.cbLessonType.Name = "cbLessonType";
            this.cbLessonType.Size = new System.Drawing.Size(121, 24);
            this.cbLessonType.TabIndex = 16;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(45, 372);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(120, 40);
            this.bOk.TabIndex = 17;
            this.bOk.Text = "Сохранить";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(228, 372);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(120, 40);
            this.bCancel.TabIndex = 18;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // cbWeekDay
            // 
            this.cbWeekDay.FormattingEnabled = true;
            this.cbWeekDay.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.cbWeekDay.Location = new System.Drawing.Point(208, 24);
            this.cbWeekDay.Name = "cbWeekDay";
            this.cbWeekDay.Size = new System.Drawing.Size(121, 24);
            this.cbWeekDay.TabIndex = 19;
            // 
            // cbAudit
            // 
            this.cbAudit.FormattingEnabled = true;
            this.cbAudit.Location = new System.Drawing.Point(208, 104);
            this.cbAudit.Name = "cbAudit";
            this.cbAudit.Size = new System.Drawing.Size(121, 24);
            this.cbAudit.TabIndex = 21;
            // 
            // FormEdClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.cbAudit);
            this.Controls.Add(this.cbWeekDay);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.cbLessonType);
            this.Controls.Add(this.edSubject);
            this.Controls.Add(this.edPairNumber);
            this.Controls.Add(this.edCapacity);
            this.Controls.Add(this.edGroupNum);
            this.Controls.Add(this.edNumOfStudents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEdClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEdClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        public System.Windows.Forms.TextBox edNumOfStudents;
        public System.Windows.Forms.TextBox edGroupNum;
        public System.Windows.Forms.TextBox edCapacity;
        public System.Windows.Forms.TextBox edPairNumber;
        public System.Windows.Forms.TextBox edSubject;
        public System.Windows.Forms.ComboBox cbLessonType;
        public System.Windows.Forms.ComboBox cbWeekDay;
        public System.Windows.Forms.ComboBox cbAudit;
    }
}