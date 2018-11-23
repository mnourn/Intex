using MathLibrary;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Test Application");
            Console.WriteLine("To exit application please type 'x' and press Enter or type number and press Enter");
            string value = Console.ReadLine();
            while (value != "x")
            {
                UInt32 number = 0;
                if (UInt32.TryParse(value, out number))
                {
                    Nodes s = new Nodes();
                    s = s.Factorial(number);
                    Console.WriteLine(s.GetValue());
                }
                else
                {
                    Console.WriteLine("Invalid integer number");
                }
                value = Console.ReadLine();
            }
        }
    }
}
