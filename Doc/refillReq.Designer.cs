using MySql.Data.MySqlClient;
namespace DocPatSystem
{
    partial class refillReq
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
            this.refillReqPanel = new System.Windows.Forms.Panel();
            this.denyButt = new System.Windows.Forms.Button();
            this.acceptButt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.refillReqPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // refillReqPanel
            // 
            this.refillReqPanel.BackColor = System.Drawing.Color.MistyRose;
            this.refillReqPanel.Controls.Add(this.denyButt);
            this.refillReqPanel.Controls.Add(this.acceptButt);
            this.refillReqPanel.Controls.Add(this.dataGridView1);
            this.refillReqPanel.Controls.Add(this.label1);
            this.refillReqPanel.Location = new System.Drawing.Point(75, 16);
            this.refillReqPanel.Name = "refillReqPanel";
            this.refillReqPanel.Size = new System.Drawing.Size(750, 400);
            this.refillReqPanel.TabIndex = 0;
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
            this.denyButt.Click += new System.EventHandler(this.denyButt_Click);
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
            this.acceptButt.Click += new System.EventHandler(this.acceptButt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(704, 296);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Refill Requests";
            // 
            // refillReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.refillReqPanel);
            this.Name = "refillReq";
            this.Size = new System.Drawing.Size(900, 433);
            this.Load += new System.EventHandler(this.refillReq_Load);
            this.refillReqPanel.ResumeLayout(false);
            this.refillReqPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel refillReqPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button denyButt;
        private System.Windows.Forms.Button acceptButt;
    }
}
