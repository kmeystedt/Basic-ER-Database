namespace Emergancy_Room_Database
{
    partial class displayRoomsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(displayRoomsTable));
            this.label1 = new System.Windows.Forms.Label();
            this.eRDatabaseDataSet1 = new Emergancy_Room_Database.ERDatabaseDataSet1();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.RoomTableAdapter();
            this.tableAdapterManager = new Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.roomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eRDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingNavigator)).BeginInit();
            this.roomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms";
            // 
            // eRDatabaseDataSet1
            // 
            this.eRDatabaseDataSet1.DataSetName = "ERDatabaseDataSet1";
            this.eRDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.eRDatabaseDataSet1;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillsTableAdapter = null;
            this.tableAdapterManager.CallsTableAdapter = null;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = this.roomTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomBindingNavigator
            // 
            this.roomBindingNavigator.AddNewItem = null;
            this.roomBindingNavigator.BindingSource = this.roomBindingSource;
            this.roomBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomBindingNavigator.DeleteItem = null;
            this.roomBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.roomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.roomBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomBindingNavigator.Name = "roomBindingNavigator";
            this.roomBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.roomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomBindingNavigator.Size = new System.Drawing.Size(676, 47);
            this.roomBindingNavigator.TabIndex = 1;
            this.roomBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 44);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(21, 23);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Occupied";
            this.dataGridViewTextBoxColumn5.HeaderText = "Occupied";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patient";
            this.dataGridViewTextBoxColumn4.HeaderText = "Patient";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Staff";
            this.dataGridViewTextBoxColumn3.HeaderText = "Staff";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Doctor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Room_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Room_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AllowUserToDeleteRows = false;
            this.roomDataGridView.AutoGenerateColumns = false;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.roomDataGridView.DataSource = this.roomBindingSource;
            this.roomDataGridView.Location = new System.Drawing.Point(8, 75);
            this.roomDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.RowTemplate.Height = 40;
            this.roomDataGridView.Size = new System.Drawing.Size(582, 181);
            this.roomDataGridView.TabIndex = 2;
            // 
            // displayRoomsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomDataGridView);
            this.Controls.Add(this.roomBindingNavigator);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "displayRoomsTable";
            this.Text = "displayRoomsTable";
            this.Load += new System.EventHandler(this.displayRoomsTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eRDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingNavigator)).EndInit();
            this.roomBindingNavigator.ResumeLayout(false);
            this.roomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ERDatabaseDataSet1 eRDatabaseDataSet1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private ERDatabaseDataSet1TableAdapters.RoomTableAdapter roomTableAdapter;
        private ERDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roomBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView roomDataGridView;
    }
}