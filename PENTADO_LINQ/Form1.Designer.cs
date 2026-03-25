namespace LinqExample
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnHighGrade;
        private System.Windows.Forms.Button btnIT;
        private System.Windows.Forms.Button btnNames;

        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dtg = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnHighGrade = new System.Windows.Forms.Button();
            this.btnIT = new System.Windows.Forms.Button();
            this.btnNames = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();

            // 
            // dtg
            // 
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ID,
                this.Name,
                this.Course,
                this.Age,
                this.Grade});
            this.dtg.Location = new System.Drawing.Point(20, 20);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(600, 250);
            this.dtg.TabIndex = 0;

            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";   // IMPORTANT
            this.ID.HeaderText = "ID";

            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";

            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Course";

            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";

            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";

            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(20, 290);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(120, 35);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnShowAll_Click);

            // 
            // btnHighGrade
            // 
            this.btnHighGrade.Location = new System.Drawing.Point(160, 290);
            this.btnHighGrade.Name = "btnHighGrade";
            this.btnHighGrade.Size = new System.Drawing.Size(120, 35);
            this.btnHighGrade.TabIndex = 2;
            this.btnHighGrade.Text = "Grade > 90";
            this.btnHighGrade.UseVisualStyleBackColor = true;
            this.btnHighGrade.Click += new System.EventHandler(this.btnHighGrade_Click);

            // 
            // btnIT
            // 
            this.btnIT.Location = new System.Drawing.Point(300, 290);
            this.btnIT.Name = "btnIT";
            this.btnIT.Size = new System.Drawing.Size(120, 35);
            this.btnIT.TabIndex = 3;
            this.btnIT.Text = "Course = IT";
            this.btnIT.UseVisualStyleBackColor = true;
            this.btnIT.Click += new System.EventHandler(this.btnIT_Click);

            // 
            // btnNames
            // 
            this.btnNames.Location = new System.Drawing.Point(440, 290);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(140, 35);
            this.btnNames.TabIndex = 4;
            this.btnNames.Text = "Names Only";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnHighGrade);
            this.Controls.Add(this.btnIT);
            this.Controls.Add(this.btnNames);
            this.Name = "Form1";
            this.Text = "LINQ Query Demo";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
