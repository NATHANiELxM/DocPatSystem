namespace DocPatSystem
{
    partial class patientRecords
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
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viewButt = new System.Windows.Forms.Button();
            this.recordAccessButt = new System.Windows.Forms.Button();
            this.addNewPatientButt = new System.Windows.Forms.Button();
            this.searchButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(16, 20);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(182, 23);
            this.searchResultsLabel.TabIndex = 0;
            this.searchResultsLabel.Text = "All Patient Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 306);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(471, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 27);
            this.textBox1.TabIndex = 3;
            // 
            // viewButt
            // 
            this.viewButt.BackColor = System.Drawing.Color.Aquamarine;
            this.viewButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButt.Location = new System.Drawing.Point(73, 375);
            this.viewButt.Name = "viewButt";
            this.viewButt.Size = new System.Drawing.Size(98, 34);
            this.viewButt.TabIndex = 4;
            this.viewButt.Text = "View/Edit";
            this.viewButt.UseVisualStyleBackColor = false;
            this.viewButt.Click += new System.EventHandler(this.viewButt_Click);
            // 
            // recordAccessButt
            // 
            this.recordAccessButt.BackColor = System.Drawing.Color.PaleGreen;
            this.recordAccessButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordAccessButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordAccessButt.Location = new System.Drawing.Point(209, 375);
            this.recordAccessButt.Name = "recordAccessButt";
            this.recordAccessButt.Size = new System.Drawing.Size(132, 34);
            this.recordAccessButt.TabIndex = 5;
            this.recordAccessButt.Text = "Grant Access";
            this.recordAccessButt.UseVisualStyleBackColor = false;
            this.recordAccessButt.Click += new System.EventHandler(this.recordAccessButt_Click);
            // 
            // addNewPatientButt
            // 
            this.addNewPatientButt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewPatientButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewPatientButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPatientButt.Location = new System.Drawing.Point(682, 375);
            this.addNewPatientButt.Name = "addNewPatientButt";
            this.addNewPatientButt.Size = new System.Drawing.Size(178, 34);
            this.addNewPatientButt.TabIndex = 6;
            this.addNewPatientButt.Text = "Add New Patient";
            this.addNewPatientButt.UseVisualStyleBackColor = false;
            this.addNewPatientButt.Click += new System.EventHandler(this.addNewPatientButt_Click);
            // 
            // searchButt
            // 
            this.searchButt.BackColor = System.Drawing.Color.Aquamarine;
            this.searchButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButt.Location = new System.Drawing.Point(789, 19);
            this.searchButt.Name = "searchButt";
            this.searchButt.Size = new System.Drawing.Size(71, 28);
            this.searchButt.TabIndex = 7;
            this.searchButt.Text = "Search";
            this.searchButt.UseVisualStyleBackColor = false;
            this.searchButt.Click += new System.EventHandler(this.searchButt_Click);
            // 
            // patientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.searchButt);
            this.Controls.Add(this.addNewPatientButt);
            this.Controls.Add(this.recordAccessButt);
            this.Controls.Add(this.viewButt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchResultsLabel);
            this.Name = "patientRecords";
            this.Size = new System.Drawing.Size(900, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchResultsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button viewButt;
        private System.Windows.Forms.Button recordAccessButt;
        private System.Windows.Forms.Button addNewPatientButt;
        private System.Windows.Forms.Button searchButt;
    }
}
