

namespace switchCalculator
{
    class NishantCalculator
    {

        static void Main(String[] args)
        {
            char choice = 'y';
            do
            {
                double num1, num2;
                
                char result;

                Console.Write("Enter your First Number : ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Your Second Number : ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter any operations (+, -, *, / ) : ");
                result = Convert.ToChar(Console.ReadLine());


                double sum;
                switch (result)
                {

                    case '+':
                        sum = num1 + num2;
                        Console.WriteLine("Addition of {0} and {1} : {2}" , num1 , num2 , sum);
                        break;
                    case '-':
                        sum = num1 - num2;
                        Console.WriteLine("Subtraction of {0} and {1} : {2} ", num1, num2, sum);
                        break;
                    case '*':
                        sum = num1 * num2;
                        Console.WriteLine("Multiplicaiton of {0} and {1} : {2} :", num1, num2, sum);
                        break;
                    case '/':

                        if (num2 == 0)
                        {
                            Console.WriteLine("Error : Division by Zero");

                        }

                        else
                        {
                            sum = num1 / num2;
                            Console.WriteLine("Division of {0} and {1} : {2} ", num1, num2, sum);

                        }
                        break;


                    default:
                        Console.WriteLine("Invalid Operator");
                        break;


                }

                Console.WriteLine("Do you want to wish to perform another operation? (Y/N): ");
                choice = Convert.ToChar(Console.ReadLine().ToLower());



            }

            while  ( choice == 'y');


                Console.WriteLine("Thankyou for using the Calculator having great day :) ");

            Console.ReadLine();            
        } 
        
     
    }
}