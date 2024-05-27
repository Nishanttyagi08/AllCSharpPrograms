using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractice
{
    internal class RightStar
    {

//Write a program in C# Sharp to display a right angle triangle with an asterisk.
//*
//**
//***
//****



        static void Main()
        {
            int i, j , k = 1;
            Console.WriteLine("Enter the number of stars you want to print");
            int n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i<=n; i++)
            {
                for (j = 1; j<=i; j++)
                {

                    // Console.Write("*");  // For stars from right Side
                   // Console.Write(j); 
                   // Console.Write(i); 
                    Console.Write(k++); 
                }
                Console.WriteLine();

            }
            Console.ReadLine(); 
        }

    }
}
