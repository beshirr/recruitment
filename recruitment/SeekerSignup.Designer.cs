namespace recruitment
{
    partial class SeekerSignup
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
            this.experienceYears_label = new System.Windows.Forms.Label();
            this.educationLevel_label = new System.Windows.Forms.Label();
            this.skills_label = new System.Windows.Forms.Label();
            this.certifications_label = new System.Windows.Forms.Label();
            this.experienceYears_textbox = new System.Windows.Forms.TextBox();
            this.skills_textbox = new System.Windows.Forms.TextBox();
            this.certifications_textbox = new System.Windows.Forms.TextBox();
            this.educationLevel_comboBox = new System.Windows.Forms.ComboBox();
            this.title_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // experienceYears_label
            // 
            this.experienceYears_label.AutoSize = true;
            this.experienceYears_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experienceYears_label.Location = new System.Drawing.Point(136, 147);
            this.experienceYears_label.Name = "experienceYears_label";
            this.experienceYears_label.Size = new System.Drawing.Size(125, 17);
            this.experienceYears_label.TabIndex = 0;
            this.experienceYears_label.Text = "Experience years :";
            // 
            // educationLevel_label
            // 
            this.educationLevel_label.AutoSize = true;
            this.educationLevel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationLevel_label.Location = new System.Drawing.Point(136, 193);
            this.educationLevel_label.Name = "educationLevel_label";
            this.educationLevel_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.educationLevel_label.Size = new System.Drawing.Size(112, 17);
            this.educationLevel_label.TabIndex = 1;
            this.educationLevel_label.Text = "Education level :";
            // 
            // skills_label
            // 
            this.skills_label.AutoSize = true;
            this.skills_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skills_label.Location = new System.Drawing.Point(136, 237);
            this.skills_label.Name = "skills_label";
            this.skills_label.Size = new System.Drawing.Size(48, 17);
            this.skills_label.TabIndex = 2;
            this.skills_label.Text = "Skills :";
            // 
            // certifications_label
            // 
            this.certifications_label.AutoSize = true;
            this.certifications_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certifications_label.Location = new System.Drawing.Point(136, 277);
            this.certifications_label.Name = "certifications_label";
            this.certifications_label.Size = new System.Drawing.Size(97, 17);
            this.certifications_label.TabIndex = 3;
            this.certifications_label.Text = "Certifications :";
            // 
            // experienceYears_textbox
            // 
            this.experienceYears_textbox.Location = new System.Drawing.Point(353, 144);
            this.experienceYears_textbox.Name = "experienceYears_textbox";
            this.experienceYears_textbox.Size = new System.Drawing.Size(207, 20);
            this.experienceYears_textbox.TabIndex = 4;
            this.experienceYears_textbox.Text = "Enter the number of years of experience";
            // 
            // skills_textbox
            // 
            this.skills_textbox.Location = new System.Drawing.Point(353, 234);
            this.skills_textbox.Name = "skills_textbox";
            this.skills_textbox.Size = new System.Drawing.Size(207, 20);
            this.skills_textbox.TabIndex = 6;
            this.skills_textbox.Text = "Write your skills comma seperated";
            // 
            // certifications_textbox
            // 
            this.certifications_textbox.Location = new System.Drawing.Point(353, 274);
            this.certifications_textbox.Name = "certifications_textbox";
            this.certifications_textbox.Size = new System.Drawing.Size(207, 20);
            this.certifications_textbox.TabIndex = 7;
            this.certifications_textbox.Text = "Write your certifications comma seperated";
            // 
            // educationLevel_comboBox
            // 
            this.educationLevel_comboBox.FormattingEnabled = true;
            this.educationLevel_comboBox.Items.AddRange(new object[] {
            "Diploma",
            "Bachelor",
            "Master",
            "PhD",
            "High School"});
            this.educationLevel_comboBox.Location = new System.Drawing.Point(353, 193);
            this.educationLevel_comboBox.Name = "educationLevel_comboBox";
            this.educationLevel_comboBox.Size = new System.Drawing.Size(172, 21);
            this.educationLevel_comboBox.TabIndex = 8;
            this.educationLevel_comboBox.Text = "Choose your education level";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(271, 55);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(211, 29);
            this.title_label.TabIndex = 9;
            this.title_label.Text = "Please fill the form";
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(353, 370);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(88, 31);
            this.submit_button.TabIndex = 10;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // SeekerSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.educationLevel_comboBox);
            this.Controls.Add(this.certifications_textbox);
            this.Controls.Add(this.skills_textbox);
            this.Controls.Add(this.experienceYears_textbox);
            this.Controls.Add(this.certifications_label);
            this.Controls.Add(this.skills_label);
            this.Controls.Add(this.educationLevel_label);
            this.Controls.Add(this.experienceYears_label);
            this.Name = "SeekerSignup";
            this.Text = "Seeker Sign-up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label experienceYears_label;
        private System.Windows.Forms.Label educationLevel_label;
        private System.Windows.Forms.Label skills_label;
        private System.Windows.Forms.Label certifications_label;
        private System.Windows.Forms.TextBox experienceYears_textbox;
        private System.Windows.Forms.TextBox skills_textbox;
        private System.Windows.Forms.TextBox certifications_textbox;
        private System.Windows.Forms.ComboBox educationLevel_comboBox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button submit_button;
    }
}