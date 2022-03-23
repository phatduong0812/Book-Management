namespace PEApp
{
    partial class EmployeeDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmId = new System.Windows.Forms.TextBox();
            this.txtEmName = new System.Windows.Forms.TextBox();
            this.txtYob = new System.Windows.Forms.TextBox();
            this.txtDeName = new System.Windows.Forms.TextBox();
            this.cbJobId = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmployeeName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "YearOfBirth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "DepartmentName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "JobTitleId";
            // 
            // txtEmId
            // 
            this.txtEmId.Location = new System.Drawing.Point(486, 107);
            this.txtEmId.Name = "txtEmId";
            this.txtEmId.Size = new System.Drawing.Size(300, 55);
            this.txtEmId.TabIndex = 5;
            // 
            // txtEmName
            // 
            this.txtEmName.Location = new System.Drawing.Point(497, 191);
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.Size = new System.Drawing.Size(300, 55);
            this.txtEmName.TabIndex = 6;
            // 
            // txtYob
            // 
            this.txtYob.Location = new System.Drawing.Point(486, 323);
            this.txtYob.Name = "txtYob";
            this.txtYob.Size = new System.Drawing.Size(300, 55);
            this.txtYob.TabIndex = 7;
            // 
            // txtDeName
            // 
            this.txtDeName.Location = new System.Drawing.Point(509, 437);
            this.txtDeName.Name = "txtDeName";
            this.txtDeName.Size = new System.Drawing.Size(300, 55);
            this.txtDeName.TabIndex = 8;
            // 
            // cbJobId
            // 
            this.cbJobId.FormattingEnabled = true;
            this.cbJobId.Location = new System.Drawing.Point(476, 546);
            this.cbJobId.Name = "cbJobId";
            this.cbJobId.Size = new System.Drawing.Size(363, 56);
            this.cbJobId.TabIndex = 9;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(611, 702);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(225, 69);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 1012);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbJobId);
            this.Controls.Add(this.txtDeName);
            this.Controls.Add(this.txtYob);
            this.Controls.Add(this.txtEmName);
            this.Controls.Add(this.txtEmId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmId;
        private System.Windows.Forms.TextBox txtEmName;
        private System.Windows.Forms.TextBox txtYob;
        private System.Windows.Forms.TextBox txtDeName;
        private System.Windows.Forms.ComboBox cbJobId;
        private System.Windows.Forms.Button btSave;
    }
}