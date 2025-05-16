using System;
using System.Collections.Generic;

namespace recruitment

public class Vacancy
{
    public int VacancyID { get; set; }
    public string JobTitle { get; set; }
    public string JobDescription { get; set; }
    public decimal Salary { get; set; }
    public int ExperienceRequired { get; set; }
    public List<string> SkillsRequired { get; set; } = new();

    public Employer PostedBy { get; set; }


}