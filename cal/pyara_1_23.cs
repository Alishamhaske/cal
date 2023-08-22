using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class pyara_1_23
    {
        static void Main(string[] args)
        {
            //1
            //23
            //456
            //78910
            int n = 1;
            for (int i= 1; i <= 4; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }
    }
}
