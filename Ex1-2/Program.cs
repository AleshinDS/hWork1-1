using System;

namespace Ex1_2
{
    class Program
    {
        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
        //I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес в килограммах");
            double weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах");
            double height = Double.Parse(Console.ReadLine());
            Double IMT = weight / (height * height);
            Console.WriteLine($"Индекс массы тела равен {IMT}");

        }
    }
}
