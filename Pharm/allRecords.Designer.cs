namespace DocPatSystem.Pharm
{
    partial class allRecords
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
            this.searchButt = new System.Windows.Forms.Button();
            this.viewButt = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButt
            // 
            this.searchButt.BackColor = System.Drawing.Color.Aquamarine;
            this.searchButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButt.Location = new System.Drawing.Point(801, 21);
            this.searchButt.Name = "searchButt";
            this.searchButt.Size = new System.Drawing.Size(71, 28);
            this.searchButt.TabIndex = 13;
            this.searchButt.Text = "Search";
            this.searchButt.UseVisualStyleBackColor = false;
            // 
            // viewButt
            // 
            this.viewButt.BackColor = System.Drawing.Color.Aquamarine;
            this.viewButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButt.Location = new System.Drawing.Point(85, 377);
            this.viewButt.Name = "viewButt";
            this.viewButt.Size = new System.Drawing.Size(98, 34);
            this.viewButt.TabIndex = 12;
            this.viewButt.Text = "View";
            this.viewButt.UseVisualStyleBackColor = false;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(483, 22);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(312, 27);
            this.searchTB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 306);
            this.dataGridView1.TabIndex = 9;
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(28, 22);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(182, 23);
            this.searchResultsLabel.TabIndex = 8;
            this.searchResultsLabel.Text = "All Patient Records";
            // 
            // allRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButt);
            this.Controls.Add(this.viewButt);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchResultsLabel);
            this.Name = "allRecords";
            this.Size = new System.Drawing.Size(900, 433);
            this.Load += new System.EventHandler(this.allRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButt;
        private System.Windows.Forms.Button viewButt;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label searchResultsLabel;
    }
}
