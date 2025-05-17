using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recruitment
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            string firstname = firstName_textbox.Text;
            string lastname = lastName_textbox.Text;
            string email = email_textbox.Text;
            string phone = phone_textbox.Text;
            string password = password_textbox.Text;
            string confirmPassword = confirmPass_textbox.Text;

            if (firstname == "" || lastname == "" || email == "" || phone == "" || password == "" || confirmPassword == "" || (!employer_radioButton.Checked && !seeker_radioButton.Checked))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("password should be atleast 6 characters");
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Password and password confirmation don't match");
                return;
            }

            if (employer_radioButton.Checked) 
            {
                EmployerSignup employerSignup = new EmployerSignup(firstname, lastname, email, phone, password);
                employerSignup.Show();
                this.Hide();
                return;
            }
            else if (seeker_radioButton.Checked)
            {
                SeekerSignup seekerSignup = new SeekerSignup(firstname, lastname, email, phone, password);
                seekerSignup.Show();
                this.Hide();
                return;
            }

        }
    }
}
