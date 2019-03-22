namespace DocPatSystem.Pharm
{
    partial class makeCasePharm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toTB = new System.Windows.Forms.TextBox();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.noticeIDTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.noticeTB = new System.Windows.Forms.RichTextBox();
            this.sendButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origionator ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Notice ID:";
            // 
            // toTB
            // 
            this.toTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTB.Location = new System.Drawing.Point(141, 17);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(130, 23);
            this.toTB.TabIndex = 4;
            // 
            // fromTB
            // 
            this.fromTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTB.Location = new System.Drawing.Point(434, 17);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(130, 23);
            this.fromTB.TabIndex = 5;
            // 
            // noticeIDTB
            // 
            this.noticeIDTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeIDTB.Location = new System.Drawing.Point(747, 17);
            this.noticeIDTB.Name = "noticeIDTB";
            this.noticeIDTB.Size = new System.Drawing.Size(130, 23);
            this.noticeIDTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notice:";
            // 
            // noticeTB
            // 
            this.noticeTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeTB.Location = new System.Drawing.Point(81, 66);
            this.noticeTB.Name = "noticeTB";
            this.noticeTB.Size = new System.Drawing.Size(725, 252);
            this.noticeTB.TabIndex = 8;
            this.noticeTB.Text = "";
            // 
            // sendButt
            // 
            this.sendButt.BackColor = System.Drawing.Color.PaleGreen;
            this.sendButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButt.Location = new System.Drawing.Point(688, 351);
            this.sendButt.Name = "sendButt";
            this.sendButt.Size = new System.Drawing.Size(118, 40);
            this.sendButt.TabIndex = 9;
            this.sendButt.Text = "Send Notice";
            this.sendButt.UseVisualStyleBackColor = false;
            this.sendButt.Click += new System.EventHandler(this.sendButt_Click);
            // 
            // makeCasePharm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendButt);
            this.Controls.Add(this.noticeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noticeIDTB);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "makeCasePharm";
            this.Size = new System.Drawing.Size(900, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.TextBox noticeIDTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox noticeTB;
        private System.Windows.Forms.Button sendButt;
    }
}
