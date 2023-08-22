using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class prime1_10
    {
        static void Main(string[] args)
        {
           
            for(int n=1;n<=10;n++)
            {
                bool isprime = true;
                for (int i=2;i<n;i++)
                {
                    if (n % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                 

                }
                if(isprime==true)
                {
                    Console.WriteLine(n);
                }
              


            }
        }
    }
}
