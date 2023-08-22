using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class ifelse_day
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter your day");
            int n = Convert.ToInt32(Console.ReadLine());


            if (n == 0)
            {
                Console.WriteLine("Sunaday");

            }
            else if (n == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (n == 2)
            {
                Console.WriteLine("Thuesday");
            }
            else if (n == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (n == 4)
            {
                Console.WriteLine("Thuraday");
            }
            else if (n == 5)
            {
                Console.WriteLine("friday");
            }
            else if (n == 6)
            {
                Console.WriteLine("saturday");
            }
            else
            {
                Console.WriteLine("holiday");
            }



        }
    }
}
