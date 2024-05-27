using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractice
{
    internal class reversedNumber
    {

        static void Main()
        {
          
            Console.WriteLine("Enter the number : ");
            string num = Convert.ToString(Console.ReadLine());
            string reversed = "";

            foreach(char digit in num)
            {

                reversed = digit + reversed;
            }

            // Convert the reversed string back to an integer
            int reversedNumber = int.Parse(reversed);

            Console.WriteLine(reversedNumber);
        }


    }

}
