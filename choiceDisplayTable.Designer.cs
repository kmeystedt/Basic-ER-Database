namespace Emergancy_Room_Database
{
    partial class choiceDisplayTable
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
            this.displayDoctorsBtn = new System.Windows.Forms.Button();
            this.displayPatientsBtn = new System.Windows.Forms.Button();
            this.displayStaffBtn = new System.Windows.Forms.Button();
            this.displayRoomsBtn = new System.Windows.Forms.Button();
            this.displayCallsBtn = new System.Windows.Forms.Button();
            this.displayBillsBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Table To Display:";
            // 
            // displayDoctorsBtn
            // 
            this.displayDoctorsBtn.Location = new System.Drawing.Point(97, 173);
            this.displayDoctorsBtn.Name = "displayDoctorsBtn";
            this.displayDoctorsBtn.Size = new System.Drawing.Size(236, 95);
            this.displayDoctorsBtn.TabIndex = 1;
            this.displayDoctorsBtn.Text = "Doctors";
            this.displayDoctorsBtn.UseVisualStyleBackColor = true;
            this.displayDoctorsBtn.Click += new System.EventHandler(this.displayDoctorsBtn_Click);
            // 
            // displayPatientsBtn
            // 
            this.displayPatientsBtn.Location = new System.Drawing.Point(339, 173);
            this.displayPatientsBtn.Name = "displayPatientsBtn";
            this.displayPatientsBtn.Size = new System.Drawing.Size(236, 95);
            this.displayPatientsBtn.TabIndex = 2;
            this.displayPatientsBtn.Text = "Patients";
            this.displayPatientsBtn.UseVisualStyleBackColor = true;
            this.displayPatientsBtn.Click += new System.EventHandler(this.displayPatientsBtn_Click);
            // 
            // displayStaffBtn
            // 
            this.displayStaffBtn.Location = new System.Drawing.Point(581, 173);
            this.displayStaffBtn.Name = "displayStaffBtn";
            this.displayStaffBtn.Size = new System.Drawing.Size(236, 95);
            this.displayStaffBtn.TabIndex = 3;
            this.displayStaffBtn.Text = "Staff";
            this.displayStaffBtn.UseVisualStyleBackColor = true;
            this.displayStaffBtn.Click += new System.EventHandler(this.displayStaffBtn_Click);
            // 
            // displayRoomsBtn
            // 
            this.displayRoomsBtn.Location = new System.Drawing.Point(581, 274);
            this.displayRoomsBtn.Name = "displayRoomsBtn";
            this.displayRoomsBtn.Size = new System.Drawing.Size(236, 95);
            this.displayRoomsBtn.TabIndex = 6;
            this.displayRoomsBtn.Text = "Rooms";
            this.displayRoomsBtn.UseVisualStyleBackColor = true;
            this.displayRoomsBtn.Click += new System.EventHandler(this.displayRoomsBtn_Click);
            // 
            // displayCallsBtn
            // 
            this.displayCallsBtn.Location = new System.Drawing.Point(339, 274);
            this.displayCallsBtn.Name = "displayCallsBtn";
            this.displayCallsBtn.Size = new System.Drawing.Size(236, 95);
            this.displayCallsBtn.TabIndex = 5;
            this.displayCallsBtn.Text = "Calls";
            this.displayCallsBtn.UseVisualStyleBackColor = true;
            this.displayCallsBtn.Click += new System.EventHandler(this.displayCallsBtn_Click);
            // 
            // displayBillsBtn
            // 
            this.displayBillsBtn.Location = new System.Drawing.Point(97, 274);
            this.displayBillsBtn.Name = "displayBillsBtn";
            this.displayBillsBtn.Size = new System.Drawing.Size(236, 95);
            this.displayBillsBtn.TabIndex = 4;
            this.displayBillsBtn.Text = "Bills";
            this.displayBillsBtn.UseVisualStyleBackColor = true;
            this.displayBillsBtn.Click += new System.EventHandler(this.displayBillsBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(339, 438);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(236, 95);
            this.returnBtn.TabIndex = 7;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // displayTableChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 545);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.displayRoomsBtn);
            this.Controls.Add(this.displayCallsBtn);
            this.Controls.Add(this.displayBillsBtn);
            this.Controls.Add(this.displayStaffBtn);
            this.Controls.Add(this.displayPatientsBtn);
            this.Controls.Add(this.displayDoctorsBtn);
            this.Controls.Add(this.label1);
            this.Name = "displayTableChoice";
            this.Text = "displayTableChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayDoctorsBtn;
        private System.Windows.Forms.Button displayPatientsBtn;
        private System.Windows.Forms.Button displayStaffBtn;
        private System.Windows.Forms.Button displayRoomsBtn;
        private System.Windows.Forms.Button displayCallsBtn;
        private System.Windows.Forms.Button displayBillsBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}