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
            Console.WriteLine("Enter the number of times to flip the coin:");
            int numFlips = Convert.ToInt32(Console.ReadLine());

            if (numFlips > 0)
            {
                int headsCount = 0;
                int tailsCount = 0;
                Random random = new Random();

                for (int i = 0; i < numFlips; i++)
                {
                    if (random.NextDouble() < 0.5)
                        tailsCount++;
                    else
                        headsCount++;
                }

                double headsPercentage = (double)headsCount / numFlips * 100;
                double tailsPercentage = (double)tailsCount / numFlips * 100;

                Console.WriteLine("Heads: " + headsPercentage.ToString("0.00") + "%");
                Console.WriteLine("Tails: " + tailsPercentage.ToString("0.00") + "%");
            }
            else
            {
                Console.WriteLine("Number of flips should be a positive integer.");
            }
        }
    }
}
