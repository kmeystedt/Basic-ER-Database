namespace Emergancy_Room_Database
{
    partial class chooseSearchDatabase
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.searchRoomsBtn = new System.Windows.Forms.Button();
            this.searchCallsBtn = new System.Windows.Forms.Button();
            this.searchBillsBtn = new System.Windows.Forms.Button();
            this.searchStaffBtn = new System.Windows.Forms.Button();
            this.searchPatientsBtn = new System.Windows.Forms.Button();
            this.searchDoctorsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(104, 170);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 40);
            this.returnBtn.TabIndex = 15;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // searchRoomsBtn
            // 
            this.searchRoomsBtn.Location = new System.Drawing.Point(195, 101);
            this.searchRoomsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.searchRoomsBtn.Name = "searchRoomsBtn";
            this.searchRoomsBtn.Size = new System.Drawing.Size(88, 40);
            this.searchRoomsBtn.TabIndex = 14;
            this.searchRoomsBtn.Text = "Rooms";
            this.searchRoomsBtn.UseVisualStyleBackColor = true;
            this.searchRoomsBtn.Click += new System.EventHandler(this.searchRoomsBtn_Click);
            // 
            // searchCallsBtn
            // 
            this.searchCallsBtn.Location = new System.Drawing.Point(104, 101);
            this.searchCallsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.searchCallsBtn.Name = "searchCallsBtn";
            this.searchCallsBtn.Size = new System.Drawing.Size(88, 40);
            this.searchCallsBtn.TabIndex = 13;
            this.searchCallsBtn.Text = "Calls";
            this.searchCallsBtn.UseVisualStyleBackColor = true;
            this.searchCallsBtn.Click += new System.EventHandler(this.searchCallsBtn_Click);
            // 
            // searchBillsBtn
            // 
            this.searchBillsBtn.Location = new System.Drawing.Point(13, 101);
            this.searchBillsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.searchBillsBtn.Name = "searchBillsBtn";
            this.searchBillsBtn.Size = new System.Drawing.Size(88, 40);
            this.searchBillsBtn.TabIndex = 12;
            this.searchBillsBtn.Text = "Bills";
            this.searchBillsBtn.UseVisualStyleBackColor = true;
            this.searchBillsBtn.Click += new System.EventHandler(this.searchBillsBtn_Click);
            // 
            // searchStaffBtn
            // 
            this.searchStaffBtn.Location = new System.Drawing.Point(195, 59);
            this.searchStaffBtn.Margin = new System.Windows.Forms.Padding(1);
            this.searchStaffBtn.Name = "searchStaffBtn";
            this.searchStaffBtn.Size = new System.Drawing.Size(88, 40);
            this.searchStaffBtn.TabIndex = 11;
            this.searchStaffBtn.Text = "Staff";
            this.searchStaffBtn.UseVisualStyleBackColor = true;
            this.searchStaffBtn.Click += new System.EventHandler(this.searchStaffBtn_Click);
            // 
            // searchPatientsBtn
            // 
            this.searchPatientsBtn.Location = new System.Drawing.Point(104, 59);
            this.searchPatientsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.searchPatientsBtn.Name = "searchPatientsBtn";
            this.searchPatientsBtn.Size = new System.Drawing.Size(88, 40);
            this.searchPatientsBtn.TabIndex = 10;
            this.searchPatientsBtn.Text = "Patients";
            this.searchPatientsBtn.UseVisualStyleBackColor = true;
            this.searchPatientsBtn.Click += new System.EventHandler(this.searchPatientsBtn_Click);
            // 
            // searchDoctorsBtn
            // 
            this.searchDoctorsBtn.Location = new System.Drawing.Point(13, 59);
            this.searchDoctorsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.searchDoctorsBtn.Name = "searchDoctorsBtn";
            this.searchDoctorsBtn.Size = new System.Drawing.Size(88, 40);
            this.searchDoctorsBtn.TabIndex = 9;
            this.searchDoctorsBtn.Text = "Doctors";
            this.searchDoctorsBtn.UseVisualStyleBackColor = true;
            this.searchDoctorsBtn.Click += new System.EventHandler(this.searchDoctorsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Table To Search:";
            // 
            // chooseSearchDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 234);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.searchRoomsBtn);
            this.Controls.Add(this.searchCallsBtn);
            this.Controls.Add(this.searchBillsBtn);
            this.Controls.Add(this.searchStaffBtn);
            this.Controls.Add(this.searchPatientsBtn);
            this.Controls.Add(this.searchDoctorsBtn);
            this.Controls.Add(this.label1);
            this.Name = "chooseSearchDatabase";
            this.Text = "chooseSearchDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button searchRoomsBtn;
        private System.Windows.Forms.Button searchCallsBtn;
        private System.Windows.Forms.Button searchBillsBtn;
        private System.Windows.Forms.Button searchStaffBtn;
        private System.Windows.Forms.Button searchPatientsBtn;
        private System.Windows.Forms.Button searchDoctorsBtn;
        private System.Windows.Forms.Label label1;
    }
}