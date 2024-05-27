namespace NishantMarksheet
{

    class Marksheet
    {
        static void Main()
        {
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Roll Number: ");
            string roll = Console.ReadLine();
            Console.Write("Enter your Class : ");
            string standard = Console.ReadLine();
            Console.Write("Enter your C# Programming Language Marks: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter your Java Programming Language Marks: ");
            int j = int.Parse(Console.ReadLine());
                Console.Write("Enter your python Programming Language Marks: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter your JavaScript Programming Language Marks: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write   ("Enter your SQL DataBase Marks: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine();


            int obt = c + j + p + n + s;
            int percentage = obt * 100 / 500;

            Console.WriteLine("------------------------------------------------------ MARKSHEET --------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your Roll No is: {0}", roll);
            Console.WriteLine("Your Class is: {0}", standard);
            Console.WriteLine("Your Marks are : {0}", obt);
            Console.WriteLine("Your Percentage is: {0}", percentage + "%");
            Console.WriteLine();

            if (percentage >= 80 )
            {
                Console.WriteLine("Grade: A-1");
                Console.WriteLine();
                Console.WriteLine("Remarks : Excellent");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade: B-1");
                Console.WriteLine();
                Console.WriteLine("Remarks : Good");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: C-1");
                Console.WriteLine();
                Console.WriteLine("Remarks : Average");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: D-1");
                Console.WriteLine();
                Console.WriteLine("Remarks : Fair Do better next time! ");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Re-Attempt Your Exam");
                Console.WriteLine();
                Console.WriteLine("Remarks : Needs lots of Improvement");
            }
            else if (percentage <= 33)
            {
                Console.WriteLine("FAil");
                Console.WriteLine();
                Console.WriteLine("Remarks : Bring your parents tommorow");
            }


            //  int obt = c + j + p + n + s;

            if ( c < 33)
            {
                Console.WriteLine();
                Console.WriteLine("You Have Back Paper in C# Programming Language");
            }
            if (j < 33)
            {
                Console.WriteLine("You Have Back Paper in Java Programming Language");
            }
            if (p < 33)
            {
                Console.WriteLine("You Have Back Paper in Python Programming Language");
            }
            if (n < 33)
            {
                Console.WriteLine("You Have Back Paper in JavaScript Programming Language");
            }
            if (s < 33)
            {
                Console.WriteLine("You Have Back Paper in SQL DataBase Programming Language");
            }













            Console.ReadLine();


        }


    }



}
