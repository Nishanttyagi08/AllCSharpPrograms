namespace nestedif
{

    class NestedIfElse
    {

        static void Main ()
        {

            Console.WriteLine("Enter your Email: ");
            string email = Console.ReadLine ();

            if (email =="nishanttyagi@gmail.com")
            {

                Console.WriteLine("Enter your password");
                string Pass = Console.ReadLine ();

                if (Pass == "Nishant1122")
                {
                    Console.WriteLine("Login Sucessfully");
                }
                else
                {
                    Console.WriteLine( "Password Incorrect");
                }
            }

            else
            {

                Console.WriteLine("Email Incorrect");
            }
            Console.ReadLine();

        }


    }
}