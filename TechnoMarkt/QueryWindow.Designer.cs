namespace TechnoMarkt
{
    partial class QueryWindow
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
            this.sqlCommand = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.productDetails = new System.Windows.Forms.Button();
            this.workerDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlCommand
            // 
            this.sqlCommand.Location = new System.Drawing.Point(12, 26);
            this.sqlCommand.Name = "sqlCommand";
            this.sqlCommand.Size = new System.Drawing.Size(666, 20);
            this.sqlCommand.TabIndex = 0;
            this.sqlCommand.Text = "You can write here any SQL command and run..";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(703, 17);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(76, 37);
            this.run.TabIndex = 1;
            this.run.Text = "RUN";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // productDetails
            // 
            this.productDetails.Location = new System.Drawing.Point(134, 66);
            this.productDetails.Name = "productDetails";
            this.productDetails.Size = new System.Drawing.Size(223, 23);
            this.productDetails.TabIndex = 2;
            this.productDetails.Text = "List Products Details";
            this.productDetails.UseVisualStyleBackColor = true;
            this.productDetails.Click += new System.EventHandler(this.productDetails_Click);
            // 
            // workerDetails
            // 
            this.workerDetails.Location = new System.Drawing.Point(427, 66);
            this.workerDetails.Name = "workerDetails";
            this.workerDetails.Size = new System.Drawing.Size(223, 23);
            this.workerDetails.TabIndex = 3;
            this.workerDetails.Text = "List Worker Details";
            this.workerDetails.UseVisualStyleBackColor = true;
            this.workerDetails.Click += new System.EventHandler(this.workerDetails_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(767, 361);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.TabStop = false;
            // 
            // QueryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.workerDetails);
            this.Controls.Add(this.productDetails);
            this.Controls.Add(this.run);
            this.Controls.Add(this.sqlCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QueryWindow";
            this.Text = "Query";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqlCommand;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button productDetails;
        private System.Windows.Forms.Button workerDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}