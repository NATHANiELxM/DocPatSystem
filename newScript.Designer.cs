namespace DocPatSystem
{
    partial class newScript
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
            this.inputPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.RichTextBox();
            this.add2ScriptButt = new System.Windows.Forms.Button();
            this.refillAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prescriptionName = new System.Windows.Forms.RichTextBox();
            this.pharmacyID = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientID = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendScriptReq = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refillAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.label7);
            this.inputPanel.Controls.Add(this.instructions);
            this.inputPanel.Controls.Add(this.add2ScriptButt);
            this.inputPanel.Controls.Add(this.refillAmount);
            this.inputPanel.Controls.Add(this.label5);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.prescriptionName);
            this.inputPanel.Controls.Add(this.pharmacyID);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.patientID);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputPanel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(450, 433);
            this.inputPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Prescription Infromation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Instructions:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(200, 216);
            this.instructions.MaxLength = 1000;
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(206, 66);
            this.instructions.TabIndex = 25;
            this.instructions.Text = "";
            this.instructions.TextChanged += new System.EventHandler(this.instructions_TextChanged);
            // 
            // add2ScriptButt
            // 
            this.add2ScriptButt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.add2ScriptButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add2ScriptButt.Location = new System.Drawing.Point(96, 357);
            this.add2ScriptButt.Name = "add2ScriptButt";
            this.add2ScriptButt.Size = new System.Drawing.Size(247, 35);
            this.add2ScriptButt.TabIndex = 24;
            this.add2ScriptButt.Text = "Add To Prescription   ---->";
            this.add2ScriptButt.UseVisualStyleBackColor = false;
            this.add2ScriptButt.Click += new System.EventHandler(this.add2ScriptButt_Click);
            // 
            // refillAmount
            // 
            this.refillAmount.Location = new System.Drawing.Point(349, 308);
            this.refillAmount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.refillAmount.Name = "refillAmount";
            this.refillAmount.Size = new System.Drawing.Size(57, 27);
            this.refillAmount.TabIndex = 23;
            this.refillAmount.ValueChanged += new System.EventHandler(this.refillAmount_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Refill:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Prescrrption:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // prescriptionName
            // 
            this.prescriptionName.Location = new System.Drawing.Point(200, 172);
            this.prescriptionName.MaxLength = 50;
            this.prescriptionName.Name = "prescriptionName";
            this.prescriptionName.Size = new System.Drawing.Size(206, 26);
            this.prescriptionName.TabIndex = 20;
            this.prescriptionName.Text = "";
            this.prescriptionName.TextChanged += new System.EventHandler(this.prescriptionName_TextChanged);
            // 
            // pharmacyID
            // 
            this.pharmacyID.Location = new System.Drawing.Point(200, 128);
            this.pharmacyID.MaxLength = 25;
            this.pharmacyID.Name = "pharmacyID";
            this.pharmacyID.Size = new System.Drawing.Size(206, 26);
            this.pharmacyID.TabIndex = 19;
            this.pharmacyID.Text = "";
            this.pharmacyID.TextChanged += new System.EventHandler(this.pharmacyID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pharmacy ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // patientID
            // 
            this.patientID.BackColor = System.Drawing.SystemColors.Window;
            this.patientID.Location = new System.Drawing.Point(200, 89);
            this.patientID.MaxLength = 25;
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(206, 26);
            this.patientID.TabIndex = 17;
            this.patientID.Text = "";
            this.patientID.TextChanged += new System.EventHandler(this.patientID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Patient ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sendScriptReq
            // 
            this.sendScriptReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sendScriptReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendScriptReq.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendScriptReq.Location = new System.Drawing.Point(747, 377);
            this.sendScriptReq.Name = "sendScriptReq";
            this.sendScriptReq.Size = new System.Drawing.Size(128, 30);
            this.sendScriptReq.TabIndex = 15;
            this.sendScriptReq.Text = "Send Request";
            this.sendScriptReq.UseVisualStyleBackColor = false;
            this.sendScriptReq.Click += new System.EventHandler(this.sendScriptReq_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 267);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Current Prescription:";
            // 
            // newScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.sendScriptReq);
            this.Name = "newScript";
            this.Size = new System.Drawing.Size(900, 433);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refillAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox instructions;
        private System.Windows.Forms.Button add2ScriptButt;
        private System.Windows.Forms.NumericUpDown refillAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox prescriptionName;
        private System.Windows.Forms.RichTextBox pharmacyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox patientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendScriptReq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
    }
}
