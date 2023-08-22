using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class pyramid5_45_345
    {
        static void Main(string[] args)
        {
            //5
            //45
            //345
            //2345
            //12345
            for(int i=5;i>=1;i--)
            {
                for(int j=i;j<=5;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }   
    }
}
