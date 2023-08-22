using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class positive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (n < 0)
            {
                Console.WriteLine("number is negative");

            }
            else
            {
                Console.WriteLine("number is zero");
            }
        }
    }
}
