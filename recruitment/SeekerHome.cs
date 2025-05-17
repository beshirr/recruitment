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
        private const string SearchPlaceholder = "Search by job title, loaction or keywords (e.g. Sales in Cairo)";
        public SeekerHome()
        {
            InitializeComponent();
            searchTextHolder.Text = SearchPlaceholder;
            searchTextHolder.ForeColor = System.Drawing.Color.Gray;
            searchTextHolder.GotFocus += searchTextHolder_GotFocus;
            searchTextHolder.LostFocus += searchTextHolder_LostFocus;

            lstJobs.DrawMode = DrawMode.OwnerDrawVariable;
            lstJobs.MeasureItem += lstJobs_MeasureItem;
            lstJobs.DrawItem += lstJobs_DrawItem;
            lstJobs.MouseDoubleClick += lstJobs_MouseDoubleClick;

            // Populate the job list on startup
            FilterJobs(string.Empty);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchTextHolder.Text.Trim();
            FilterJobs(searchText);
        }

        private void searchTextHolder_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextHolder.Text.Trim();
            FilterJobs(searchText);
        }

        private void searchTextHolder_GotFocus(object sender, EventArgs e)
        {
            if (searchTextHolder.Text == SearchPlaceholder)
            {
                searchTextHolder.Text = "";
                searchTextHolder.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextHolder_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextHolder.Text))
            {
                searchTextHolder.Text = SearchPlaceholder;
                searchTextHolder.ForeColor = System.Drawing.Color.Gray;
                // Reload all jobs when placeholder is set
                FilterJobs(string.Empty);
            }
        }

        private void FilterJobs(string searchText)
        {
            List<Vacancy> allJobs = GetAllJobs();

            List<Vacancy> filteredJobs;
            if (string.IsNullOrEmpty(searchText))
            {
                filteredJobs = allJobs;
            }
            else
            {
                filteredJobs = allJobs.Where(job =>
                    (!string.IsNullOrEmpty(job.JobTitle) && job.JobTitle.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(job.JobDescription) && job.JobDescription.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                ).ToList();

                if (filteredJobs.Count == 0)
                {
                    double threshold = 0.2;
                    filteredJobs = allJobs.Where(job =>
                        Similarity(searchText, job.JobTitle) >= threshold ||
                        Similarity(searchText, job.JobDescription) >= threshold
                    ).ToList();
                }
            }

            lstJobs.Items.Clear();
            foreach (var job in filteredJobs)
            {
                lstJobs.Items.Add(job);
            }
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
            string connStr = ConfigurationManager.ConnectionStrings["recruitment.Properties.Settings.recruitment"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Vacancies";
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

        private void SeekerHome_Load(object sender, EventArgs e)
        {
            this.vacanciesTableAdapter.Fill(this.recruitmentDataSet.Vacancies);
        }

        private void lstJobs_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstJobs.Items.Count) return;
            var job = lstJobs.Items[e.Index] as Vacancy;
            if (job == null) return;

            using (var titleFont = new System.Drawing.Font(lstJobs.Font, System.Drawing.FontStyle.Bold))
            using (var descFont = new System.Drawing.Font(lstJobs.Font, System.Drawing.FontStyle.Regular))
            {
                // Measure title
                var titleSize = e.Graphics.MeasureString(job.JobTitle, titleFont, lstJobs.Width);
                // Measure description
                var descSize = e.Graphics.MeasureString(job.JobDescription, descFont, lstJobs.Width);

                // Set item height (add some padding)
                e.ItemHeight = (int)(titleSize.Height + descSize.Height + 8);
            }
        }

        private void lstJobs_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0 || e.Index >= lstJobs.Items.Count) return;

            var job = lstJobs.Items[e.Index] as Vacancy;
            if (job == null) return;

            // Colors
            var titleColor = System.Drawing.Color.Black;
            var descColor = System.Drawing.Color.DimGray;

            // Fonts
            using (var titleFont = new System.Drawing.Font(lstJobs.Font.FontFamily, lstJobs.Font.Size + 2, System.Drawing.FontStyle.Bold))
            using (var descFont = new System.Drawing.Font(lstJobs.Font, System.Drawing.FontStyle.Regular))
            using (var titleBrush = new System.Drawing.SolidBrush(titleColor))
            using (var descBrush = new System.Drawing.SolidBrush(descColor))
            {
                float y = e.Bounds.Top + 2;
                // Draw title
                e.Graphics.DrawString(job.JobTitle, titleFont, titleBrush, e.Bounds.Left + 4, y);
                y += e.Graphics.MeasureString(job.JobTitle, titleFont, lstJobs.Width).Height;
                // Draw description
                e.Graphics.DrawString(job.JobDescription, descFont, descBrush, e.Bounds.Left + 4, y);
            }

            e.DrawFocusRectangle();
        }

        private void lstJobs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstJobs.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && lstJobs.Items[index] is Vacancy selectedVacancy)
            {
                var detailsForm = new JobDetailsForm(selectedVacancy);
                detailsForm.ShowDialog();
            }
        }
    }
}




