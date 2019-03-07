using MySql.Data.MySqlClient;
namespace DocPatSystem
{
    partial class makeCall
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activeCallPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.holdButt = new System.Windows.Forms.Button();
            this.muteButt = new System.Windows.Forms.Button();
            this.endCallButt = new System.Windows.Forms.Button();
            this.callButt = new System.Windows.Forms.Button();
            this.makeCallPanel = new System.Windows.Forms.Panel();
            this.urgentCB = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.activeCallPanel.SuspendLayout();
            this.makeCallPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.activeCallPanel.TabIndex = 2;
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
            // callButt
            // 
            this.callButt.BackColor = System.Drawing.Color.PaleGreen;
            this.callButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.callButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callButt.Location = new System.Drawing.Point(283, 268);
            this.callButt.Name = "callButt";
            this.callButt.Size = new System.Drawing.Size(86, 41);
            this.callButt.TabIndex = 2;
            this.callButt.Text = "Call";
            this.callButt.UseVisualStyleBackColor = false;
            this.callButt.Click += new System.EventHandler(this.callButt_Click);
            // 
            // makeCallPanel
            // 
            this.makeCallPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.makeCallPanel.Controls.Add(this.urgentCB);
            this.makeCallPanel.Controls.Add(this.comboBox1);
            this.makeCallPanel.Controls.Add(this.callButt);
            this.makeCallPanel.Controls.Add(this.label1);
            this.makeCallPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.makeCallPanel.Location = new System.Drawing.Point(0, 0);
            this.makeCallPanel.Name = "makeCallPanel";
            this.makeCallPanel.Size = new System.Drawing.Size(450, 433);
            this.makeCallPanel.TabIndex = 3;
            // 
            // urgentCB
            // 
            this.urgentCB.AutoSize = true;
            this.urgentCB.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urgentCB.Location = new System.Drawing.Point(64, 115);
            this.urgentCB.Name = "urgentCB";
            this.urgentCB.Size = new System.Drawing.Size(93, 24);
            this.urgentCB.TabIndex = 4;
            this.urgentCB.Text = "Urgent?";
            this.urgentCB.UseVisualStyleBackColor = true;
            this.urgentCB.CheckedChanged += new System.EventHandler(this.urgentCB_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Call:";
            // 
            // makeCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.makeCallPanel);
            this.Controls.Add(this.activeCallPanel);
            this.Name = "makeCall";
            this.Size = new System.Drawing.Size(900, 433);
            this.activeCallPanel.ResumeLayout(false);
            this.activeCallPanel.PerformLayout();
            this.makeCallPanel.ResumeLayout(false);
            this.makeCallPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel activeCallPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button holdButt;
        private System.Windows.Forms.Button muteButt;
        private System.Windows.Forms.Button endCallButt;
        private System.Windows.Forms.Button callButt;
        private System.Windows.Forms.Panel makeCallPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox urgentCB;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
