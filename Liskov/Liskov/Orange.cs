using System;
namespace Liskov
{
    public class Orange:Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }

        public override int GetHeight()
        {
            return 12;
        }

        public override string GetName()
        {
            return "Orange";
        }

        public override int GetWidth()
        {
            return 17;
        }
    }
}
