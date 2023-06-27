using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharphProgrammingsDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the power value N:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n < 31)
            {
                for (int i = 0; i <= n; i++)
                {
                    int result = (int)Math.Pow(2, i);
                    Console.WriteLine("2^" + i + " = " + result);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. N should be between 0 and 30.");
            }
        }
    }
}
