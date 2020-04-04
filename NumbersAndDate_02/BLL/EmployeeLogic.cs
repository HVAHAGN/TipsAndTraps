using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndDate_02.BLL
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
            Console.WriteLine($" Employee details {employee.FirstName}, " +
                $"\n Id: {employee.Id}, " +
                $"\n Salary: {employee.Salary}, " +
                $"\n Working days {string.Join(",",employee.WorkDays)}");

            const string threePartFormat = "(good employee) #; (bad employee) #; (new employee - not productivity yet)";
            Console.WriteLine($"Productivity rating: {employee.ProductivityRating.ToString(threePartFormat)}");
        }

        public static List<int> GenerateDefaultWorkDays()
        {
            var days= new List<int>();
            //for (int i = 1; i <= 5; i++)
            //{
            //    days.Add(i);
            //}
            // return days;
            return Enumerable.Range(1, 5).ToList();  //start:1 count:5
        }

        public static int GenerateRandomId()
        {
            using (RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[4];
                rnd.GetBytes(randomBytes);
                int result = BitConverter.ToInt32(randomBytes, 0);
                return result;

            }
            #region IdGenerate
            //Random rnd = new Random();
            //Random rnd1 = new Random(45);
            //Random rnd2 = new Random(45);
            //int x = rnd1.Next();
            //int x2 = rnd2.Next();

            ////var value = Guid.NewGuid();
            ////int id = int.Parse(value.ToString());
            ///
            #endregion
        }


        public static BigInteger GetSalary()
        {
            Console.WriteLine("Please enter your Salary");
            string input = Console.ReadLine();
            BigInteger salary = BigInteger.Parse(input);
            return salary;
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

        public static DateTime GetDateOfBirth()
        {

            Console.WriteLine("Please enter your BirtDate");
            string input = Console.ReadLine();
            DateTime a;
            if (!DateTime.TryParse(input, out a))
            {
                Console.WriteLine("Please enter valid date of birth");
            
            }
            else
            {
                a= DateTime.Parse(input);
            }
           
            return a;
        }
        public static int GetProductivity()
        {
            Console.WriteLine("Please enter productivity rating (-100 to 100) enter 0 for new employees");

            string input = Console.ReadLine();
            int rating = int.Parse(input, NumberStyles.Integer|NumberStyles.AllowParentheses);
            return rating;
        }
    }


}
    

