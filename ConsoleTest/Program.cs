using MathLibrary;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Test Application");
            Console.WriteLine("Please type number and press Enter");
            string value = Console.ReadLine();
            int number = 0;
            if (int.TryParse(value, out number))
            {
                Nodes s = new Nodes();
                s = s.Factorial(number);
                Console.WriteLine(s.GetValue());
            }
            else
            {
                Console.WriteLine("Invalid integer number");
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
