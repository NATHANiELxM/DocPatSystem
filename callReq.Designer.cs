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
            this.callButt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.activeCallPanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.holdButt = new System.Windows.Forms.Button();
            this.muteButt = new System.Windows.Forms.Button();
            this.endCallButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.callReqPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.activeCallPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // callReqPanel
            // 
            this.callReqPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.callReqPanel.Controls.Add(this.callButt);
            this.callReqPanel.Controls.Add(this.dataGridView1);
            this.callReqPanel.Controls.Add(this.label1);
            this.callReqPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.callReqPanel.Location = new System.Drawing.Point(0, 0);
            this.callReqPanel.Name = "callReqPanel";
            this.callReqPanel.Size = new System.Drawing.Size(450, 433);
            this.callReqPanel.TabIndex = 0;
            this.callReqPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.callReqPanel_Paint);
            // 
            // callButt
            // 
            this.callButt.BackColor = System.Drawing.Color.PaleGreen;
            this.callButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.callButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callButt.Location = new System.Drawing.Point(339, 337);
            this.callButt.Name = "callButt";
            this.callButt.Size = new System.Drawing.Size(86, 41);
            this.callButt.TabIndex = 2;
            this.callButt.Text = "Call";
            this.callButt.UseVisualStyleBackColor = false;
            this.callButt.Click += new System.EventHandler(this.callButt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 250);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patients Requesting Calls";
            // 
            // activeCallPanel
            // 
            this.activeCallPanel.BackColor = System.Drawing.Color.LightBlue;
            this.activeCallPanel.Controls.Add(this.timeLabel);
            this.activeCallPanel.Controls.Add(this.label4);
            this.activeCallPanel.Controls.Add(this.label3);
            this.activeCallPanel.Controls.Add(this.holdButt);
            this.activeCallPanel.Controls.Add(this.muteButt);
            this.activeCallPanel.Controls.Add(this.endCallButt);
            this.activeCallPanel.Controls.Add(this.label2);
            this.activeCallPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.activeCallPanel.Location = new System.Drawing.Point(450, 0);
            this.activeCallPanel.Name = "activeCallPanel";
            this.activeCallPanel.Size = new System.Drawing.Size(450, 433);
            this.activeCallPanel.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(145, 33);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(101, 20);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "(time in call)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // holdButt
            // 
            this.holdButt.BackColor = System.Drawing.Color.Cornsilk;
            this.holdButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holdButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdButt.Location = new System.Drawing.Point(117, 337);
            this.holdButt.Name = "holdButt";
            this.holdButt.Size = new System.Drawing.Size(86, 41);
            this.holdButt.TabIndex = 5;
            this.holdButt.Text = "Hold";
            this.holdButt.UseVisualStyleBackColor = false;
            this.holdButt.Click += new System.EventHandler(this.holdButt_Click);
            // 
            // muteButt
            // 
            this.muteButt.BackColor = System.Drawing.Color.Cornsilk;
            this.muteButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteButt.Location = new System.Drawing.Point(209, 337);
            this.muteButt.Name = "muteButt";
            this.muteButt.Size = new System.Drawing.Size(86, 41);
            this.muteButt.TabIndex = 4;
            this.muteButt.Text = "Mute";
            this.muteButt.UseVisualStyleBackColor = false;
            this.muteButt.Click += new System.EventHandler(this.muteButt_Click);
            // 
            // endCallButt
            // 
            this.endCallButt.BackColor = System.Drawing.Color.IndianRed;
            this.endCallButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endCallButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endCallButt.Location = new System.Drawing.Point(341, 337);
            this.endCallButt.Name = "endCallButt";
            this.endCallButt.Size = new System.Drawing.Size(86, 41);
            this.endCallButt.TabIndex = 3;
            this.endCallButt.Text = "End Call";
            this.endCallButt.UseVisualStyleBackColor = false;
            this.endCallButt.Click += new System.EventHandler(this.endCallButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active Call";
            // 
            // callReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.activeCallPanel);
            this.Controls.Add(this.callReqPanel);
            this.Name = "callReq";
            this.Size = new System.Drawing.Size(900, 433);
            this.callReqPanel.ResumeLayout(false);
            this.callReqPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.activeCallPanel.ResumeLayout(false);
            this.activeCallPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel callReqPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel activeCallPanel;
        private System.Windows.Forms.Button callButt;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button holdButt;
        private System.Windows.Forms.Button muteButt;
        private System.Windows.Forms.Button endCallButt;
        private System.Windows.Forms.Label label2;
    }
}
