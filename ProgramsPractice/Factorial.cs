using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractice
{
    internal class Factorial
    {
        static void Main()
        {
            int i, fact = 1;

            Console.WriteLine("Enter Number for Factorial");
            int num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <=num; i++) {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of {0} is {1}" ,num , fact);

        }
    }
}
