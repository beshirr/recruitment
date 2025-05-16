using System;
using System.Collections.Generic;

namespace recruitment
{
    internal class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<string> phone_numbers { get; set; }
    }
}