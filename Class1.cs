using System.Security.Cryptography.X509Certificates;

namespace _4._11
{
    using System;

    namespace _4._11
    {
        public class Calculator
        {
            public void InitializeOperations()
            {
                Console.WriteLine(3+4);
            }
            public void ShowMessage(string message)
            {
                Console.WriteLine($"Сообщение: {message}");
            }


            public int doble(int a, int b)
            {
                return a + b;
            }
            public double Division(double x, double y)
            {
                return x / y;
            }
            public string GetGreeting(string name)
            {
                return $"Здравствуйте, {name}!";
            }
        }
    }
}
