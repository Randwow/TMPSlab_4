using System;
namespace SRPandOCPandDIP
{
    public class PerimetrAclculator
    {
        public double TotalPerimetr(Shape[] arrShapes)
        {
            double perimetr = 0;
            foreach (var objShape in arrShapes)
            {
                perimetr += objShape.Perimetr();
            }
            return perimetr;
        }
    }
}
