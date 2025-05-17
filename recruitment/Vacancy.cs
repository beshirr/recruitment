using System.Collections.Generic;

namespace recruitment
{
    public class Vacancy
    {

        public int VacancyID { get; set; }
        public int EmployerID { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public List<string> SkillsRequired { get; set; }
        public int Years_of_Experience { get; set; }
        public decimal Salary { get; set; }
        public Employer PostedBy { get; set; }
        public string Location { get; set; }
        public bool IsVisible { get; set; } = true;

        public Vacancy() { }

        public Vacancy(int vacancyId, int employerId, string jobTitle, string jobDescription, List<string> skillsRequired, int experienceRequired, decimal salary, bool isVisible)
        {
            VacancyID = vacancyId;
            EmployerID = employerId;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            SkillsRequired = skillsRequired;
            Years_of_Experience = experienceRequired;
            Salary = salary;
            IsVisible = isVisible;
        }
    }
}
