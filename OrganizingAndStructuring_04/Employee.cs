using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingAndStructuring_04
{
    class Employee
    {
        public string FirstName { get; set; }
        public char EmployeeCode { get; set; }
        public int ProductivityRating { get; set; }
        public List<string> Skills { get; } = new List<string>();
        public string Bio { get; set; }
    }

}
