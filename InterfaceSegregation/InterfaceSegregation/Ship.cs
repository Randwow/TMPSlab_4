using System;
namespace InterfaceSegregation
{
    public class Ship:ISailing
    {
        public void sail() {
            Console.WriteLine("Корабль может только плыть \n");
        }
    }
}
