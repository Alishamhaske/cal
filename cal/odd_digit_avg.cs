using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class odd_digit_avg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int sum = 0;
            int count = 0;
            Double avg = 0;
            while (n != 0)
            {
                rem = n % 10;
                n = n / 10;

                if (rem % 2 != 0)
                {
                    count++;
                    sum = sum + rem;
                    avg = sum / count;
                }
            }
            Console.WriteLine("sum of odd number " + sum);
            Console.WriteLine("number of odd no.  " + count);
            Console.WriteLine("avg of odd number " + avg);
        }

    }
}
