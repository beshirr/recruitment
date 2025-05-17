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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.searchTextHolder = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.vacanciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recruitmentDataSet = new recruitment.recruitmentDataSet();
            this.vacanciesTableAdapter = new recruitment.recruitmentDataSetTableAdapters.VacanciesTableAdapter();
            this.lstJobs = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(179, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(176, 16);
            label1.TabIndex = 0;
            label1.Text = "Find your suitable job, easily";
            // 
            // searchTextHolder
            // 
            this.searchTextHolder.Location = new System.Drawing.Point(182, 83);
            this.searchTextHolder.Name = "searchTextHolder";
            this.searchTextHolder.Size = new System.Drawing.Size(376, 22);
            this.searchTextHolder.TabIndex = 1;
            this.searchTextHolder.Text = "Search by job title, loaction or keywords (e.g. Sales in Cairo)";
            this.searchTextHolder.TextChanged += new System.EventHandler(this.searchTextHolder_TextChanged);
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
            // vacanciesBindingSource
            // 
            this.vacanciesBindingSource.DataMember = "Vacancies";
            this.vacanciesBindingSource.DataSource = this.recruitmentDataSet;
            // 
            // recruitmentDataSet
            // 
            this.recruitmentDataSet.DataSetName = "recruitmentDataSet";
            this.recruitmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacanciesTableAdapter
            // 
            this.vacanciesTableAdapter.ClearBeforeFill = true;
            // 
            // lstJobs
            // 
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 16;
            this.lstJobs.Location = new System.Drawing.Point(182, 111);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(457, 292);
            this.lstJobs.TabIndex = 3;
            // 
            // SeekerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextHolder);
            this.Controls.Add(label1);
            this.Name = "SeekerHome";
            this.Text = "90";
            this.Load += new System.EventHandler(this.SeekerHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextHolder;
        private System.Windows.Forms.Button searchBtn;
        private recruitmentDataSet recruitmentDataSet;
        private System.Windows.Forms.BindingSource vacanciesBindingSource;
        private recruitmentDataSetTableAdapters.VacanciesTableAdapter vacanciesTableAdapter;
        private System.Windows.Forms.ListBox lstJobs;
    }
}