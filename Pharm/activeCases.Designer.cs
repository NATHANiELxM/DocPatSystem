namespace DocPatSystem.Pharm
{
    partial class activeCases
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
            this.activeCasesPanel = new System.Windows.Forms.Panel();
            this.newCaseButt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.activeCasesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // activeCasesPanel
            // 
            this.activeCasesPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.activeCasesPanel.Controls.Add(this.newCaseButt);
            this.activeCasesPanel.Controls.Add(this.dataGridView1);
            this.activeCasesPanel.Controls.Add(this.label1);
            this.activeCasesPanel.Location = new System.Drawing.Point(75, 16);
            this.activeCasesPanel.Name = "activeCasesPanel";
            this.activeCasesPanel.Size = new System.Drawing.Size(750, 400);
            this.activeCasesPanel.TabIndex = 2;
            // 
            // newCaseButt
            // 
            this.newCaseButt.BackColor = System.Drawing.Color.PaleGreen;
            this.newCaseButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCaseButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCaseButt.Location = new System.Drawing.Point(539, 345);
            this.newCaseButt.Name = "newCaseButt";
            this.newCaseButt.Size = new System.Drawing.Size(95, 35);
            this.newCaseButt.TabIndex = 2;
            this.newCaseButt.Text = "New Case";
            this.newCaseButt.UseVisualStyleBackColor = false;
            this.newCaseButt.Click += new System.EventHandler(this.newCaseButt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Active Cases";
            // 
            // activeCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.activeCasesPanel);
            this.Name = "activeCases";
            this.Size = new System.Drawing.Size(900, 433);
            this.Load += new System.EventHandler(this.activeCases_Load);
            this.activeCasesPanel.ResumeLayout(false);
            this.activeCasesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel activeCasesPanel;
        private System.Windows.Forms.Button newCaseButt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
