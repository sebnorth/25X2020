using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenUneven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int.TryParse(Console.ReadLine(), out int number);

            if (number % 2 == 0)
            
                Console.WriteLine("The number {0} is even.", number);
            
            else
            

                Console.WriteLine("The number {0} is odd.", number);
            

            Console.ReadKey();
        }
    }
}
