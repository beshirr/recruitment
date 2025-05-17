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
                                 (EmployerID, JobTitle, YearsofExperience, JobDescription, SkillsRequired, Salary, IsVisible) 
                                 VALUES (@EmployerID, @JobTitle, ,@YearsofExperience, @JobDescription, @SkillsRequired, @Salary, @IsVisible)";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployerID", vacancy.EmployerID);
                        cmd.Parameters.AddWithValue("@JobTitle", vacancy.JobTitle);
                        cmd.Parameters.AddWithValue("@YearsofExperience", vacancy.Years_of_Experience);
                        cmd.Parameters.AddWithValue("@JobDescription", vacancy.JobDescription);
                        cmd.Parameters.AddWithValue("@SkillsRequired", string.Join(",", vacancy.SkillsRequired));
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
        public static void UpdateVacancy(Vacancy vacancy)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"UPDATE Vacancy SET 
                                EmployerID = @EmployerID,
                                JobTitle = @JobTitle,
                                YearsofExperience =@Years_of_Experience,
                                JobDescription = @JobDescription,
                                SkillsRequired = @SkillsRequired,
                                Salary = @Salary,
                                IsVisible = @IsVisible
                             WHERE VacancyID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployerID", vacancy.EmployerID);
                        cmd.Parameters.AddWithValue("@JobTitle", vacancy.JobTitle);
                        cmd.Parameters.AddWithValue("@YearsofExperience", vacancy.Years_of_Experience);
                        cmd.Parameters.AddWithValue("@JobDescription", vacancy.JobDescription);
                        cmd.Parameters.AddWithValue("@SkillsRequired", vacancy.SkillsRequired);
                        cmd.Parameters.AddWithValue("@Salary", vacancy.Salary);
                        cmd.Parameters.AddWithValue("@IsVisible", vacancy.IsVisible);
                        cmd.Parameters.AddWithValue("@VacancyID", vacancy.VacancyID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy updated successfully.");
                        else
                            Console.WriteLine("No vacancy was updated (check VacancyID).");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating vacancy: " + ex.Message);
            }
        }
        public static void DeleteVacancy(int vacancyID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "DELETE FROM Vacancy WHERE VacancyID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VacancyID", vacancyID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy deleted successfully.");
                        else
                            Console.WriteLine("No vacancy found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting vacancy: " + ex.Message);
            }
        }

        public static void HideVacancy(int vacancyID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "UPDATE Vacancy SET IsVisible = 0 WHERE VacancyID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VacancyID", vacancyID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy hidden successfully.");
                        else
                            Console.WriteLine("No vacancy found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error hiding vacancy: " + ex.Message);
            }
        }
        public static void ShowVacancy(int vacancyID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "UPDATE Vacancy SET IsVisible = 1 WHERE VacancyID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VacancyID", vacancyID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Vacancy hidden successfully.");
                        else
                            Console.WriteLine("No vacancy found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error hiding vacancy: " + ex.Message);
            }
        }
        public static List<Vacancy> GetVacanciesByEmployer(int employerID)
        {
            List<Vacancy> vacancies = new List<Vacancy>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT VacancyID, EmployerID, JobTitle, JobDescription, SkillsRequired, ExperienceRequired, Salary, IsVisible 
                             FROM Vacancy WHERE EmployerID = @EmployerID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployerID", employerID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Vacancy v = new Vacancy
                                {
                                    VacancyID = reader.GetInt32(0),
                                    EmployerID = reader.GetInt32(1),
                                    JobTitle = reader.GetString(2),
                                    JobDescription = reader.GetString(3),
                                    SkillsRequired = reader.GetString(4).Split(',').Select(s => s.Trim()).ToList(),
                                    Years_of_Experience = reader.GetInt32(5),
                                    Salary = reader.GetDecimal(6),
                                    IsVisible = reader.GetBoolean(7)
                                };

                                vacancies.Add(v);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching vacancies: " + ex.Message);
            }

            return vacancies;
        }

        public static Vacancy GetVacancyById(int vacancyID)
        {
            Vacancy vacancy = null;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT VacancyID, EmployerID, JobTitle, JobDescription, SkillsRequired, ExperienceRequired, Salary, IsVisible 
                             FROM Vacancy WHERE VacancyID = @VacancyID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VacancyID", vacancyID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                vacancy = new Vacancy
                                {
                                    VacancyID = reader.GetInt32(0),
                                    EmployerID = reader.GetInt32(1),
                                    JobTitle = reader.GetString(2),
                                    JobDescription = reader.GetString(3),
                                    SkillsRequired = reader.GetString(4).Split(',').Select(s => s.Trim()).ToList(),
                                    Years_of_Experience = reader.GetInt32(5),
                                    Salary = reader.GetDecimal(6),
                                    IsVisible = reader.GetBoolean(7)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching vacancy by ID: " + ex.Message);
            }

            return vacancy;
        }
    }
}
