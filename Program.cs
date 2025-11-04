using System;
using _4._11;
using _4._11._4._11;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            _4._11._4._11.Calculator calc = new Calculator();

           
            calc.InitializeOperations();
            calc.ShowMessage("Это тестовое сообщение");

            
            int sum = calc.doble(5, 7);
            Console.WriteLine($"Сумма: {sum}");

            double product = calc.Division(3.5, 2.0);
            Console.WriteLine($"Деление: {product}");

            string greeting = calc.GetGreeting("Андрей");
            Console.WriteLine(greeting);
        }
    }
}