using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class count_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while(n!=0)
            {
                int rem = n % 10;
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
        }
    }
}
