namespace Emergancy_Room_Database
{
    partial class FormMain
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
            this.tableAdapterManager = new Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayTableBtn = new System.Windows.Forms.Button();
            this.insertTableBtn = new System.Windows.Forms.Button();
            this.updateTableBtn = new System.Windows.Forms.Button();
            this.deleteFromTableBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillsTableAdapter = null;
            this.tableAdapterManager.CallsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Emergancy_Room_Database.ERDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cape Girardeau Hospital ER Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose one:";
            // 
            // displayTableBtn
            // 
            this.displayTableBtn.Location = new System.Drawing.Point(44, 89);
            this.displayTableBtn.Margin = new System.Windows.Forms.Padding(1);
            this.displayTableBtn.Name = "displayTableBtn";
            this.displayTableBtn.Size = new System.Drawing.Size(82, 36);
            this.displayTableBtn.TabIndex = 2;
            this.displayTableBtn.Text = "Display Entire Table";
            this.displayTableBtn.UseVisualStyleBackColor = true;
            this.displayTableBtn.Click += new System.EventHandler(this.displayTableBtn_Click);
            // 
            // insertTableBtn
            // 
            this.insertTableBtn.Location = new System.Drawing.Point(129, 89);
            this.insertTableBtn.Margin = new System.Windows.Forms.Padding(1);
            this.insertTableBtn.Name = "insertTableBtn";
            this.insertTableBtn.Size = new System.Drawing.Size(77, 36);
            this.insertTableBtn.TabIndex = 3;
            this.insertTableBtn.Text = "Insert Into Table";
            this.insertTableBtn.UseVisualStyleBackColor = true;
            this.insertTableBtn.Click += new System.EventHandler(this.insertTableBtn_Click);
            // 
            // updateTableBtn
            // 
            this.updateTableBtn.Location = new System.Drawing.Point(44, 128);
            this.updateTableBtn.Margin = new System.Windows.Forms.Padding(1);
            this.updateTableBtn.Name = "updateTableBtn";
            this.updateTableBtn.Size = new System.Drawing.Size(82, 36);
            this.updateTableBtn.TabIndex = 4;
            this.updateTableBtn.Text = "Update Table";
            this.updateTableBtn.UseVisualStyleBackColor = true;
            this.updateTableBtn.Click += new System.EventHandler(this.updateTableBtn_Click);
            // 
            // deleteFromTableBtn
            // 
            this.deleteFromTableBtn.Location = new System.Drawing.Point(129, 128);
            this.deleteFromTableBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deleteFromTableBtn.Name = "deleteFromTableBtn";
            this.deleteFromTableBtn.Size = new System.Drawing.Size(77, 36);
            this.deleteFromTableBtn.TabIndex = 5;
            this.deleteFromTableBtn.Text = "Delete From Table";
            this.deleteFromTableBtn.UseVisualStyleBackColor = true;
            this.deleteFromTableBtn.Click += new System.EventHandler(this.deleteFromTableBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(208, 90);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(1);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(77, 36);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search Database";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(208, 128);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(77, 36);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 184);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteFromTableBtn);
            this.Controls.Add(this.updateTableBtn);
            this.Controls.Add(this.insertTableBtn);
            this.Controls.Add(this.displayTableBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormMain";
            this.Text = "Emergency Room";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ERDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button displayTableBtn;
        private System.Windows.Forms.Button insertTableBtn;
        private System.Windows.Forms.Button updateTableBtn;
        private System.Windows.Forms.Button deleteFromTableBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

