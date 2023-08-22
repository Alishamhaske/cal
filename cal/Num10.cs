using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Num10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=n;i++)
            {
                if(i%10==0)
                {
                    Console.WriteLine(i + 10);
                }
               
            }
        }
    }
}
