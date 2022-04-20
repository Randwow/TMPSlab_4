using System;

namespace SRPandOCPandDIP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Принцип разделения единой ответственности один класс считает только 1 составляющую
            //Принцип открытости закрытости не нужно менять логику уже существующих методов достаточно добавить
            //в абстрактный класс абстрактный метод и далее унаследовать его
            //Принцип инверсии зависимости классы зависят от абстракции (Method Injection)
            //классы высокого уровня не зависят от низкого
            //детали зависят от абстракции но абстракция не зависит от деталей 
            Shape[] shapes = { new Rectangle(10, 20), new Circle(19)};
            AreaCalculator areaCalculator = new AreaCalculator();

            double total = areaCalculator.TotalArea(shapes);

            Console.WriteLine("Общая площадь всех фигур " + total);

            PerimetrAclculator perimetrAclculator = new PerimetrAclculator();

            double perimetr = perimetrAclculator.TotalPerimetr(shapes);

            Console.WriteLine("Общий периметр всех фигур " + perimetr);
        }
    }
}
