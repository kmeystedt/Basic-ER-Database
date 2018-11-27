namespace Emergancy_Room_Database
{
    partial class updateRoomForm
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
            this.occupiedTB = new System.Windows.Forms.TextBox();
            this.staffIDTB = new System.Windows.Forms.TextBox();
            this.patientTB = new System.Windows.Forms.TextBox();
            this.doctorIDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // occupiedTB
            // 
            this.occupiedTB.Location = new System.Drawing.Point(361, 97);
            this.occupiedTB.Name = "occupiedTB";
            this.occupiedTB.Size = new System.Drawing.Size(100, 20);
            this.occupiedTB.TabIndex = 56;
            // 
            // staffIDTB
            // 
            this.staffIDTB.Location = new System.Drawing.Point(361, 55);
            this.staffIDTB.Name = "staffIDTB";
            this.staffIDTB.Size = new System.Drawing.Size(100, 20);
            this.staffIDTB.TabIndex = 55;
            // 
            // patientTB
            // 
            this.patientTB.Location = new System.Drawing.Point(125, 97);
            this.patientTB.Name = "patientTB";
            this.patientTB.Size = new System.Drawing.Size(100, 20);
            this.patientTB.TabIndex = 54;
            // 
            // doctorIDTB
            // 
            this.doctorIDTB.Location = new System.Drawing.Point(125, 55);
            this.doctorIDTB.Name = "doctorIDTB";
            this.doctorIDTB.Size = new System.Drawing.Size(100, 20);
            this.doctorIDTB.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Occupied:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Staff ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Patient ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Doctor ID:";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(428, 17);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(35, 13);
            this.IDlbl.TabIndex = 48;
            this.IDlbl.Text = "label9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Chosen ID: ";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(269, 153);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 40);
            this.returnBtn.TabIndex = 46;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(42, 153);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(1);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(88, 40);
            this.enterBtn.TabIndex = 45;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Enter Updated and Unchanged Data:";
            // 
            // updateCallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 239);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.occupiedTB);
            this.Controls.Add(this.staffIDTB);
            this.Controls.Add(this.patientTB);
            this.Controls.Add(this.doctorIDTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.enterBtn);
            this.Name = "updateCallsForm";
            this.Text = "updateCallsForm";
            this.Load += new System.EventHandler(this.updateCallsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox occupiedTB;
        private System.Windows.Forms.TextBox staffIDTB;
        private System.Windows.Forms.TextBox patientTB;
        private System.Windows.Forms.TextBox doctorIDTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label label7;
    }
}