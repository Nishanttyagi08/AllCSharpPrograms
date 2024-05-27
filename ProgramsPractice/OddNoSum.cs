using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractice
{
    internal class OddNoSum
    {

        static void Main ()
        {
            //Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
            int n, i;
            int sum = 0;
            Console.WriteLine("Input the Number of Terms");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe odd numbers are : ");
            for (i = 1; i < n; i++)
            {

                Console.Write("{0} " , 2 * i );

                sum = sum + 2 * i ; // FOR EVEN
                //sum = sum + 2 * i - 1 ; // FOR ODD

            }
            Console.WriteLine("\nThe Sum of odd Natural Numbers up to {0} terms: {1} \n", n, sum);
        }
    }
}
