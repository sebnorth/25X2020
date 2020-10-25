using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number, please: ");
            int.TryParse(Console.ReadLine(), out int a);

            if (a > 0) Console.WriteLine("The number {0} is positive", a);

            else
            {

                if (a < 0) Console.WriteLine("The number {0} is negative", a);

                else Console.WriteLine("You entered zero.");

            }

        }
    }
}
