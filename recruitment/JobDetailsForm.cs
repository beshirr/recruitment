using System;
using System.Windows.Forms;

namespace recruitment
{
    public partial class JobDetailsForm : Form
    {
        private Vacancy _vacancy;

        public JobDetailsForm(Vacancy vacancy)
        {
            InitializeComponent();
            _vacancy = vacancy;
            DisplayJobDetails();
        }

        private void DisplayJobDetails()
        {
            lblTitle.Text = _vacancy.JobTitle;
            lblDescription.Text = _vacancy.JobDescription;
            lblSkills.Text = "Skills: " + string.Join(", ", _vacancy.SkillsRequired);
            lblExperience.Text = "Experience: " + _vacancy.ExperienceRequired;
            lblSalary.Text = "Salary: " + _vacancy.Salary.ToString("C");
            lblLocation.Text = "Location: " + _vacancy.Location;
            // Add more fields as needed
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Implement application logic here
            MessageBox.Show("Application submitted!");
        }

    }
}
