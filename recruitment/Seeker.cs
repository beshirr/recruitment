using System;
using System.Collections.Generic;

namespace recruitment
{
    internal class Seeker : User 
    {
        public int experience_years { get; set; }
        public string education_level { get; set; }
        public List<string> skills { get; set; }
        public List<string> certifications { get; set; }
        // public List<Application> applications { get; set; }
    }
}