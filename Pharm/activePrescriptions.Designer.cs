namespace DocPatSystem.Pharm
{
    partial class activePrescriptions
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
            this.activeScripsPanel = new System.Windows.Forms.Panel();
            this.denyButt = new System.Windows.Forms.Button();
            this.acceptButt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.activeScripsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // activeScripsPanel
            // 
            this.activeScripsPanel.BackColor = System.Drawing.Color.MediumOrchid;
            this.activeScripsPanel.Controls.Add(this.denyButt);
            this.activeScripsPanel.Controls.Add(this.acceptButt);
            this.activeScripsPanel.Controls.Add(this.dataGridView1);
            this.activeScripsPanel.Controls.Add(this.label1);
            this.activeScripsPanel.Location = new System.Drawing.Point(0, 0);
            this.activeScripsPanel.Name = "activeScripsPanel";
            this.activeScripsPanel.Size = new System.Drawing.Size(900, 433);
            this.activeScripsPanel.TabIndex = 2;
            this.activeScripsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.activeScripsPanel_Paint);
            // 
            // denyButt
            // 
            this.denyButt.BackColor = System.Drawing.Color.IndianRed;
            this.denyButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denyButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyButt.Location = new System.Drawing.Point(427, 345);
            this.denyButt.Name = "denyButt";
            this.denyButt.Size = new System.Drawing.Size(95, 35);
            this.denyButt.TabIndex = 3;
            this.denyButt.Text = "Deny";
            this.denyButt.UseVisualStyleBackColor = false;
            // 
            // acceptButt
            // 
            this.acceptButt.BackColor = System.Drawing.Color.PaleGreen;
            this.acceptButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButt.Location = new System.Drawing.Point(189, 345);
            this.acceptButt.Name = "acceptButt";
            this.acceptButt.Size = new System.Drawing.Size(95, 35);
            this.acceptButt.TabIndex = 2;
            this.acceptButt.Text = "Accept";
            this.acceptButt.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Active Prescriptions";
            // 
            // activePrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.activeScripsPanel);
            this.Name = "activePrescriptions";
            this.Size = new System.Drawing.Size(900, 433);
            this.activeScripsPanel.ResumeLayout(false);
            this.activeScripsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel activeScripsPanel;
        private System.Windows.Forms.Button denyButt;
        private System.Windows.Forms.Button acceptButt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
