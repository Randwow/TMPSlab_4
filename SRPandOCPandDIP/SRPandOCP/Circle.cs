using System;
namespace SRPandOCPandDIP
{
    public class Circle:Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) {
            Radius = radius;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }

        public override double Perimetr()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
