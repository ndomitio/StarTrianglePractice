using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTrianglePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //as rows and stars increase by 1 and = (rows*2) +1, ending at 5.  The spaces
            //need to decrease by 1 starting at 3 and ending at 0.
            for (int row = 0; row < 6; row++)
            {
                for (int j = 0; j < (5-row); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k<(row*2-1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}




