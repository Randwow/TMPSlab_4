using System;
namespace Liskov
{
    public class Apple:Fruit
    {
        public override string GetName()
        {
            return "Apple";
        }
        public override string GetColor()
        {
            return "Green";
        }

        public override int GetHeight()
        {
            return 10;
        }

        public override int GetWidth()
        {
            return 15;
        }
    }
}
