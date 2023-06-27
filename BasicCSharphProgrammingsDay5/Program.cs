using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharphProgrammingsDay5
{
    internal class HarmonicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its prime factors:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime factors of " + number + ":");
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }

            if (number > 1)
                Console.WriteLine(number);
        }
        }
    }

