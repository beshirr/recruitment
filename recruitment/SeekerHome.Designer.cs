namespace recruitment
{
    partial class SeekerHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextHolder = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find your suitable job, easily";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchTextHolder
            // 
            this.searchTextHolder.Location = new System.Drawing.Point(182, 83);
            this.searchTextHolder.Name = "searchTextHolder";
            this.searchTextHolder.Size = new System.Drawing.Size(376, 22);
            this.searchTextHolder.TabIndex = 1;
            this.searchTextHolder.Text = "Search by job title, loaction or keywords (e.g. Sales in Cairo)";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(564, 83);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(182, 140);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(457, 284);
            this.dgvResults.TabIndex = 3;
            // 
            // SeekerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextHolder);
            this.Controls.Add(this.label1);
            this.Name = "SeekerHome";
            this.Text = "SeekerHome";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextHolder;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}