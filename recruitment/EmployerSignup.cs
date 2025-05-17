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
    public partial class EmployerSignup : Form
    {
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string password;
        public EmployerSignup(string firstname, string lastname, string email, string phone, string password)
        {
            InitializeComponent();
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.password = password;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string department = department_textbox.Text;
            string positionTitle = positionTitle_textbox.Text;
            string linkedinURL = linkedinURL_textbox.Text;

            if (department == "" || positionTitle == "" || linkedinURL == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-HRLK7A2F\\MSSQLSERVER01;Initial Catalog=OnlineRecruitment;Integrated Security=True");
            con.Open();
            string query = "INSERT INTO EMPLOYER (FirstName, LastName, Email, Password, Phone, PositionTitle, Department, LinkedInURL)" +
            "VALUES (@FirstName, @LastName, @Email, @Password, @Phone, @PositionTitle, @Department, @LinkedInURL);";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FirstName", firstname);
            cmd.Parameters.AddWithValue("@LastName", lastname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Positiontitle", positionTitle);
            cmd.Parameters.AddWithValue("@Department", department);
            cmd.Parameters.AddWithValue("@LinkedInURL", linkedinURL);

            cmd.ExecuteNonQuery();
            con.Close();
            // open employer home page
        }
    }
}
