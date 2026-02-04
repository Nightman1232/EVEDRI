namespace ACT_6
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSelectPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblSelectStudents = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnNotify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(59, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Smart Classroom Notification System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(288, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSelectPriority
            // 
            this.lblSelectPriority.AutoSize = true;
            this.lblSelectPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPriority.Location = new System.Drawing.Point(36, 88);
            this.lblSelectPriority.Name = "lblSelectPriority";
            this.lblSelectPriority.Size = new System.Drawing.Size(141, 25);
            this.lblSelectPriority.TabIndex = 2;
            this.lblSelectPriority.Text = "Select Priority:";
            this.lblSelectPriority.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "",
            "",
            "Medium",
            "",
            "",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(41, 117);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 3;
            this.cmbPriority.Text = "Priority Selection";
            // 
            // lblSelectStudents
            // 
            this.lblSelectStudents.AutoSize = true;
            this.lblSelectStudents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStudents.Location = new System.Drawing.Point(36, 207);
            this.lblSelectStudents.Name = "lblSelectStudents";
            this.lblSelectStudents.Size = new System.Drawing.Size(153, 25);
            this.lblSelectStudents.TabIndex = 4;
            this.lblSelectStudents.Text = "Select Students:";
            this.lblSelectStudents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Items.AddRange(new object[] {
            "Alice",
            "",
            "Bob",
            "",
            "Charlie",
            "",
            "David",
            "",
            "Emma"});
            this.lstStudents.Location = new System.Drawing.Point(41, 249);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstStudents.Size = new System.Drawing.Size(148, 95);
            this.lstStudents.TabIndex = 5;
            // 
            // btnNotify
            // 
            this.btnNotify.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNotify.Location = new System.Drawing.Point(280, 274);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(136, 23);
            this.btnNotify.TabIndex = 6;
            this.btnNotify.Text = "Start Notifications";
            this.btnNotify.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.btnNotify);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lblSelectStudents);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblSelectPriority);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
           

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSelectPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblSelectStudents;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnNotify;
    }
}

