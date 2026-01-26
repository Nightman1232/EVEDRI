namespace PENTADO_Lambda
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
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblenterquantity = new System.Windows.Forms.Label();
            this.txtQuantityinput = new System.Windows.Forms.TextBox();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOrdercheaker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrder
            // 
            this.lblOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(63, 9);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(228, 25);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Café Order Checker ";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblenterquantity
            // 
            this.lblenterquantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblenterquantity.AutoSize = true;
            this.lblenterquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenterquantity.Location = new System.Drawing.Point(12, 78);
            this.lblenterquantity.Name = "lblenterquantity";
            this.lblenterquantity.Size = new System.Drawing.Size(148, 24);
            this.lblenterquantity.TabIndex = 1;
            this.lblenterquantity.Text = "Enter Quantity:";
            this.lblenterquantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQuantityinput
            // 
            this.txtQuantityinput.Location = new System.Drawing.Point(175, 82);
            this.txtQuantityinput.Name = "txtQuantityinput";
            this.txtQuantityinput.Size = new System.Drawing.Size(122, 20);
            this.txtQuantityinput.TabIndex = 2;
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOrder.Location = new System.Drawing.Point(175, 132);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(122, 45);
            this.btnCheckOrder.TabIndex = 3;
            this.btnCheckOrder.Text = "Check Order";
            this.btnCheckOrder.UseVisualStyleBackColor = false;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(171, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 24);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Order";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOrdercheaker
            // 
            this.lblOrdercheaker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrdercheaker.AutoSize = true;
            this.lblOrdercheaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdercheaker.Location = new System.Drawing.Point(12, 231);
            this.lblOrdercheaker.Name = "lblOrdercheaker";
            this.lblOrdercheaker.Size = new System.Drawing.Size(160, 24);
            this.lblOrdercheaker.TabIndex = 5;
            this.lblOrdercheaker.Text = "Order Checker :";
            this.lblOrdercheaker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 332);
            this.Controls.Add(this.lblOrdercheaker);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckOrder);
            this.Controls.Add(this.txtQuantityinput);
            this.Controls.Add(this.lblenterquantity);
            this.Controls.Add(this.lblOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblenterquantity;
        private System.Windows.Forms.TextBox txtQuantityinput;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOrdercheaker;
    }
}

