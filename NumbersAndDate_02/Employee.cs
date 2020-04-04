using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndDate_02
{
    public class Employee
    {
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ProductivityRating { get; set; }
        public BigInteger Salary { get; set; }
        public int Id { get; set; }
        public List<int> WorkDays { get; set; }
    }
}
