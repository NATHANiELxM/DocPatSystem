﻿using MySql.Data.MySqlClient;
namespace DocPatSystem.Doc
{
    partial class viewCaseDoc
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
            this.ackButt = new System.Windows.Forms.Button();
            this.replyTB = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendButt = new System.Windows.Forms.Button();
            this.noticeTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.noticeIDTB = new System.Windows.Forms.TextBox();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.toTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ackButt
            // 
            this.ackButt.BackColor = System.Drawing.Color.Yellow;
            this.ackButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ackButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ackButt.Location = new System.Drawing.Point(516, 366);
            this.ackButt.Name = "ackButt";
            this.ackButt.Size = new System.Drawing.Size(146, 34);
            this.ackButt.TabIndex = 33;
            this.ackButt.Text = "Acknowledged";
            this.ackButt.UseVisualStyleBackColor = false;
            // 
            // replyTB
            // 
            this.replyTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replyTB.Location = new System.Drawing.Point(85, 212);
            this.replyTB.Name = "replyTB";
            this.replyTB.Size = new System.Drawing.Size(725, 125);
            this.replyTB.TabIndex = 32;
            this.replyTB.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Reply:";
            // 
            // sendButt
            // 
            this.sendButt.BackColor = System.Drawing.Color.PaleGreen;
            this.sendButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButt.Location = new System.Drawing.Point(692, 366);
            this.sendButt.Name = "sendButt";
            this.sendButt.Size = new System.Drawing.Size(118, 34);
            this.sendButt.TabIndex = 30;
            this.sendButt.Text = "Reply";
            this.sendButt.UseVisualStyleBackColor = false;
            // 
            // noticeTB
            // 
            this.noticeTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeTB.Location = new System.Drawing.Point(85, 81);
            this.noticeTB.Name = "noticeTB";
            this.noticeTB.Size = new System.Drawing.Size(725, 125);
            this.noticeTB.TabIndex = 29;
            this.noticeTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Notice:";
            // 
            // noticeIDTB
            // 
            this.noticeIDTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeIDTB.Location = new System.Drawing.Point(751, 32);
            this.noticeIDTB.Name = "noticeIDTB";
            this.noticeIDTB.Size = new System.Drawing.Size(130, 23);
            this.noticeIDTB.TabIndex = 27;
            // 
            // fromTB
            // 
            this.fromTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTB.Location = new System.Drawing.Point(438, 32);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(130, 23);
            this.fromTB.TabIndex = 26;
            // 
            // toTB
            // 
            this.toTB.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTB.Location = new System.Drawing.Point(145, 32);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(130, 23);
            this.toTB.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Notice ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Origionator ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Recipient ID:";
            // 
            // viewCaseDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ackButt);
            this.Controls.Add(this.replyTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendButt);
            this.Controls.Add(this.noticeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noticeIDTB);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "viewCaseDoc";
            this.Size = new System.Drawing.Size(900, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ackButt;
        private System.Windows.Forms.RichTextBox replyTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendButt;
        private System.Windows.Forms.RichTextBox noticeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox noticeIDTB;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
