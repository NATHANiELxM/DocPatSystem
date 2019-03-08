namespace DocPatSystem.Doc
{
    partial class makeCaseForm
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
            this.sendButt = new System.Windows.Forms.Button();
            this.noticeTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.noticeTypeTB = new System.Windows.Forms.TextBox();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.toTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendButt
            // 
            this.sendButt.BackColor = System.Drawing.Color.PaleGreen;
            this.sendButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButt.Location = new System.Drawing.Point(684, 377);
            this.sendButt.Name = "sendButt";
            this.sendButt.Size = new System.Drawing.Size(118, 40);
            this.sendButt.TabIndex = 27;
            this.sendButt.Text = "Send Notice";
            this.sendButt.UseVisualStyleBackColor = false;
            this.sendButt.Click += new System.EventHandler(this.sendButt_Click);
            // 
            // noticeTB
            // 
            this.noticeTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeTB.Location = new System.Drawing.Point(77, 92);
            this.noticeTB.Name = "noticeTB";
            this.noticeTB.Size = new System.Drawing.Size(725, 252);
            this.noticeTB.TabIndex = 26;
            this.noticeTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Notice:";
            // 
            // noticeTypeTB
            // 
            this.noticeTypeTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeTypeTB.Location = new System.Drawing.Point(728, 43);
            this.noticeTypeTB.Name = "noticeTypeTB";
            this.noticeTypeTB.Size = new System.Drawing.Size(130, 23);
            this.noticeTypeTB.TabIndex = 24;
            // 
            // fromTB
            // 
            this.fromTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTB.Location = new System.Drawing.Point(430, 43);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(130, 23);
            this.fromTB.TabIndex = 23;
            // 
            // toTB
            // 
            this.toTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTB.Location = new System.Drawing.Point(137, 43);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(130, 23);
            this.toTB.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Notice Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Origionator ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Recipient ID:";
            // 
            // makeCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.sendButt);
            this.Controls.Add(this.noticeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noticeTypeTB);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "makeCaseForm";
            this.Text = "makeCaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButt;
        private System.Windows.Forms.RichTextBox noticeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox noticeTypeTB;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}