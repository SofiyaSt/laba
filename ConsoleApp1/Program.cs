using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char oper;

            Console.WriteLine("Добро пожаловать в ваш ленивый калькулятор!");

            progrr:
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine(a + "*" + b + "=" + total + ".");
                Console.WriteLine("Умножение завершено.");
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine(a + "/" + b + "=" + total + ".");
                Console.WriteLine("Деление завершено");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }

            Console.WriteLine("\nЖелаете продолжить? Введите YES/NO");
            string rep = Console.ReadLine();
            if (rep == "YES") goto progrr;
            if (rep == "NO") return;
        }
    }
}
