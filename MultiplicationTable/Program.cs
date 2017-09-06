using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //First write column numbers tabbed across the top of the console with the tab char 't'
            Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9");

            //loop through 9 since that is how big our table is.
            for (int i = 0; i <= 9; i++)
            {
                //Now write out our row number
                Console.Write(i);

                //Second loop for multiplication
                for (int j = 0; j <= 9; j++)
                {
                    //Write out the tab formatted product to the console. This will create the rows.
                    Console.Write("\t{0}", i * j);
                }
                //Once finished with the row, skip to the next line.
                Console.WriteLine();
            }
        }
    }
}
