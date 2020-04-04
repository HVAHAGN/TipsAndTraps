using NumbersAndDate_02.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndDate_02
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee = new Employee();
            employee.FirstName = EmployeeLogic.GetFirstName();
            employee.DateOfBirth = EmployeeLogic.GetDateOfBirth();
            employee.ProductivityRating = EmployeeLogic.GetProductivity();
            employee.Salary = EmployeeLogic.GetSalary();
            employee.Id = EmployeeLogic.GenerateRandomId();
            employee.WorkDays = EmployeeLogic.GenerateDefaultWorkDays();

            EmployeeLogic.DisplayEmployee(employee);

            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
