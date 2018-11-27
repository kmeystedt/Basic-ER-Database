﻿namespace Emergancy_Room_Database
{
    partial class searchPatientByIDDisplay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRDatabaseDataSet1 = new Emergancy_Room_Database.ERDatabaseDataSet1();
            this.IDlbl = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patientsTableAdapter = new Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.PatientsTableAdapter();
            this.tableAdapterManager = new Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.mintDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn,
            this.perscriptionDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.callidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1438, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "Patient_Id";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "Patient_Id";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // mintDataGridViewTextBoxColumn
            // 
            this.mintDataGridViewTextBoxColumn.DataPropertyName = "Mint";
            this.mintDataGridViewTextBoxColumn.HeaderText = "Mint";
            this.mintDataGridViewTextBoxColumn.Name = "mintDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room#";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room#";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.DataPropertyName = "Bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "Bill";
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            // 
            // perscriptionDataGridViewTextBoxColumn
            // 
            this.perscriptionDataGridViewTextBoxColumn.DataPropertyName = "Perscription";
            this.perscriptionDataGridViewTextBoxColumn.HeaderText = "Perscription";
            this.perscriptionDataGridViewTextBoxColumn.Name = "perscriptionDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            // 
            // callidDataGridViewTextBoxColumn
            // 
            this.callidDataGridViewTextBoxColumn.DataPropertyName = "Call_id";
            this.callidDataGridViewTextBoxColumn.HeaderText = "Call_id";
            this.callidDataGridViewTextBoxColumn.Name = "callidDataGridViewTextBoxColumn";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.eRDatabaseDataSet1;
            // 
            // eRDatabaseDataSet1
            // 
            this.eRDatabaseDataSet1.DataSetName = "ERDatabaseDataSet1";
            this.eRDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(157, 9);
            this.IDlbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(22, 24);
            this.IDlbl.TabIndex = 33;
            this.IDlbl.Text = "d";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(517, 246);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 40);
            this.returnBtn.TabIndex = 32;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Patient of ID:";
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillsTableAdapter = null;
            this.tableAdapterManager.CallsTableAdapter = null;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // searchPatientByIDDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 306);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Name = "searchPatientByIDDisplay";
            this.Text = "searchPatientByIDDisplay";
            this.Load += new System.EventHandler(this.searchPatientByIDDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label1;
        private ERDatabaseDataSet1 eRDatabaseDataSet1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private ERDatabaseDataSet1TableAdapters.PatientsTableAdapter patientsTableAdapter;
        private ERDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callidDataGridViewTextBoxColumn;
    }
}