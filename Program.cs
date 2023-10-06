using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                Console.Write("Enter the least number: ");                  //امیرمحمد طاهری
                int start = Convert.ToInt32(Console.ReadLine());       //برنامه سازی پیشرقته 2 استاد حافظی

                Console.Write("Enter the Last number: ");
                int end = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The Prime numbers from {start} to {end} are:");

                for (int number = start; number <= end; number++)
                {
                    bool isPrime = IsPrime(number);

                    if (isPrime)
                        Console.WriteLine(number);
                }

                Console.ReadLine();
            }

            static bool IsPrime(int number)
            {
                if (number < 2)
                    return false;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }

                return true;
            }
        }
    }
