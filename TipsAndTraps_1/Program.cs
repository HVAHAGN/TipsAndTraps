using StringEmptyNull_01.BLL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringEmptyNull_01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.FirstName = EmployeeLogic.GetFirstName();
            employee.EmployeeCode = EmployeeLogic.GetEmployeeCode();
            employee.ProductivityRating = EmployeeLogic.GetProductivity();
            EmployeeLogic.GetSkillsFor(employee);
            EmployeeLogic.GetBioFor(employee);

            EmployeeLogic.DisplayEmployee(employee);
          
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

   






    }
}
