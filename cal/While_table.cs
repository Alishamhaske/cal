using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class While_table
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number is:=" + n);
            while(i<=10)
            {
                Console.WriteLine($"{n}*{i} = "+ n * i);
                i++;

            }
        }
    }
}
