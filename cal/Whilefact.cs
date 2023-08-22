using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Whilefact
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int i = 1;

            while(i<=n)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("factorial is " + fact);
        }
    }
}
