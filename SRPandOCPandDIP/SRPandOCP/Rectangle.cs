using System;
namespace SRPandOCPandDIP
{
    public class Rectangle:Shape
    {
        public double Height { get; set; }
        public double Wight { get; set; }
        public Rectangle(double height, double wight) {
            Height = height;
            Wight = wight;
        }
        public override double Area()
        {
            return Height * Wight;
        }
        public override double Perimetr()
        {
            return 2 * (Height + Wight);
        }
    }
}
