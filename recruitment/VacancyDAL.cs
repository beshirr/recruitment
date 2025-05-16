using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace recruitment
{
    internal class VacancyDAL

    {

        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=JobPortalDB;Integrated Security=True";
        public static void inserVacancy(Vacancy vacancy)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Vacancy 
                                 (EmployerID, JobTitle, JobDescription, SkillsRequired, Salary, IsVisible) 
                                 VALUES (@EmployerID, @JobTitle, @JobDescription, @ExperienceRequired, @Salary, @IsVisible)";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployerID", vacancy.EmployerID);
                        cmd.Parameters.AddWithValue("@JobTitle", vacancy.JobTitle);
                        cmd.Parameters.AddWithValue("@JobDescription", vacancy.JobDescription);
                        cmd.Parameters.AddWithValue("@SkillsRequired", vacancy.SkillsRequired);
                        cmd.Parameters.AddWithValue("@Salary", vacancy.Salary);
                        cmd.Parameters.AddWithValue("@IsVisible", vacancy.IsVisible);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy inserted successfully.");
                        else
                            Console.WriteLine("No vacancy was inserted.");
                    


                    }




                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error inserting vacancy: " + ex.Message);

            }

        }
    }
}
