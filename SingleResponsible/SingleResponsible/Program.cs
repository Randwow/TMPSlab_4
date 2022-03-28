using System;
using System.Collections.Generic;
using SingleResponsible;

namespace SingleResponsibility
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            EmployeeReport employeeReport = new EmployeeReport();

            employee.Add(new Employee() { ID = 1,
                name = "Nichita",
                surname =  "Macheev",
                age = 21, department = "IT",
                gender = "M",
                grade = 10});
            Console.WriteLine(employee[0].ToString());
            employeeReport.report(employee[0]);
        }
    }
}
