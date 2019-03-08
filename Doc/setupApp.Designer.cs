namespace DocPatSystem.Doc
{
    partial class setupApp
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
            this.makeAppButt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reasonTB = new System.Windows.Forms.RichTextBox();
            this.timeDropDown = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.patIDTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // makeAppButt
            // 
            this.makeAppButt.BackColor = System.Drawing.Color.PaleGreen;
            this.makeAppButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeAppButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeAppButt.Location = new System.Drawing.Point(579, 332);
            this.makeAppButt.Name = "makeAppButt";
            this.makeAppButt.Size = new System.Drawing.Size(153, 64);
            this.makeAppButt.TabIndex = 19;
            this.makeAppButt.Text = "Make An Appointment";
            this.makeAppButt.UseVisualStyleBackColor = false;
            this.makeAppButt.Click += new System.EventHandler(this.makeAppButt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Reason:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Day:";
            // 
            // reasonTB
            // 
            this.reasonTB.Location = new System.Drawing.Point(390, 141);
            this.reasonTB.Name = "reasonTB";
            this.reasonTB.Size = new System.Drawing.Size(398, 165);
            this.reasonTB.TabIndex = 15;
            this.reasonTB.Text = "";
            // 
            // timeDropDown
            // 
            this.timeDropDown.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDropDown.FormattingEnabled = true;
            this.timeDropDown.Items.AddRange(new object[] {
            "10:00AM",
            "11:00AM",
            "12:00PM",
            "1:00PM",
            "2:00PM",
            "3:00PM",
            "4:00PM"});
            this.timeDropDown.Location = new System.Drawing.Point(128, 41);
            this.timeDropDown.Name = "timeDropDown";
            this.timeDropDown.Size = new System.Drawing.Size(173, 28);
            this.timeDropDown.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(35, 179);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Patient ID:";
            // 
            // patIDTB
            // 
            this.patIDTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patIDTB.Location = new System.Drawing.Point(498, 44);
            this.patIDTB.Name = "patIDTB";
            this.patIDTB.Size = new System.Drawing.Size(118, 23);
            this.patIDTB.TabIndex = 21;
            // 
            // setupApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeAppButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reasonTB);
            this.Controls.Add(this.timeDropDown);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "setupApp";
            this.Text = "Setup an Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeAppButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox reasonTB;
        private System.Windows.Forms.ComboBox timeDropDown;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patIDTB;
    }
}