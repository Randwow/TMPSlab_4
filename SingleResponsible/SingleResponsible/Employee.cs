using System;
namespace SingleResponsible
{
    public class Employee
    {

        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string department { get; set; }
        public int grade { get; set; }

        public override string ToString()
        {
            return "ID сотрудника " + ID + "\n" +
                   "Имя сотрудника " + name + "\n" +
                   "Фамилия сотрудника " + surname + "\n" +
                   "Возраст сотрудинка " + age + "\n" +
                   "Пол сотрудника " + gender + "\n" +
                   "Департамент в котором сотрудник работает " + department +
                   "\n";
        }

    }
}
