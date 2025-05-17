using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recruitment
{
    public partial class SeekerSignup : Form
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string password;
        public SeekerSignup(string firstName, string lastName, string email, string phone, string password)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.password = password;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            int experienceYears;
            if (int.TryParse(experienceYears_textbox.Text, out experienceYears))
            {

            }
            else
            {
                MessageBox.Show("Please enter an integer in the experience years field.");
                return;
            }
            string educationLevel = educationLevel_comboBox.Text;
            string skills = skills_textbox.Text.Trim();
            string certifications = certifications_textbox.Text.Trim();
            if (experienceYears_textbox.Text == "" || educationLevel == "" || skills == "" || certifications == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else 
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-HRLK7A2F\\MSSQLSERVER01;Initial Catalog=recruitment;Integrated Security=True");
                con.Open();
                string query = "INSERT INTO Seeker" +
                    "(FirstName, LastName, Email, Password, Phone, EducationLevel, ExperienceYears, Skills, Certifications)" +
                    "VALUES" +
                    "(@FirstName, @LastName, @Email, @Password, @Phone, @EducationLevel, @ExperienceYears, @Skills, @certifications);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@EducationLevel", educationLevel);
                cmd.Parameters.AddWithValue("@ExperienceYears", experienceYears);
                cmd.Parameters.AddWithValue("@Skills", skills);
                cmd.Parameters.AddWithValue("@Certifications", certifications);

                cmd.ExecuteNonQuery();
                con.Close();

                SeekerHome seekerHome = new SeekerHome();
                seekerHome.Show();
                this.Hide();
            }
        }
    }
}
