using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Even_digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            while(n!=0)
            {
                int rem = n % 10;
                n = n / 10;

                if(rem%2==0)
                {
                    Console.WriteLine(rem);
                }
            }
        }
    }
}
