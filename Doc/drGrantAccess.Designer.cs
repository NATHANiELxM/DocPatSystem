using MySql.Data.MySqlClient;
namespace DocPatSystem.Doc
{
    partial class drGrantAccess
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
            this.denyAccButt = new System.Windows.Forms.Button();
            this.grantAccButt = new System.Windows.Forms.Button();
            this.requestingAccessTB = new System.Windows.Forms.RichTextBox();
            this.hasAccessTB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // denyAccButt
            // 
            this.denyAccButt.BackColor = System.Drawing.Color.PaleVioletRed;
            this.denyAccButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denyAccButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyAccButt.Location = new System.Drawing.Point(666, 331);
            this.denyAccButt.Name = "denyAccButt";
            this.denyAccButt.Size = new System.Drawing.Size(100, 64);
            this.denyAccButt.TabIndex = 18;
            this.denyAccButt.Text = "Deny Access";
            this.denyAccButt.UseVisualStyleBackColor = false;
            // 
            // grantAccButt
            // 
            this.grantAccButt.BackColor = System.Drawing.Color.PaleGreen;
            this.grantAccButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grantAccButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantAccButt.Location = new System.Drawing.Point(468, 331);
            this.grantAccButt.Name = "grantAccButt";
            this.grantAccButt.Size = new System.Drawing.Size(100, 64);
            this.grantAccButt.TabIndex = 17;
            this.grantAccButt.Text = "Grant Access";
            this.grantAccButt.UseVisualStyleBackColor = false;
            // 
            // requestingAccessTB
            // 
            this.requestingAccessTB.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestingAccessTB.Location = new System.Drawing.Point(468, 79);
            this.requestingAccessTB.Name = "requestingAccessTB";
            this.requestingAccessTB.ReadOnly = true;
            this.requestingAccessTB.Size = new System.Drawing.Size(298, 224);
            this.requestingAccessTB.TabIndex = 16;
            this.requestingAccessTB.Text = "";
            // 
            // hasAccessTB
            // 
            this.hasAccessTB.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasAccessTB.Location = new System.Drawing.Point(39, 79);
            this.hasAccessTB.Name = "hasAccessTB";
            this.hasAccessTB.ReadOnly = true;
            this.hasAccessTB.Size = new System.Drawing.Size(296, 224);
            this.hasAccessTB.TabIndex = 15;
            this.hasAccessTB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Requesting Access:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Has Access:";
            // 
            // drGrantAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.denyAccButt);
            this.Controls.Add(this.grantAccButt);
            this.Controls.Add(this.requestingAccessTB);
            this.Controls.Add(this.hasAccessTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "drGrantAccess";
            this.Text = "drGrantAccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button denyAccButt;
        private System.Windows.Forms.Button grantAccButt;
        private System.Windows.Forms.RichTextBox requestingAccessTB;
        private System.Windows.Forms.RichTextBox hasAccessTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}