using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProgramsPractice
{
    internal class CubeNo
    {
        // Write a C# Sharp program to display the cube of an integer up to given number.
        static void Main()
        {
            int i , j ;
            int x;
            int num = 0;
            Console.WriteLine("Input the numbers that you want to find the cube");
            int n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <=n; i++)
            {
     
               
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
            }
            



        }
    }
}
