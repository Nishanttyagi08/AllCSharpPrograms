namespace calculator
{

    class nishantCalculator
    {

        static void Main()
        {
            double num1, num2;

            Console.WriteLine("Enter the first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double Difference = num1 - num2;
            double multiply = num1 * num2;
            double divide = num1 / num2;



            Console.WriteLine("Here is the sum " + sum);
            Console.WriteLine("Here is the  difference " + Difference);
            Console.WriteLine("Here is the multiply " + multiply);
            Console.WriteLine("Here is the divide " + divide);

        }
       
    }
}