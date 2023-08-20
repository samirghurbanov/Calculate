using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: +, -, *, /");
            char operation = Console.ReadLine()[0];

            int result = 0;

            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine("Result - " + result);

            Console.ReadLine();

        }
    }
}
