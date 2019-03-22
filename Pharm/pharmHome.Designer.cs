namespace DocPatSystem
{
    partial class pharmHome
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
            this.displayPanel = new System.Windows.Forms.Panel();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.systemLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.currentTabLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.medRecodsButt = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.caseButt = new System.Windows.Forms.Button();
            this.activeButt = new System.Windows.Forms.Button();
            this.newButt = new System.Windows.Forms.Button();
            this.refillButt = new System.Windows.Forms.Button();
            this.topLeftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point(200, 67);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(900, 433);
            this.displayPanel.TabIndex = 6;
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.topLeftPanel.Controls.Add(this.systemLabel);
            this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(198, 67);
            this.topLeftPanel.TabIndex = 1;
            // 
            // systemLabel
            // 
            this.systemLabel.AutoSize = true;
            this.systemLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemLabel.Location = new System.Drawing.Point(26, 9);
            this.systemLabel.Name = "systemLabel";
            this.systemLabel.Size = new System.Drawing.Size(136, 38);
            this.systemLabel.TabIndex = 1;
            this.systemLabel.Text = "Pharmacy\r\nService System";
            this.systemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.systemLabel.Click += new System.EventHandler(this.systemLabel_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Honeydew;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.exitLabel);
            this.topPanel.Controls.Add(this.currentTabLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(900, 67);
            this.topPanel.TabIndex = 4;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(867, 25);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(21, 19);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // currentTabLabel
            // 
            this.currentTabLabel.AutoSize = true;
            this.currentTabLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTabLabel.Location = new System.Drawing.Point(36, 24);
            this.currentTabLabel.Name = "currentTabLabel";
            this.currentTabLabel.Size = new System.Drawing.Size(87, 20);
            this.currentTabLabel.TabIndex = 0;
            this.currentTabLabel.Text = "Homepage";
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.medRecodsButt);
            this.leftPanel.Controls.Add(this.welcomeLabel);
            this.leftPanel.Controls.Add(this.caseButt);
            this.leftPanel.Controls.Add(this.activeButt);
            this.leftPanel.Controls.Add(this.newButt);
            this.leftPanel.Controls.Add(this.refillButt);
            this.leftPanel.Controls.Add(this.topLeftPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 500);
            this.leftPanel.TabIndex = 5;
            // 
            // medRecodsButt
            // 
            this.medRecodsButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.medRecodsButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medRecodsButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medRecodsButt.ForeColor = System.Drawing.Color.Black;
            this.medRecodsButt.Location = new System.Drawing.Point(0, 380);
            this.medRecodsButt.Name = "medRecodsButt";
            this.medRecodsButt.Size = new System.Drawing.Size(198, 50);
            this.medRecodsButt.TabIndex = 6;
            this.medRecodsButt.Text = "Medical Records";
            this.medRecodsButt.UseVisualStyleBackColor = false;
            this.medRecodsButt.Click += new System.EventHandler(this.medRecodsButt_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(11, 70);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(170, 38);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome Pharmacist\r\n [Username]!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caseButt
            // 
            this.caseButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.caseButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caseButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseButt.ForeColor = System.Drawing.Color.Black;
            this.caseButt.Location = new System.Drawing.Point(0, 320);
            this.caseButt.Name = "caseButt";
            this.caseButt.Size = new System.Drawing.Size(198, 50);
            this.caseButt.TabIndex = 5;
            this.caseButt.Text = "Discuss a Case";
            this.caseButt.UseVisualStyleBackColor = false;
            this.caseButt.Click += new System.EventHandler(this.caseButt_Click);
            // 
            // activeButt
            // 
            this.activeButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.activeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeButt.ForeColor = System.Drawing.Color.Black;
            this.activeButt.Location = new System.Drawing.Point(0, 260);
            this.activeButt.Name = "activeButt";
            this.activeButt.Size = new System.Drawing.Size(198, 50);
            this.activeButt.TabIndex = 4;
            this.activeButt.Text = "Active Prescriptions";
            this.activeButt.UseVisualStyleBackColor = false;
            this.activeButt.Click += new System.EventHandler(this.activeButt_Click);
            // 
            // newButt
            // 
            this.newButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButt.ForeColor = System.Drawing.Color.Black;
            this.newButt.Location = new System.Drawing.Point(0, 200);
            this.newButt.Name = "newButt";
            this.newButt.Size = new System.Drawing.Size(198, 50);
            this.newButt.TabIndex = 3;
            this.newButt.Text = "New Prescriptions";
            this.newButt.UseVisualStyleBackColor = false;
            this.newButt.Click += new System.EventHandler(this.newButt_Click);
            // 
            // refillButt
            // 
            this.refillButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.refillButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refillButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillButt.ForeColor = System.Drawing.Color.Black;
            this.refillButt.Location = new System.Drawing.Point(0, 140);
            this.refillButt.Name = "refillButt";
            this.refillButt.Size = new System.Drawing.Size(198, 50);
            this.refillButt.TabIndex = 1;
            this.refillButt.Text = "Refill Requests";
            this.refillButt.UseVisualStyleBackColor = false;
            this.refillButt.Click += new System.EventHandler(this.refillButt_Click);
            // 
            // pharmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pharmHome";
            this.Text = "pharmHome";
            this.topLeftPanel.ResumeLayout(false);
            this.topLeftPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Label systemLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label currentTabLabel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button caseButt;
        private System.Windows.Forms.Button activeButt;
        private System.Windows.Forms.Button newButt;
        private System.Windows.Forms.Button refillButt;
        private System.Windows.Forms.Button medRecodsButt;
    }
}