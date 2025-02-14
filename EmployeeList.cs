using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    class EmployeeList
    {
        List<Employee> empList = new List<Employee>()
        {
            new Employee { Name = "Disha", Salary = 75000},
            new Employee { Name = "Riya", Salary = 25000},
            new Employee { Name = "Ritika", Salary = 45000},
            new Employee { Name = "Kittu", Salary = 50000},
            new Employee { Name = "Swarali", Salary = 60000},
        };

        public void FindSalary()
        {
            var result = empList.Where( emp => emp.Salary > 50000).ToList();
            Console.WriteLine("Employee whose Salary > 50,000 are :");
            result.ForEach( e => Console.WriteLine(e.Name + " : " + e.Salary ));
            Console.WriteLine();
        }
    }
}
