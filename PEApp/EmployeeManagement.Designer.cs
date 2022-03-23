namespace PEApp
{
    partial class EmployeeManagement
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
            this.btNew = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmployeeName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "YearOfBirth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "DepartmentName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "JobTitle";
            // 
            // txtEmId
            // 
            this.txtEmId.Location = new System.Drawing.Point(462, 59);
            this.txtEmId.Name = "txtEmId";
            this.txtEmId.Size = new System.Drawing.Size(300, 55);
            this.txtEmId.TabIndex = 5;
            // 
            // txtEmName
            // 
            this.txtEmName.Location = new System.Drawing.Point(462, 184);
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.Size = new System.Drawing.Size(300, 55);
            this.txtEmName.TabIndex = 6;
            // 
            // txtYob
            // 
            this.txtYob.Location = new System.Drawing.Point(462, 285);
            this.txtYob.Name = "txtYob";
            this.txtYob.Size = new System.Drawing.Size(300, 55);
            this.txtYob.TabIndex = 7;
            // 
            // txtDeName
            // 
            this.txtDeName.Location = new System.Drawing.Point(462, 387);
            this.txtDeName.Name = "txtDeName";
            this.txtDeName.Size = new System.Drawing.Size(300, 55);
            this.txtDeName.TabIndex = 8;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(1134, 66);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(225, 69);
            this.btNew.TabIndex = 10;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(1134, 197);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(225, 69);
            this.btLoad.TabIndex = 11;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1134, 316);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(225, 69);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // txtJobId
            // 
            this.txtJobId.Location = new System.Drawing.Point(469, 488);
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.Size = new System.Drawing.Size(300, 55);
            this.txtJobId.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 588);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(1760, 557);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1174);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.txtDeName);
            this.Controls.Add(this.txtYob);
            this.Controls.Add(this.txtEmName);
            this.Controls.Add(this.txtEmId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}