namespace DocPatSystem
{
    partial class patHome
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.currentTabLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.recordsButt = new System.Windows.Forms.Button();
            this.callADocButt = new System.Windows.Forms.Button();
            this.refillMedButt = new System.Windows.Forms.Button();
            this.appButt = new System.Windows.Forms.Button();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.systemLabel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.topLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Ivory;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.exitLabel);
            this.topPanel.Controls.Add(this.currentTabLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(900, 67);
            this.topPanel.TabIndex = 1;
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
            this.leftPanel.Controls.Add(this.welcomeLabel);
            this.leftPanel.Controls.Add(this.recordsButt);
            this.leftPanel.Controls.Add(this.callADocButt);
            this.leftPanel.Controls.Add(this.refillMedButt);
            this.leftPanel.Controls.Add(this.appButt);
            this.leftPanel.Controls.Add(this.topLeftPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 500);
            this.leftPanel.TabIndex = 2;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(27, 70);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(138, 38);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome Patient\r\n [Username]!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordsButt
            // 
            this.recordsButt.BackColor = System.Drawing.Color.Honeydew;
            this.recordsButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordsButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsButt.ForeColor = System.Drawing.Color.Black;
            this.recordsButt.Location = new System.Drawing.Point(0, 320);
            this.recordsButt.Name = "recordsButt";
            this.recordsButt.Size = new System.Drawing.Size(198, 50);
            this.recordsButt.TabIndex = 5;
            this.recordsButt.Text = "My Medical Records";
            this.recordsButt.UseVisualStyleBackColor = false;
            this.recordsButt.Click += new System.EventHandler(this.recordsButt_Click);
            // 
            // callADocButt
            // 
            this.callADocButt.BackColor = System.Drawing.Color.Honeydew;
            this.callADocButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.callADocButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callADocButt.ForeColor = System.Drawing.Color.Black;
            this.callADocButt.Location = new System.Drawing.Point(0, 260);
            this.callADocButt.Name = "callADocButt";
            this.callADocButt.Size = new System.Drawing.Size(198, 50);
            this.callADocButt.TabIndex = 4;
            this.callADocButt.Text = "Call A Doctor";
            this.callADocButt.UseVisualStyleBackColor = false;
            this.callADocButt.Click += new System.EventHandler(this.callADocButt_Click);
            // 
            // refillMedButt
            // 
            this.refillMedButt.BackColor = System.Drawing.Color.Honeydew;
            this.refillMedButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refillMedButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillMedButt.ForeColor = System.Drawing.Color.Black;
            this.refillMedButt.Location = new System.Drawing.Point(0, 200);
            this.refillMedButt.Name = "refillMedButt";
            this.refillMedButt.Size = new System.Drawing.Size(198, 50);
            this.refillMedButt.TabIndex = 3;
            this.refillMedButt.Text = "Refill Medication";
            this.refillMedButt.UseVisualStyleBackColor = false;
            this.refillMedButt.Click += new System.EventHandler(this.refillMedButt_Click);
            // 
            // appButt
            // 
            this.appButt.BackColor = System.Drawing.Color.Honeydew;
            this.appButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appButt.ForeColor = System.Drawing.Color.Black;
            this.appButt.Location = new System.Drawing.Point(0, 140);
            this.appButt.Name = "appButt";
            this.appButt.Size = new System.Drawing.Size(198, 50);
            this.appButt.TabIndex = 1;
            this.appButt.Text = "Make An Appointment";
            this.appButt.UseVisualStyleBackColor = false;
            this.appButt.Click += new System.EventHandler(this.appButt_Click);
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.BackColor = System.Drawing.Color.LightGreen;
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
            this.systemLabel.Text = "Patient\r\nService System";
            this.systemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayPanel
            // 
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point(200, 67);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(900, 433);
            this.displayPanel.TabIndex = 3;
            // 
            // patHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "patHome";
            this.Text = "Patient Home Page";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.topLeftPanel.ResumeLayout(false);
            this.topLeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label currentTabLabel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button recordsButt;
        private System.Windows.Forms.Button callADocButt;
        private System.Windows.Forms.Button refillMedButt;
        private System.Windows.Forms.Button appButt;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Label systemLabel;
        private System.Windows.Forms.Panel displayPanel;
    }
}