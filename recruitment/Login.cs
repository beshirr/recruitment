using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace recruitment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string email = email_textbox.Text;
            string password = password_textbox.Text;
            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password");
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HRLK7A2F\\MSSQLSERVER01;Initial Catalog=recruitment;Integrated Security=True");
            conn.Open();
            string seekerQuery = "SELECT email, password FROM Seeker WHERE Email = @Email AND Password = @Password";
            string employerQuery = "SELECT email, password FROM Employer WHERE Email = @Email AND Password = @Password";

            SqlCommand cmd = new SqlCommand(seekerQuery, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            {
                reader.Close();
                SeekerHome seekerHome = new SeekerHome();
                seekerHome.Show();
                this.Hide();
                return;
            }
            reader.Close();

            SqlCommand cmd2 = new SqlCommand(employerQuery, conn);
            cmd2.Parameters.AddWithValue("@Email", email);
            cmd2.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.HasRows) 
            {
                reader2.Close();
                // Go To Employer home;
                return;
            }
            reader2.Close();


            MessageBox.Show("Wrong email or password!");
            return;

        }
    }
}
