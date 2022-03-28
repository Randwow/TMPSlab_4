using System;

namespace InterfaceSegregation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();
            Ship ship = new Ship();
            ship.sail();
            Plane plane = new Plane();
            plane.Move();
            plane.fly();
        }
    }
}
