using System;
namespace InterfaceSegregation
{
    public class Car:IMove
    {
        public void Move() {
            Console.WriteLine("Машина может только ехать !\n");
        }
    }
}
