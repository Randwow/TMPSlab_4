using System;
namespace SingleResponsible
{
    public class EmployeeReport
    {
        public void report(Employee employee) {

            switch (employee.grade) {
                case 10:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 9:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 8:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 7:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 6:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 5:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 4:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 3:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 2:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                case 1:
                    Console.WriteLine("Работник отлично работает ");
                    break;
                default:
                    Console.WriteLine("Работник вообще есть в базе ");
                    break;
            }
            
        }
    }
}
