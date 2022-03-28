using System;

namespace Liskov
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Fruit fruit = new Apple();
            Console.WriteLine("Название фрукта: {0}, его цвет {1}, его высота {2}, его ширина {3}",
                 fruit.GetName(), fruit.GetColor(), fruit.GetWidth(), fruit.GetHeight());
            fruit = new Orange();
            Console.WriteLine("Название фрукта: {0}, его цвет {1}, его высота {2}, его ширина {3}",
                fruit.GetName(), fruit.GetColor(), fruit.GetWidth(), fruit.GetHeight());
        }
    }
}
