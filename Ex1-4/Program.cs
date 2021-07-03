using System;

namespace Ex1_4
{
    class Program
    {
        //Написать программу обмена значениями двух переменных:
        //а) с использованием третьей переменной;
        //б)*без использования третьей переменной.

        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("введите значение a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите значение b");
            b = int.Parse(Console.ReadLine());
      /*а*/ c = a;
            a = b;
            b = c;
            Console.WriteLine($"значение a теперь {a}, значение b теперь {b}");
      /*б*/ a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"значение a теперь {a}, значение b теперь {b}");

        }
    }
}
