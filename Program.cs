using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 12; number++)
            {
                int sum = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        sum++;
                    }
                }
                if (sum == 2)
                {
                    Console.WriteLine(number);
                }

            }
            Console.ReadLine();
        }
    }
}
