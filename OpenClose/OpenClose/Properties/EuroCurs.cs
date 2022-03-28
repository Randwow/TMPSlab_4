using System;
namespace OpenClose.Properties
{
    public class EuroCurs:Curs
    {
        public override float GetCursPurchase(float curs)
        {
            return base.GetCursPurchase(curs);
        }
        public override float GetCursSale(float curs)
        {
            return base.GetCursSale(curs) + 1;
        }
    }
}
