using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class DigitSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            while(n!=0)
            {
                int rem = n % 10;
                sum = sum + rem;
                n = n / 10;

            }
            Console.WriteLine("sum " + sum);
        }
    }
}
