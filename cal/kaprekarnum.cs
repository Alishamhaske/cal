using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class kaprekarnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count=0;
            int sq = n * n;
            int temp = n;
            while(n>0)
            {
                count++;
                n = n / 10;
            }
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }
            int end = sq % power;
            int start = sq / power;

            int sum = end + start;
           
            
            if(temp==sum)
            {
                Console.WriteLine("kaprekar number: ");
            }
            else
            {
                Console.WriteLine("not kaprekar");
            }

        }
    }
}
