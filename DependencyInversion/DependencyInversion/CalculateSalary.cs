using System;
namespace DependencyInversion
{
    public class CalculateSalary:ISalaryCalculator
    {
        public float CalculateSalaryEmployee(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
    }
}
