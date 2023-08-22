using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class pattern101010
    {
        static void Main(string[] args)
        {
            //  10101
            //  01010
            //  10101
            //  01010
            //  10101
            int n = 0;
           for(int i=0;i<=4;i++)
            {
                for(int j=0;j<=4;j++)
                {
                    n++;
                    if(n%2==0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
