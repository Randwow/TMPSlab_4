using System;

namespace DependencyInversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            //Создание обьекта у которого будет высчитываться его зарплата
            //Создавая обьект мы зависим только от абстракции а не от конкретного класса CalculateSalsry
            //Детали реализации CalculateSalary также скрыты от EmolyeeDetails
            var employeeDetails = new EmployeeDetails(new CalculateSalary());
            employeeDetails.HourlyRate = 50;
            employeeDetails.HoursWorked = 150;
            Console.WriteLine($"The Total Pay is {employeeDetails.GetSalary()}");
        }
    }
}
