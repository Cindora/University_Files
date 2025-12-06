namespace Lab3_1
{
    partial class FormBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgBook = new System.Windows.Forms.DataGridView();
            this.bnBook = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSetClass = new Lab3_1.DataSetClass();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new Lab3_1.DataSetClassTableAdapters.classTableAdapter();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pairnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessontypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBook)).BeginInit();
            this.bnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBook
            // 
            this.dgBook.AutoGenerateColumns = false;
            this.dgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classidDataGridViewTextBoxColumn,
            this.weekdayDataGridViewTextBoxColumn,
            this.pairnumberDataGridViewTextBoxColumn,
            this.groupnumberDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.lessontypeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.studentsnumberDataGridViewTextBoxColumn,
            this.auditnumberDataGridViewTextBoxColumn});
            this.dgBook.DataSource = this.classBindingSource;
            this.dgBook.Location = new System.Drawing.Point(12, 120);
            this.dgBook.Name = "dgBook";
            this.dgBook.RowHeadersWidth = 51;
            this.dgBook.RowTemplate.Height = 24;
            this.dgBook.Size = new System.Drawing.Size(776, 150);
            this.dgBook.TabIndex = 0;
            // 
            // bnBook
            // 
            this.bnBook.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnBook.CountItem = this.bindingNavigatorCountItem;
            this.bnBook.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnBook.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnBook.Location = new System.Drawing.Point(0, 0);
            this.bnBook.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnBook.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnBook.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnBook.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnBook.Name = "bnBook";
            this.bnBook.PositionItem = this.bindingNavigatorPositionItem;
            this.bnBook.Size = new System.Drawing.Size(800, 31);
            this.bnBook.TabIndex = 1;
            this.bnBook.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 83);
            this.panel1.TabIndex = 2;
            // 
            // dataSetClass
            // 
            this.dataSetClass.DataSetName = "DataSetClass";
            this.dataSetClass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.dataSetClass;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "class_id";
            this.classidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            this.classidDataGridViewTextBoxColumn.Visible = false;
            this.classidDataGridViewTextBoxColumn.Width = 125;
            // 
            // weekdayDataGridViewTextBoxColumn
            // 
            this.weekdayDataGridViewTextBoxColumn.DataPropertyName = "week_day";
            this.weekdayDataGridViewTextBoxColumn.HeaderText = "День недели";
            this.weekdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weekdayDataGridViewTextBoxColumn.Name = "weekdayDataGridViewTextBoxColumn";
            this.weekdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // pairnumberDataGridViewTextBoxColumn
            // 
            this.pairnumberDataGridViewTextBoxColumn.DataPropertyName = "pair_number";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pairnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.pairnumberDataGridViewTextBoxColumn.HeaderText = "Номер пары";
            this.pairnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pairnumberDataGridViewTextBoxColumn.Name = "pairnumberDataGridViewTextBoxColumn";
            this.pairnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupnumberDataGridViewTextBoxColumn
            // 
            this.groupnumberDataGridViewTextBoxColumn.DataPropertyName = "group_number";
            this.groupnumberDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupnumberDataGridViewTextBoxColumn.Name = "groupnumberDataGridViewTextBoxColumn";
            this.groupnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessontypeDataGridViewTextBoxColumn
            // 
            this.lessontypeDataGridViewTextBoxColumn.DataPropertyName = "lesson_type";
            this.lessontypeDataGridViewTextBoxColumn.HeaderText = "Тип занятия";
            this.lessontypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lessontypeDataGridViewTextBoxColumn.Name = "lessontypeDataGridViewTextBoxColumn";
            this.lessontypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.capacityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentsnumberDataGridViewTextBoxColumn
            // 
            this.studentsnumberDataGridViewTextBoxColumn.DataPropertyName = "students_number";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.studentsnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentsnumberDataGridViewTextBoxColumn.HeaderText = "Число студентов";
            this.studentsnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentsnumberDataGridViewTextBoxColumn.Name = "studentsnumberDataGridViewTextBoxColumn";
            this.studentsnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // auditnumberDataGridViewTextBoxColumn
            // 
            this.auditnumberDataGridViewTextBoxColumn.DataPropertyName = "audit_number";
            this.auditnumberDataGridViewTextBoxColumn.HeaderText = "Аудитория";
            this.auditnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auditnumberDataGridViewTextBoxColumn.Name = "auditnumberDataGridViewTextBoxColumn";
            this.auditnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnBook);
            this.Controls.Add(this.dgBook);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.Load += new System.EventHandler(this.FormBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBook)).EndInit();
            this.bnBook.ResumeLayout(false);
            this.bnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBook;
        private System.Windows.Forms.BindingNavigator bnBook;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private DataSetClass dataSetClass;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DataSetClassTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pairnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessontypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditnumberDataGridViewTextBoxColumn;
    }
}