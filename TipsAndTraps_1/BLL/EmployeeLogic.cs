using StringEmptyNull_01;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEmptyNull_01.BLL
{
    public static class EmployeeLogic
    {
        public static bool IsAllWhiteSpace(string s)
        {
            if (s.Replace(" ", "").Length == 0)
            {
                return true;
            }
            return false;
        }
        public static void DisplayEmployee(Employee employee)
        {
            var skills = "";
            foreach (var skill in employee.Skills)
            {
                skills += $"{skill}, ";
            }

            //Second version 
            var sb = new StringBuilder();
            foreach (var skill in employee.Skills)
            {
                sb.Append(skill);
                sb.Append(", ");
            }

            Console.WriteLine($"Employee details {employee.FirstName}, {employee.Bio}, Skills: {skills} /n Or second version {sb.ToString()}");

            const string threePartFormat = "(good employee) #; (bad employee) #; (new employee - not productivity yet)";
            Console.WriteLine($"Productivity rating: {employee.ProductivityRating.ToString(threePartFormat)}");
            string prod = string.Format(new EmployeeProductivityFormatProvider(),
                                         "Productivity custom mehtod {0}", employee.ProductivityRating);
            Console.WriteLine(prod);

        }


        public static string GetFirstName()
        {
            while (true)
            {
                Console.WriteLine("Please enter first name");
                string firstName = Console.ReadLine();
                //if (firstName==null||firstName.Length==0||String.IsNullOrEmpty(firstName)|| IsAllWhiteSpace(firstName))
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.WriteLine("Error: Invalid first name");
                }
                else
                {
                    return firstName;
                }
            }
        }

        public static char GetEmployeeCode()
        {
            while (true)
            {
                Console.WriteLine("Please enter employee code");
                char employeeCode = Console.ReadLine().First();
                //employeeCode = (char)888;
                UnicodeCategory ucCategory = char.GetUnicodeCategory(employeeCode);

                bool isValidUnicode = ucCategory != UnicodeCategory.OtherNotAssigned;
                if (!isValidUnicode)
                {
                    Console.WriteLine("Error: not valid employee code or character");
                }
                else
                {
                    return employeeCode;

                }
            }
        }


        public static int GetProductivity()
        {
            Console.WriteLine("Please enter productivity rating (-100 to 100) enter 0 for new employees");
            int rating = int.Parse(Console.ReadLine());
            return rating;
        }

        public static void GetSkillsFor(Employee employee)
        {
            employee.Skills.Add("C#");
            employee.Skills.Add("C++");
            employee.Skills.Add("Java");
            employee.Skills.Add("SQL");
            employee.Skills.Add("JS");
            employee.Skills.Add("Json");
        }
        public static void GetBioFor(Employee employee)
        {
            employee.Bio = "A darn hard working employee...";
        }

    }
}
