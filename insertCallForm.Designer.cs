namespace Emergancy_Room_Database
{
    partial class insertCallForm
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
            this.insertBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.MITB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.reasonTB = new System.Windows.Forms.TextBox();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(626, 526);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(230, 83);
            this.returnBtn.TabIndex = 31;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(20, 517);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(242, 83);
            this.insertBtn.TabIndex = 30;
            this.insertBtn.Text = "Insert to Table";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(573, 55);
            this.label8.TabIndex = 29;
            this.label8.Text = "Insert New Call to Table:";
            // 
            // MITB
            // 
            this.MITB.Location = new System.Drawing.Point(235, 316);
            this.MITB.Name = "MITB";
            this.MITB.Size = new System.Drawing.Size(66, 38);
            this.MITB.TabIndex = 28;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(835, 222);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(685, 38);
            this.addressTB.TabIndex = 27;
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(235, 407);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(194, 38);
            this.lNameTB.TabIndex = 26;
            // 
            // reasonTB
            // 
            this.reasonTB.Location = new System.Drawing.Point(835, 313);
            this.reasonTB.Name = "reasonTB";
            this.reasonTB.Size = new System.Drawing.Size(685, 38);
            this.reasonTB.TabIndex = 25;
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(235, 222);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(194, 38);
            this.fNameTB.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Middle Initial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reason For Call:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // insertCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 712);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MITB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.reasonTB);
            this.Controls.Add(this.fNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "insertCallForm";
            this.Text = "insertCallForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MITB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox reasonTB;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}