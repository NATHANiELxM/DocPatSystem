namespace DocPatSystem
{
    partial class appointments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentAppsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButt = new System.Windows.Forms.Button();
            this.currentAppsTable = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awaitingAppsPanel = new System.Windows.Forms.Panel();
            this.approveButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.awaitingAppsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denyButt = new System.Windows.Forms.Button();
            this.makeButt = new System.Windows.Forms.Button();
            this.currentAppsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentAppsTable)).BeginInit();
            this.awaitingAppsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awaitingAppsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // currentAppsPanel
            // 
            this.currentAppsPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.currentAppsPanel.Controls.Add(this.label1);
            this.currentAppsPanel.Controls.Add(this.cancelButt);
            this.currentAppsPanel.Controls.Add(this.currentAppsTable);
            this.currentAppsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentAppsPanel.Location = new System.Drawing.Point(0, 0);
            this.currentAppsPanel.Name = "currentAppsPanel";
            this.currentAppsPanel.Size = new System.Drawing.Size(450, 433);
            this.currentAppsPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirmed Appointments";
            // 
            // cancelButt
            // 
            this.cancelButt.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButt.Location = new System.Drawing.Point(154, 351);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(117, 51);
            this.cancelButt.TabIndex = 5;
            this.cancelButt.Text = "Cancel Appointment";
            this.cancelButt.UseVisualStyleBackColor = false;
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // currentAppsTable
            // 
            this.currentAppsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentAppsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Date,
            this.Time});
            this.currentAppsTable.Location = new System.Drawing.Point(3, 55);
            this.currentAppsTable.Name = "currentAppsTable";
            this.currentAppsTable.Size = new System.Drawing.Size(444, 290);
            this.currentAppsTable.TabIndex = 4;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // awaitingAppsPanel
            // 
            this.awaitingAppsPanel.BackColor = System.Drawing.Color.LightYellow;
            this.awaitingAppsPanel.Controls.Add(this.approveButt);
            this.awaitingAppsPanel.Controls.Add(this.label2);
            this.awaitingAppsPanel.Controls.Add(this.awaitingAppsTable);
            this.awaitingAppsPanel.Controls.Add(this.denyButt);
            this.awaitingAppsPanel.Controls.Add(this.makeButt);
            this.awaitingAppsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.awaitingAppsPanel.Location = new System.Drawing.Point(450, 0);
            this.awaitingAppsPanel.Name = "awaitingAppsPanel";
            this.awaitingAppsPanel.Size = new System.Drawing.Size(450, 433);
            this.awaitingAppsPanel.TabIndex = 1;
            // 
            // approveButt
            // 
            this.approveButt.BackColor = System.Drawing.Color.PaleGreen;
            this.approveButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveButt.Location = new System.Drawing.Point(45, 351);
            this.approveButt.Name = "approveButt";
            this.approveButt.Size = new System.Drawing.Size(117, 51);
            this.approveButt.TabIndex = 10;
            this.approveButt.Text = "Approve Appointment";
            this.approveButt.UseVisualStyleBackColor = false;
            this.approveButt.Click += new System.EventHandler(this.approveButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Appointments Awaiting Approval";
            // 
            // awaitingAppsTable
            // 
            this.awaitingAppsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awaitingAppsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.awaitingAppsTable.Location = new System.Drawing.Point(3, 55);
            this.awaitingAppsTable.Name = "awaitingAppsTable";
            this.awaitingAppsTable.Size = new System.Drawing.Size(444, 290);
            this.awaitingAppsTable.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // denyButt
            // 
            this.denyButt.BackColor = System.Drawing.Color.IndianRed;
            this.denyButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denyButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyButt.Location = new System.Drawing.Point(168, 351);
            this.denyButt.Name = "denyButt";
            this.denyButt.Size = new System.Drawing.Size(117, 51);
            this.denyButt.TabIndex = 7;
            this.denyButt.Text = "Deny Appointment";
            this.denyButt.UseVisualStyleBackColor = false;
            // 
            // makeButt
            // 
            this.makeButt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.makeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeButt.Location = new System.Drawing.Point(311, 351);
            this.makeButt.Name = "makeButt";
            this.makeButt.Size = new System.Drawing.Size(117, 51);
            this.makeButt.TabIndex = 8;
            this.makeButt.Text = "Make New Appointment";
            this.makeButt.UseVisualStyleBackColor = false;
            this.makeButt.Click += new System.EventHandler(this.makeButt_Click);
            // 
            // appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.awaitingAppsPanel);
            this.Controls.Add(this.currentAppsPanel);
            this.Name = "appointments";
            this.Size = new System.Drawing.Size(900, 433);
            this.currentAppsPanel.ResumeLayout(false);
            this.currentAppsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentAppsTable)).EndInit();
            this.awaitingAppsPanel.ResumeLayout(false);
            this.awaitingAppsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awaitingAppsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel currentAppsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButt;
        private System.Windows.Forms.DataGridView currentAppsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Panel awaitingAppsPanel;
        private System.Windows.Forms.Button approveButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView awaitingAppsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button denyButt;
        private System.Windows.Forms.Button makeButt;
    }
}
