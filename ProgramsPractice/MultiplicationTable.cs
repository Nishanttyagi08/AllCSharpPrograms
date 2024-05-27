using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractice
{
    internal class Multi_licationTable
    {
        static void Main()
        {
            int n, i;
            Console.WriteLine("Enter the table Name or Number");
            n = Convert.ToInt32(Console.ReadLine());


            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} x {1} = {2} \n", n, i, n * i);
            }
        } 

    }
}
