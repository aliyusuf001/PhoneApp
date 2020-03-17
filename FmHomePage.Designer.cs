namespace WindowsFormsApp1
{
    partial class FmHomePage
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lblProcessedOutput = new System.Windows.Forms.Label();
            this.txtUsersNumbers = new System.Windows.Forms.TextBox();
            this.txtProcessedOutput = new System.Windows.Forms.TextBox();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.txtTotalNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paste the phone numbers here";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGo.Location = new System.Drawing.Point(356, 182);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 37);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblProcessedOutput
            // 
            this.lblProcessedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProcessedOutput.AutoSize = true;
            this.lblProcessedOutput.Location = new System.Drawing.Point(12, 263);
            this.lblProcessedOutput.Name = "lblProcessedOutput";
            this.lblProcessedOutput.Size = new System.Drawing.Size(57, 13);
            this.lblProcessedOutput.TabIndex = 5;
            this.lblProcessedOutput.Text = "Processed";
            // 
            // txtUsersNumbers
            // 
            this.txtUsersNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsersNumbers.Location = new System.Drawing.Point(15, 29);
            this.txtUsersNumbers.Multiline = true;
            this.txtUsersNumbers.Name = "txtUsersNumbers";
            this.txtUsersNumbers.Size = new System.Drawing.Size(416, 147);
            this.txtUsersNumbers.TabIndex = 6;
            // 
            // txtProcessedOutput
            // 
            this.txtProcessedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcessedOutput.Location = new System.Drawing.Point(12, 279);
            this.txtProcessedOutput.Multiline = true;
            this.txtProcessedOutput.Name = "txtProcessedOutput";
            this.txtProcessedOutput.Size = new System.Drawing.Size(419, 160);
            this.txtProcessedOutput.TabIndex = 7;
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Location = new System.Drawing.Point(16, 422);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(187, 13);
            this.lblTotalNumber.TabIndex = 8;
            this.lblTotalNumber.Text = "Total Number that are in correct order:";
            this.lblTotalNumber.Click += new System.EventHandler(this.lblTotalNumber_Click);
            // 
            // txtTotalNumber
            // 
            this.txtTotalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalNumber.Location = new System.Drawing.Point(203, 418);
            this.txtTotalNumber.Multiline = true;
            this.txtTotalNumber.Name = "txtTotalNumber";
            this.txtTotalNumber.Size = new System.Drawing.Size(78, 20);
            this.txtTotalNumber.TabIndex = 9;
            // 
            // FmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 451);
            this.Controls.Add(this.txtTotalNumber);
            this.Controls.Add(this.lblTotalNumber);
            this.Controls.Add(this.txtProcessedOutput);
            this.Controls.Add(this.txtUsersNumbers);
            this.Controls.Add(this.lblProcessedOutput);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(950, 490);
            this.MinimumSize = new System.Drawing.Size(460, 490);
            this.Name = "FmHomePage";
            this.Text = "This is the Homepage";
            this.Load += new System.EventHandler(this.FmHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblProcessedOutput;
        private System.Windows.Forms.TextBox txtUsersNumbers;
        private System.Windows.Forms.TextBox txtProcessedOutput;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.TextBox txtTotalNumber;
    }
}