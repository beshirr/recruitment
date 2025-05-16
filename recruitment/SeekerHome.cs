using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace recruitment
{
    public partial class SeekerHome : Form
    {
        public SeekerHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchTextHolder.Text.Trim();

            List<Vacancy> allJobs = GetAllJobs();

            double threshold = 0.5;

            var filteredJobs = allJobs.Where(job =>
                Similarity(searchText, job.JobTitle) >= threshold ||
                Similarity(searchText, job.Location) >= threshold
            ).ToList();

            dgvResults.DataSource = filteredJobs;

        }

        private double Similarity(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return 0.0;

            var pairs1 = WordLetterPairs(s1.ToUpper());
            var pairs2 = WordLetterPairs(s2.ToUpper());
            int intersection = 0;
            int totalPairs = pairs1.Count + pairs2.Count;

            foreach (var pair1 in pairs1)
            {
                for (int j = 0; j < pairs2.Count; j++)
                {
                    if (pair1 == pairs2[j])
                    {
                        intersection++;
                        pairs2.RemoveAt(j);
                        break;
                    }
                }
            }
            return (2.0 * intersection) / totalPairs;
        }

        private List<string> WordLetterPairs(string str)
        {
            var allPairs = new List<string>();
            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    var pairsInWord = LetterPairs(word);
                    allPairs.AddRange(pairsInWord);
                }
            }
            return allPairs;
        }

        private List<string> LetterPairs(string str)
        {
            var pairs = new List<string>();
            for (int i = 0; i < str.Length - 1; i++)
            {
                pairs.Add(str.Substring(i, 2));
            }
            return pairs;
        }

        private List<Vacancy> GetAllJobs()
        {
            var jobs = new List<Vacancy>();
            string connStr = ConfigurationManager.ConnectionStrings["recruiment"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                // TODO: replace with the actual database
                string query = "SELECT Id, Title, Location, Field FROM Vacancies";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jobs.Add(new Vacancy
                        {
                            VacancyID = reader.GetInt32(0),
                            JobTitle = reader.GetString(1),
                            JobDescription = reader.GetString(2),
                            Salary = reader.GetDecimal(3),
                            ExperienceRequired = reader.GetInt32(4),
                            SkillsRequired = reader.GetString(5).Split(',').ToList(),
                            PostedBy = new Employer { Id = reader.GetInt32(6), firstName = reader.GetString(7) }
                        });
                    }
                }
            }
            return jobs;
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResults.Columns[e.ColumnIndex].Name == "Apply" && e.RowIndex >= 0)
            {
                var selectedVacancy = (Vacancy)dgvResults.Rows[e.RowIndex].DataBoundItem;

                //int currentUserId = GetCurrentUserId();

                //RecordApplication(currentUserId, selectedVacancy.Id);

                MessageBox.Show("Application submitted!");
            }
        }

        private void RecordApplication(int userId, int vacancyId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["RecruitmentDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO Applications (UserId, VacancyId, AppliedOn) VALUES (@UserId, @VacancyId, @AppliedOn)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@VacancyId", vacancyId);
                    cmd.Parameters.AddWithValue("@AppliedOn", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void searchTextHolder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




