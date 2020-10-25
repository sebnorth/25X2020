using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number_1, number_2;
                Console.WriteLine("Please enter the first number");
                number_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the second number");
                number_2 = Convert.ToInt32(Console.ReadLine());

                int result = number_1 / number_2;

                Console.WriteLine("The quotient of given numbers is: " + result);
            }

            catch (DivideByZeroException myhandle)
            {

                Console.WriteLine(myhandle.Message);
            }


            catch (Exception myhandle)
            {

                // throw;
                Console.WriteLine(myhandle.Message);
            }



            finally
            {
                Console.WriteLine("The program move on...");

                double divisor, quotient;
                try
                {
                    divisor = Convert.ToDouble(Console.ReadLine());
                    if (divisor == 0)
                        throw new DivideByZeroException("The divisor must not be zero!!!");
                    quotient = 10.2 / divisor; Console.WriteLine(quotient);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Exception message of our own: {0}", ex.Message);

                }
            }

                // Console.WriteLine(10/0);

                Console.ReadKey();


        }
    }
}
