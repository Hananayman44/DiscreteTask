using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum, i;
            for (number = 29; number <= 9000; number++)
            {
                i = 1;
                sum = 0;
                while (i < number)
                {
                    if (number % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == number)
                {
                    Console.WriteLine("perfect number is " + number);
                }
            }
            Console.ReadLine();
        }
    }
}
     




                   
                        
                       
              
   
               
               
     













