using System;
namespace InterfaceSegregation
{
    public class Plane:IMove,IFlying
    {
        public void Move() {
            Console.WriteLine("Самолет может не много ездить или передвигаться по земле \n");
        }
        public void fly() {
            Console.WriteLine("Самолет может и летать ");
        }
    }
}
