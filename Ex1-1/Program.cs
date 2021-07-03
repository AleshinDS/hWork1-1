using System;

namespace Ex1_1
{
    //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст,
    //рост, вес). В результате вся информация выводится в одну строчку:
    //а) используя склеивание;
    //б) используя форматированный вывод;
    //в) используя вывод со знаком $.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string sname = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите рост в сантиметрах");
            string height = Console.ReadLine();
            Console.WriteLine("Введите вес в килограммах");
            string weight = Console.ReadLine();

            /*а*/ Console.WriteLine(name + " " + sname + ": " + age + " лет," + " рост - " + height + " см," + " вес - " + weight + " кг");
            /*б*/ Console.WriteLine("{0} {1}: {2} лет, рост - {3} см, вес - {4} кг", name, sname, age, height, weight);
            /*в*/ Console.WriteLine($"{name} {sname}: {age} лет, рост - {height} см, вес - {weight} кг");
        }
    }
}
