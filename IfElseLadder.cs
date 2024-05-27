namespace IfElseLadder
{
    class IfElse
    {

        static void Main()
        {

            Console.WriteLine("Enter your Percentage");
            double percentage = Convert.ToDouble(Console.ReadLine());

            if (percentage >= 95)
            {
                Console.WriteLine("I Phone");

            }

            else if (percentage >= 90)

            {
                Console.WriteLine("Samsung");
            }
            else if (percentage >= 80)

            {
                Console.WriteLine("Realme");
            }
            else if (percentage >= 70)

            {
                Console.WriteLine("Nokia");
            }
            else if (percentage >= 60)

            {
                Console.WriteLine(" For Dinner");
            }
            else if (percentage <= 50)

            {
                Console.WriteLine("Mehnat Karo");

            }



            Console.ReadLine();
        }

    }

}