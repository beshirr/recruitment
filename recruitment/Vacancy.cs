using System.Collections.Generic;

namespace recruitment
{
    public class Vacancy
    {

        public int VACANCYID { get; set; }
        public int COMPANYID_ { get; set; }
        public string V_JOBTITLE { get; set; }
        public string V_JOBDESCRIPTION { get; set; }
        public List<string> V_SKILLSREQUIRED { get; set; }
        public int V_EXPERIENCEREQUIRED { get; set; }
        public decimal V_SALARY { get; set; }
        public Employer PostedBy { get; set; }
        public string Location { get; set; }
        public bool ISVISIBLE { get; set; } = true;

        public Vacancy() { }

        public Vacancy(int vacancyId, int employerId, string jobTitle, string jobDescription, List<string> skillsRequired, int experienceRequired, decimal salary, bool isVisible)
        {
            VACANCYID = vacancyId;
            COMPANYID_ = employerId;
            V_JOBTITLE = jobTitle;
            V_JOBDESCRIPTION = jobDescription;
            V_SKILLSREQUIRED = skillsRequired;
            V_EXPERIENCEREQUIRED = experienceRequired;
            V_SALARY = salary;
            ISVISIBLE = isVisible;
        }
    }
}
