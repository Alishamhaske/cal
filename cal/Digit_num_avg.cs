using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Digit_num_avg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int count = 0;
            Double avg = 0;
            while(n!=0)
            {
                int rem = n % 10;
                count++;
                sum = sum + rem;
                n = n / 10;

            }
            avg = sum / count;
            Console.WriteLine("sum of digit: " + sum);
            Console.WriteLine("number of digit: " + count);
            Console.WriteLine("avgrage of digit " + avg);


        }
    }
}
