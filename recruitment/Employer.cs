using System;
using System.Collections.Generic;

namespace recruitment
{
    internal class Employer : User
    {
        public string PositionTitle { get; set; }
        public string Department { get; set; }
        public string LinkedInURL { get; set; }
        public int JobCount { get; set; }

        // public Company Company { get; set; }
        // public List<Vacancy> PostedVacancies { get; set; } = new();
    }
}
