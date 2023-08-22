using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class krishanmurti_num
    {
        static void Main(string[] args)
        {
            //1! + 4! + 5!
            //1+  24+ 120 ==145

            
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int temp = n;
          
            int sum = 0;
            while(n!=0)
            {
                rem = n % 10;
                int fact = 1;
                for (int i=1;i<=rem;i++)
                {
                    fact = fact * i;
               
                }
                sum = sum + fact;
                n = n / 10; 
            }
            if(temp==sum)
            {
                Console.WriteLine("krushanmurti number:");
            }
            else
            {
                Console.WriteLine("not krushanmurti number:");
            }
        }
    }
}
