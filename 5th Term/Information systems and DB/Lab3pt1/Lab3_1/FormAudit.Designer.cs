namespace Lab3_1
{
    partial class FormAudit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAudit));
            this.dgAudit = new System.Windows.Forms.DataGridView();
            this.auditnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corpsnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab3_1.DataSet1();
            this.bnavAudit = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.auditTableAdapter = new Lab3_1.DataSet1TableAdapters.auditTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnavAudit)).BeginInit();
            this.bnavAudit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAudit
            // 
            this.dgAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAudit.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAudit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAudit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auditnumberDataGridViewTextBoxColumn,
            this.corpsnumberDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn});
            this.dgAudit.DataSource = this.auditBindingSource;
            this.dgAudit.Location = new System.Drawing.Point(12, 30);
            this.dgAudit.Name = "dgAudit";
            this.dgAudit.RowHeadersWidth = 51;
            this.dgAudit.RowTemplate.Height = 24;
            this.dgAudit.Size = new System.Drawing.Size(776, 408);
            this.dgAudit.TabIndex = 0;
            this.dgAudit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // auditnumberDataGridViewTextBoxColumn
            // 
            this.auditnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.auditnumberDataGridViewTextBoxColumn.DataPropertyName = "audit_number";
            this.auditnumberDataGridViewTextBoxColumn.HeaderText = "Номер аудитории";
            this.auditnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auditnumberDataGridViewTextBoxColumn.Name = "auditnumberDataGridViewTextBoxColumn";
            // 
            // corpsnumberDataGridViewTextBoxColumn
            // 
            this.corpsnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.corpsnumberDataGridViewTextBoxColumn.DataPropertyName = "corps_number";
            this.corpsnumberDataGridViewTextBoxColumn.HeaderText = "Номер корпуса";
            this.corpsnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.corpsnumberDataGridViewTextBoxColumn.Name = "corpsnumberDataGridViewTextBoxColumn";
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.floorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // auditBindingSource
            // 
            this.auditBindingSource.DataMember = "audit";
            this.auditBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bnavAudit
            // 
            this.bnavAudit.AddNewItem = null;
            this.bnavAudit.CountItem = this.bindingNavigatorCountItem;
            this.bnavAudit.DeleteItem = null;
            this.bnavAudit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnavAudit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnavAudit.Location = new System.Drawing.Point(0, 0);
            this.bnavAudit.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnavAudit.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnavAudit.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnavAudit.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnavAudit.Name = "bnavAudit";
            this.bnavAudit.PositionItem = this.bindingNavigatorPositionItem;
            this.bnavAudit.Size = new System.Drawing.Size(800, 31);
            this.bnavAudit.TabIndex = 1;
            this.bnavAudit.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // sbAdd
            // 
            this.sbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbAdd.Image = ((System.Drawing.Image)(resources.GetObject("sbAdd.Image")));
            this.sbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(29, 28);
            this.sbAdd.Text = "toolStripButton1";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // sbEdit
            // 
            this.sbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbEdit.Image = ((System.Drawing.Image)(resources.GetObject("sbEdit.Image")));
            this.sbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbEdit.Name = "sbEdit";
            this.sbEdit.Size = new System.Drawing.Size(29, 28);
            this.sbEdit.Text = "toolStripButton2";
            this.sbEdit.Click += new System.EventHandler(this.sbEdit_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbDelete.Image = ((System.Drawing.Image)(resources.GetObject("sbDelete.Image")));
            this.sbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(29, 28);
            this.sbDelete.Text = "toolStripButton3";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // auditTableAdapter
            // 
            this.auditTableAdapter.ClearBeforeFill = true;
            // 
            // FormAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnavAudit);
            this.Controls.Add(this.dgAudit);
            this.Name = "FormAudit";
            this.Text = "Аудитории";
            this.Load += new System.EventHandler(this.FormAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnavAudit)).EndInit();
            this.bnavAudit.ResumeLayout(false);
            this.bnavAudit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAudit;
        private System.Windows.Forms.BindingNavigator bnavAudit;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource auditBindingSource;
        private DataSet1TableAdapters.auditTableAdapter auditTableAdapter;
        private System.Windows.Forms.ToolStripButton sbAdd;
        private System.Windows.Forms.ToolStripButton sbEdit;
        private System.Windows.Forms.ToolStripButton sbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corpsnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
    }
}