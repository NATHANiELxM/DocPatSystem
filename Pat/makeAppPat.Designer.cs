using MySql.Data.MySqlClient;
namespace DocPatSystem
{
    partial class makeAppPat
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.otherTB = new System.Windows.Forms.TextBox();
            this.famDocTB = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timeDropDown = new System.Windows.Forms.ComboBox();
            this.reasonTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reqAppButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(51, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Family Doctor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(51, 113);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Specialist/Other:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // otherTB
            // 
            this.otherTB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.otherTB.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherTB.Location = new System.Drawing.Point(206, 112);
            this.otherTB.Name = "otherTB";
            this.otherTB.ReadOnly = true;
            this.otherTB.Size = new System.Drawing.Size(166, 27);
            this.otherTB.TabIndex = 3;
            this.otherTB.TextChanged += new System.EventHandler(this.otherTB_TextChanged);
            // 
            // famDocTB
            // 
            this.famDocTB.BackColor = System.Drawing.SystemColors.Window;
            this.famDocTB.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famDocTB.Location = new System.Drawing.Point(206, 71);
            this.famDocTB.Name = "famDocTB";
            this.famDocTB.ReadOnly = true;
            this.famDocTB.Size = new System.Drawing.Size(166, 27);
            this.famDocTB.TabIndex = 4;
            this.famDocTB.Text = "(Family Doctor)";
            this.famDocTB.TextChanged += new System.EventHandler(this.famDocTB_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(75, 217);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            this.timeDropDown.Location = new System.Drawing.Point(662, 59);
            this.timeDropDown.Name = "timeDropDown";
            this.timeDropDown.Size = new System.Drawing.Size(173, 28);
            this.timeDropDown.TabIndex = 6;
            this.timeDropDown.SelectedIndexChanged += new System.EventHandler(this.timeDropDown_SelectedIndexChanged);
            // 
            // reasonTB
            // 
            this.reasonTB.Location = new System.Drawing.Point(437, 154);
            this.reasonTB.Name = "reasonTB";
            this.reasonTB.Size = new System.Drawing.Size(398, 165);
            this.reasonTB.TabIndex = 7;
            this.reasonTB.Text = "";
            this.reasonTB.TextChanged += new System.EventHandler(this.reasonTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Day:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Time:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reason:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // reqAppButt
            // 
            this.reqAppButt.BackColor = System.Drawing.Color.PaleGreen;
            this.reqAppButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqAppButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqAppButt.Location = new System.Drawing.Point(620, 336);
            this.reqAppButt.Name = "reqAppButt";
            this.reqAppButt.Size = new System.Drawing.Size(153, 64);
            this.reqAppButt.TabIndex = 12;
            this.reqAppButt.Text = "Request An Appointment";
            this.reqAppButt.UseVisualStyleBackColor = false;
            this.reqAppButt.Click += new System.EventHandler(this.reqAppButt_Click);
            // 
            // makeAppPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.reqAppButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reasonTB);
            this.Controls.Add(this.timeDropDown);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.famDocTB);
            this.Controls.Add(this.otherTB);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "makeAppPat";
            this.Size = new System.Drawing.Size(900, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox otherTB;
        private System.Windows.Forms.TextBox famDocTB;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox timeDropDown;
        private System.Windows.Forms.RichTextBox reasonTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reqAppButt;
    }
}
