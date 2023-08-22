using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class pyara4321_321
    {
        static void Main(string[] args)
        {
            //4321
            // 321
            //  21
            //   1
            for(int i=4;i>=1;i--)
            {
                for(int k=3;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
