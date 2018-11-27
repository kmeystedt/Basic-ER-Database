namespace Emergancy_Room_Database
{
    partial class displayBillsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(displayBillsTable));
            this.eRDatabaseDataSet1 = new Emergancy_Room_Database.ERDatabaseDataSet1();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsTableAdapter = new Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.BillsTableAdapter();
            this.tableAdapterManager = new Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.billsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.billsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eRDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingNavigator)).BeginInit();
            this.billsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eRDatabaseDataSet1
            // 
            this.eRDatabaseDataSet1.DataSetName = "ERDatabaseDataSet1";
            this.eRDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "Bills";
            this.billsBindingSource.DataSource = this.eRDatabaseDataSet1;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillsTableAdapter = this.billsTableAdapter;
            this.tableAdapterManager.CallsTableAdapter = null;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // billsBindingNavigator
            // 
            this.billsBindingNavigator.AddNewItem = null;
            this.billsBindingNavigator.BindingSource = this.billsBindingSource;
            this.billsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.billsBindingNavigator.DeleteItem = null;
            this.billsBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.billsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.billsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.billsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.billsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.billsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.billsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.billsBindingNavigator.Name = "billsBindingNavigator";
            this.billsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.billsBindingNavigator.Size = new System.Drawing.Size(1589, 47);
            this.billsBindingNavigator.TabIndex = 0;
            this.billsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(87, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // billsDataGridView
            // 
            this.billsDataGridView.AllowUserToAddRows = false;
            this.billsDataGridView.AllowUserToDeleteRows = false;
            this.billsDataGridView.AutoGenerateColumns = false;
            this.billsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.billsDataGridView.DataSource = this.billsBindingSource;
            this.billsDataGridView.Location = new System.Drawing.Point(12, 186);
            this.billsDataGridView.Name = "billsDataGridView";
            this.billsDataGridView.RowTemplate.Height = 40;
            this.billsDataGridView.Size = new System.Drawing.Size(1565, 331);
            this.billsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Bill_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bill_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patient";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Bill_amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bill_amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Bill_payed";
            this.dataGridViewTextBoxColumn4.HeaderText = "Bill_payed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Payment_Method";
            this.dataGridViewTextBoxColumn5.HeaderText = "Payment_Method";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(12, 523);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(250, 114);
            this.returnBtn.TabIndex = 2;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bills";
            // 
            // displayBillsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.billsDataGridView);
            this.Controls.Add(this.billsBindingNavigator);
            this.Name = "displayBillsTable";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.displayBillsTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eRDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingNavigator)).EndInit();
            this.billsBindingNavigator.ResumeLayout(false);
            this.billsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERDatabaseDataSet1 eRDatabaseDataSet1;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private ERDatabaseDataSet1TableAdapters.BillsTableAdapter billsTableAdapter;
        private ERDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator billsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView billsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label1;
    }
}