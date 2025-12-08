namespace Lab3_1
{
    partial class FormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClass));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgClass = new System.Windows.Forms.DataGridView();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClass = new Lab3_1.DataSetClass();
            this.bnClass = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sbAdd = new System.Windows.Forms.ToolStripButton();
            this.sbEdit = new System.Windows.Forms.ToolStripButton();
            this.sbDelete = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnClass)).BeginInit();
            this.bnClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClass
            // 
            this.dgClass.AutoGenerateColumns = false;
            this.dgClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classidDataGridViewTextBoxColumn,
            this.weekdayDataGridViewTextBoxColumn,
            this.pairnumberDataGridViewTextBoxColumn,
            this.groupnumberDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.lessontypeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.studentsnumberDataGridViewTextBoxColumn,
            this.auditnumberDataGridViewTextBoxColumn});
            this.dgClass.DataSource = this.classBindingSource;
            this.dgClass.Location = new System.Drawing.Point(12, 120);
            this.dgClass.Name = "dgClass";
            this.dgClass.RowHeadersWidth = 51;
            this.dgClass.RowTemplate.Height = 24;
            this.dgClass.Size = new System.Drawing.Size(1053, 150);
            this.dgClass.TabIndex = 0;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.dataSetClass;
            // 
            // dataSetClass
            // 
            this.dataSetClass.DataSetName = "DataSetClass";
            this.dataSetClass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bnClass
            // 
            this.bnClass.AddNewItem = null;
            this.bnClass.CountItem = this.bindingNavigatorCountItem;
            this.bnClass.DeleteItem = null;
            this.bnClass.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.sbAdd,
            this.sbEdit,
            this.sbDelete});
            this.bnClass.Location = new System.Drawing.Point(0, 0);
            this.bnClass.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnClass.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnClass.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnClass.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnClass.Name = "bnClass";
            this.bnClass.PositionItem = this.bindingNavigatorPositionItem;
            this.bnClass.Size = new System.Drawing.Size(1075, 27);
            this.bnClass.TabIndex = 1;
            this.bnClass.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sbAdd
            // 
            this.sbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbAdd.Image = ((System.Drawing.Image)(resources.GetObject("sbAdd.Image")));
            this.sbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(29, 24);
            this.sbAdd.Text = "sbAdd";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // sbEdit
            // 
            this.sbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbEdit.Image = ((System.Drawing.Image)(resources.GetObject("sbEdit.Image")));
            this.sbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbEdit.Name = "sbEdit";
            this.sbEdit.Size = new System.Drawing.Size(29, 24);
            this.sbEdit.Text = "sbEdit";
            this.sbEdit.Click += new System.EventHandler(this.sbEdit_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbDelete.Image = ((System.Drawing.Image)(resources.GetObject("sbDelete.Image")));
            this.sbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(29, 24);
            this.sbDelete.Text = "sbDelete";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 83);
            this.panel1.TabIndex = 2;
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
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnClass);
            this.Controls.Add(this.dgClass);
            this.Name = "FormClass";
            this.Text = "Занятия";
            this.Load += new System.EventHandler(this.FormClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnClass)).EndInit();
            this.bnClass.ResumeLayout(false);
            this.bnClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClass;
        private System.Windows.Forms.BindingNavigator bnClass;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
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
        private System.Windows.Forms.ToolStripButton sbAdd;
        private System.Windows.Forms.ToolStripButton sbEdit;
        private System.Windows.Forms.ToolStripButton sbDelete;
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