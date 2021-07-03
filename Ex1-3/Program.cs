using System;

namespace Ex1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
            //            y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
            //            используя спецификатор формата .2f(с двумя знаками после запятой);

            double x1, y1, x2, y2, r;
            Console.WriteLine("Введите координату x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            y2 = double.Parse(Console.ReadLine());
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);


        }
    }
}
