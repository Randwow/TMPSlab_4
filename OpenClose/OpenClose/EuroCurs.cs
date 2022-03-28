using System;
namespace OpenClose.Properties
{
    public class EuroCurs : Curs
    {
        public override double GetCursPurchase(double curs)
        {
            return base.GetCursPurchase(curs);
        }
        public override double GetCursSale(double curs)
        {
            return base.GetCursSale(curs) + 1;
        }
    }
}