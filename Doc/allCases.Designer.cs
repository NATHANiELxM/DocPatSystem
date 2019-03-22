using MySql.Data.MySqlClient;
namespace DocPatSystem
{
    partial class callReq
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
            this.callReqPanel = new System.Windows.Forms.Panel();
            this.newCaseButt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.callReqPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // callReqPanel
            // 
            this.callReqPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.callReqPanel.Controls.Add(this.newCaseButt);
            this.callReqPanel.Controls.Add(this.dataGridView1);
            this.callReqPanel.Controls.Add(this.label1);
            this.callReqPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.callReqPanel.Location = new System.Drawing.Point(0, 0);
            this.callReqPanel.Name = "callReqPanel";
            this.callReqPanel.Size = new System.Drawing.Size(900, 433);
            this.callReqPanel.TabIndex = 0;
            this.callReqPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.callReqPanel_Paint);
            // 
            // newCaseButt
            // 
            this.newCaseButt.BackColor = System.Drawing.Color.PaleGreen;
            this.newCaseButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCaseButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCaseButt.Location = new System.Drawing.Point(718, 343);
            this.newCaseButt.Name = "newCaseButt";
            this.newCaseButt.Size = new System.Drawing.Size(129, 41);
            this.newCaseButt.TabIndex = 2;
            this.newCaseButt.Text = "New Case";
            this.newCaseButt.UseVisualStyleBackColor = false;
            this.newCaseButt.Click += new System.EventHandler(this.callButt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 250);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Active Cases";
            // 
            // callReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.callReqPanel);
            this.Name = "callReq";
            this.Size = new System.Drawing.Size(900, 433);
            this.callReqPanel.ResumeLayout(false);
            this.callReqPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel callReqPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newCaseButt;
    }
}
