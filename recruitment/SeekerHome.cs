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
                Similarity(searchText, job.Title) >= threshold ||
                Similarity(searchText, job.Location) >= threshold ||
                Similarity(searchText, job.Field) >= threshold
            ).ToList();

            dgvResults.DataSource = filteredJobs;
        }

       
    }
}




