namespace recruitment
{
    partial class EmployerSignup
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
            this.title_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.positionTitle_label = new System.Windows.Forms.Label();
            this.linkedinURL_label = new System.Windows.Forms.Label();
            this.department_textbox = new System.Windows.Forms.TextBox();
            this.positionTitle_textbox = new System.Windows.Forms.TextBox();
            this.linkedinURL_textbox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(293, 52);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(211, 29);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Please fill the form";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_label.Location = new System.Drawing.Point(115, 143);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(91, 17);
            this.department_label.TabIndex = 1;
            this.department_label.Text = "Deparrment :";
            // 
            // positionTitle_label
            // 
            this.positionTitle_label.AutoSize = true;
            this.positionTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionTitle_label.Location = new System.Drawing.Point(115, 198);
            this.positionTitle_label.Name = "positionTitle_label";
            this.positionTitle_label.Size = new System.Drawing.Size(92, 17);
            this.positionTitle_label.TabIndex = 2;
            this.positionTitle_label.Text = "Position title :";
            // 
            // linkedinURL_label
            // 
            this.linkedinURL_label.AutoSize = true;
            this.linkedinURL_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedinURL_label.Location = new System.Drawing.Point(115, 257);
            this.linkedinURL_label.Name = "linkedinURL_label";
            this.linkedinURL_label.Size = new System.Drawing.Size(101, 17);
            this.linkedinURL_label.TabIndex = 3;
            this.linkedinURL_label.Text = "LinkedIn URL :";
            // 
            // department_textbox
            // 
            this.department_textbox.Location = new System.Drawing.Point(311, 143);
            this.department_textbox.Name = "department_textbox";
            this.department_textbox.Size = new System.Drawing.Size(193, 20);
            this.department_textbox.TabIndex = 4;
            this.department_textbox.Text = "Enter your department ";
            // 
            // positionTitle_textbox
            // 
            this.positionTitle_textbox.Location = new System.Drawing.Point(311, 198);
            this.positionTitle_textbox.Name = "positionTitle_textbox";
            this.positionTitle_textbox.Size = new System.Drawing.Size(193, 20);
            this.positionTitle_textbox.TabIndex = 5;
            this.positionTitle_textbox.Text = "Enter your position title";
            // 
            // linkedinURL_textbox
            // 
            this.linkedinURL_textbox.Location = new System.Drawing.Point(311, 257);
            this.linkedinURL_textbox.Name = "linkedinURL_textbox";
            this.linkedinURL_textbox.Size = new System.Drawing.Size(193, 20);
            this.linkedinURL_textbox.TabIndex = 6;
            this.linkedinURL_textbox.Text = "Enter your profile URL";
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(358, 357);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(88, 35);
            this.submit_button.TabIndex = 7;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // EmployerSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.linkedinURL_textbox);
            this.Controls.Add(this.positionTitle_textbox);
            this.Controls.Add(this.department_textbox);
            this.Controls.Add(this.linkedinURL_label);
            this.Controls.Add(this.positionTitle_label);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.title_label);
            this.Name = "EmployerSignup";
            this.Text = "Employer Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label positionTitle_label;
        private System.Windows.Forms.Label linkedinURL_label;
        private System.Windows.Forms.TextBox department_textbox;
        private System.Windows.Forms.TextBox positionTitle_textbox;
        private System.Windows.Forms.TextBox linkedinURL_textbox;
        private System.Windows.Forms.Button submit_button;
    }
}