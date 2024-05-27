using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a C# Sharp program to find the sum of the first 10 natural numbers.
//Expected Output :
//The first 10 natural number is :
//1 2 3 4 5 6 7 8 9 10
//The Sum is : 55

namespace ProgramsPractice
{
    internal class sumNaturalNo
    {
        

        static void Main()
        {
            int sum = 0 , i;

            Console.WriteLine("Enter any number to print the sum");
            int x = Convert.ToInt32(Console.ReadLine());    

            for (i = 1; i <= x; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of " +  x + " number from 1 to " + x + " : " + sum);
            Console.ReadLine();
        }
       

    }
}
