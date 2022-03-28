using System;
namespace DependencyInversion
{
    public interface ISalaryCalculator
    {
        float CalculateSalaryEmployee(int hoursWorked, float hourlyRate);
    }
}
