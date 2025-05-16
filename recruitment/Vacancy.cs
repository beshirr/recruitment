using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recruitment
{
    internal class Vacancy
    {

        public int VacancyID { get; set; }
        public int EmployerID { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string SkillsRequired { get; set; }
        public int ExperienceRequired { get; set; }
        public decimal Salary { get; set; }
        public bool IsVisible { get; set; } = true;

        public Vacancy() { }

        public Vacancy(int vacancyId, int employerId, string jobTitle, string jobDescription, string skillsRequired, int experienceRequired, decimal salary, bool isVisible)
        {
            VacancyID = vacancyId;
            EmployerID = employerId;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            SkillsRequired = skillsRequired;
            ExperienceRequired = experienceRequired;
            Salary = salary;
            IsVisible = isVisible;
        } 

    }
}
