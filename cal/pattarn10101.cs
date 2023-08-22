using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class pattarn10101
    {
        static void Main(string[] args)
        {
            //  10101
            //  01010
            //  10101
            //  01010

            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(i==j || i%2!=0 && j%2!=0 ||(i==4 && j==2) || (i==2 && j==4) )
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    
                }
                Console.WriteLine();
            }


        }
    }
}
