using System;
using OpenClose.Properties;

namespace OpenClose
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Curs euro_curs = new EuroCurs();
            Curs dollar_curs = new DollarCurs();

            double euro_curs_sale = euro_curs.GetCursSale(20.50);
            double euro_curs_buy = euro_curs.GetCursPurchase(20.50);
            Console.WriteLine("Курс Евро на сегодня: Покупка: " + euro_curs_buy +
                " Продажа: " + euro_curs_sale + "\n");

            double dollar_curs_sale = dollar_curs.GetCursSale(18.50);
            double dollar_curs_buy = dollar_curs.GetCursPurchase(18.50);
            Console.WriteLine("Курс Доллара на сегодня: Покупка: " + dollar_curs_buy +
            " Продажа: " + dollar_curs_sale + "\n");

        }
    }
}
