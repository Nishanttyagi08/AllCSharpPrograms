namespace OperatorsExpression
{


    class Operators
    {

        static void Main()
        {
            // Arithmetic Operators
            int a = 20; 
            int b = 10 , c , d, e , f , g ;

             c = a + b;
             d  = a - b;
             e = a * b;
             f = a  / b;
             g = a % b;


            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);


            // Relational Operator or Comparison Operator 


            //int x = 10;
            //int y = 10;

            // bool w = x == y;  Check both value are eqaul or not 
            //bool w = x != y;   Check both value are not equal
            //  bool w = x > y;  Greater than 
            //bool w = x < y;  Less than
            //bool w = x >= y; Greater than Equal to 
            //bool w = x <= y;   Less Than Equal to
            // Console.WriteLine(w);



            // Logical And Conditional Operators 

            // AND / OR / NOT


            // Aaaignment Operator
            // int n = 5; // Simple Assignment Operator
            // a += 1; // a = a + 1 --- Compound Assignment Operator work with the all Arithmetic


            // Increment and Decrement Operator

            // Unary Operator

            // ++ :-- Increase the value
            // -- :-- Decrease the value


            // Precedence of Operators 

            // Highest Level :- / , * , + , -


            // Ternary or Conditional Operators
            int k = 20;

            string p = (k > 10) ? "K is Greater " : "P is Greater ";

            Console.WriteLine(p);

            Console.ReadLine(); 
        }


    }
}