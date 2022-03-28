using System;
namespace OpenClose
{
    public class DollarCurs: Curs
    {
        public override double GetCursPurchase(double curs)
        {
            return base.GetCursPurchase(curs);
        }
        public override double GetCursSale(double curs)
        {
            return base.GetCursSale(curs) + 0.5;
        }

    }
}
