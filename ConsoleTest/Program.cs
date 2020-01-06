using MathLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Test Application");
            Console.WriteLine("To exit application please type 'x' and press Enter or type number and press Enter");
            string value = Console.ReadLine();
            Factorial s = new Factorial();
            while (value != "x")
            {
                int number = 0;
                if (int.TryParse(value, out number) && number > 0)
                {
                    List<byte> result = s.GetFactorial(number);
                    result.Reverse();
                    Console.WriteLine(string.Join("", result));
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
