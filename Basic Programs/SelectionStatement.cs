namespace SelectionStatement
{
    class Statements
    {

        static void Main()
        {
            Console.WriteLine("Enter Your Username: ");
            string x = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string y = Console.ReadLine();

            if (x == "Nishant" && y == "Nishant123")
            {

                Console.WriteLine("Login Successfull...");
               
            }

            else
            {
                Console.WriteLine("Incorrect Credientials... ");
            }
             Console.ReadLine();

        }
    }

}