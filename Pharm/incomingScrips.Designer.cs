namespace DocPatSystem.Pharm
{
    partial class incomingScrips
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
            this.denyButt = new System.Windows.Forms.Button();
            this.acceptButt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incomingScripsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.incomingScripsPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(704, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // incomingScripsPanel
            // 
            this.incomingScripsPanel.BackColor = System.Drawing.Color.Plum;
            this.incomingScripsPanel.Controls.Add(this.denyButt);
            this.incomingScripsPanel.Controls.Add(this.acceptButt);
            this.incomingScripsPanel.Controls.Add(this.dataGridView1);
            this.incomingScripsPanel.Controls.Add(this.label1);
            this.incomingScripsPanel.Location = new System.Drawing.Point(75, 16);
            this.incomingScripsPanel.Name = "incomingScripsPanel";
            this.incomingScripsPanel.Size = new System.Drawing.Size(750, 400);
            this.incomingScripsPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incoming Prescriptions";
            // 
            // incomingScrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incomingScripsPanel);
            this.Name = "incomingScrips";
            this.Size = new System.Drawing.Size(900, 433);
            this.Load += new System.EventHandler(this.incomingScrips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.incomingScripsPanel.ResumeLayout(false);
            this.incomingScripsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button denyButt;
        private System.Windows.Forms.Button acceptButt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel incomingScripsPanel;
        private System.Windows.Forms.Label label1;
    }
}
