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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClass));
            this.dgClass = new System.Windows.Forms.DataGridView();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pairnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessontypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.bFilter = new System.Windows.Forms.Button();
            this.edNum2 = new System.Windows.Forms.TextBox();
            this.edNum1 = new System.Windows.Forms.TextBox();
            this.edAudit = new System.Windows.Forms.TextBox();
            this.edCap2 = new System.Windows.Forms.TextBox();
            this.edCap1 = new System.Windows.Forms.TextBox();
            this.edType = new System.Windows.Forms.TextBox();
            this.edSubject = new System.Windows.Forms.TextBox();
            this.edGroup = new System.Windows.Forms.TextBox();
            this.edPair = new System.Windows.Forms.TextBox();
            this.edDay = new System.Windows.Forms.TextBox();
            this.classTableAdapter = new Lab3_1.DataSetClassTableAdapters.classTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnClass)).BeginInit();
            this.bnClass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClass
            // 
            this.dgClass.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgClass.Location = new System.Drawing.Point(12, 143);
            this.dgClass.Name = "dgClass";
            this.dgClass.RowHeadersWidth = 51;
            this.dgClass.RowTemplate.Height = 24;
            this.dgClass.Size = new System.Drawing.Size(1421, 295);
            this.dgClass.TabIndex = 0;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pairnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.capacityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentsnumberDataGridViewTextBoxColumn
            // 
            this.studentsnumberDataGridViewTextBoxColumn.DataPropertyName = "students_number";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.studentsnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.bnClass.Size = new System.Drawing.Size(1445, 27);
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
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bClear);
            this.panel1.Controls.Add(this.bFilter);
            this.panel1.Controls.Add(this.edNum2);
            this.panel1.Controls.Add(this.edNum1);
            this.panel1.Controls.Add(this.edAudit);
            this.panel1.Controls.Add(this.edCap2);
            this.panel1.Controls.Add(this.edCap1);
            this.panel1.Controls.Add(this.edType);
            this.panel1.Controls.Add(this.edSubject);
            this.panel1.Controls.Add(this.edGroup);
            this.panel1.Controls.Add(this.edPair);
            this.panel1.Controls.Add(this.edDay);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 106);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(946, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Аудитория";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Число студентов\r\n      от            до\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "   Вместимость\r\n      от            до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Тип занятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Номер пары";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "День недели";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(224, 14);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(126, 30);
            this.bClear.TabIndex = 10;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bFilter
            // 
            this.bFilter.Location = new System.Drawing.Point(62, 14);
            this.bFilter.Name = "bFilter";
            this.bFilter.Size = new System.Drawing.Size(120, 30);
            this.bFilter.TabIndex = 3;
            this.bFilter.Text = "Фильтровать";
            this.bFilter.UseVisualStyleBackColor = true;
            this.bFilter.Click += new System.EventHandler(this.bFilter_Click);
            // 
            // edNum2
            // 
            this.edNum2.Location = new System.Drawing.Point(866, 81);
            this.edNum2.Name = "edNum2";
            this.edNum2.Size = new System.Drawing.Size(50, 22);
            this.edNum2.TabIndex = 9;
            // 
            // edNum1
            // 
            this.edNum1.Location = new System.Drawing.Point(810, 81);
            this.edNum1.Name = "edNum1";
            this.edNum1.Size = new System.Drawing.Size(50, 22);
            this.edNum1.TabIndex = 8;
            // 
            // edAudit
            // 
            this.edAudit.Location = new System.Drawing.Point(937, 81);
            this.edAudit.Name = "edAudit";
            this.edAudit.Size = new System.Drawing.Size(100, 22);
            this.edAudit.TabIndex = 7;
            // 
            // edCap2
            // 
            this.edCap2.Location = new System.Drawing.Point(738, 81);
            this.edCap2.Name = "edCap2";
            this.edCap2.Size = new System.Drawing.Size(50, 22);
            this.edCap2.TabIndex = 6;
            // 
            // edCap1
            // 
            this.edCap1.Location = new System.Drawing.Point(682, 81);
            this.edCap1.Name = "edCap1";
            this.edCap1.Size = new System.Drawing.Size(50, 22);
            this.edCap1.TabIndex = 5;
            // 
            // edType
            // 
            this.edType.Location = new System.Drawing.Point(558, 81);
            this.edType.Name = "edType";
            this.edType.Size = new System.Drawing.Size(100, 22);
            this.edType.TabIndex = 4;
            // 
            // edSubject
            // 
            this.edSubject.Location = new System.Drawing.Point(439, 81);
            this.edSubject.Name = "edSubject";
            this.edSubject.Size = new System.Drawing.Size(100, 22);
            this.edSubject.TabIndex = 3;
            // 
            // edGroup
            // 
            this.edGroup.Location = new System.Drawing.Point(314, 81);
            this.edGroup.Name = "edGroup";
            this.edGroup.Size = new System.Drawing.Size(100, 22);
            this.edGroup.TabIndex = 2;
            // 
            // edPair
            // 
            this.edPair.Location = new System.Drawing.Point(185, 81);
            this.edPair.Name = "edPair";
            this.edPair.Size = new System.Drawing.Size(100, 22);
            this.edPair.TabIndex = 1;
            // 
            // edDay
            // 
            this.edDay.Location = new System.Drawing.Point(62, 81);
            this.edDay.Name = "edDay";
            this.edDay.Size = new System.Drawing.Size(100, 22);
            this.edDay.TabIndex = 0;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 450);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox edNum1;
        private System.Windows.Forms.TextBox edAudit;
        private System.Windows.Forms.TextBox edCap2;
        private System.Windows.Forms.TextBox edCap1;
        private System.Windows.Forms.TextBox edType;
        private System.Windows.Forms.TextBox edSubject;
        private System.Windows.Forms.TextBox edGroup;
        private System.Windows.Forms.TextBox edPair;
        private System.Windows.Forms.TextBox edDay;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bFilter;
        private System.Windows.Forms.TextBox edNum2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}