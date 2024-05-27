using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractice
{
    internal class AverageSum
    {
        // Write a C# Sharp program to read 10 numbers and find their average and sum.


        static void Main()
        {
            int i , n , sum =0;
            double avg;
            Console.WriteLine("Input the 10 Numbers");

            for(i = 1; i <=10; i++)
            {
                Console.Write("Numbers {0}: " , i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("The sum of 10 numbers is : {0}\nThe Average is : {1}\n", sum, avg);

        }

    }
}
