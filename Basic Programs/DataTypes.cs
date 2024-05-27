// Built in Data Type
// Integers - Signed Integers (Takes only negative and positive values)
// Unsigned Integers ( Takes only positive values ) Like Age cannot be Negative
// Example - SBYTE , BYTE , SHORT , USHORT , INT , UNIT , LONG , ULONG --- 
// Starting with the S is  (Signed Integer ) and U -- Unsigned Integers
// Float -- Limit:- 7 Digits (Size- 4 Bytes) , Double -- Limit:- 15-16 digits (Size- 8 Bytes)  , Decimal -- Limit:-28-29 Digits  (Size- 16 Bytes)

namespace Datatype
{
    class RangeDataType
    {

        static void Main()
        {
            //  Console.WriteLine(int.MinValue);
            //  Console.WriteLine(int.MaxValue); 

            // Console.ReadLine();

            float a = 345.4444444444444f;
            double b = 6544545.4444444444444444444d;
            decimal c = 54545454.44444444444444444444444m;

            Console.WriteLine(a);      
            Console.WriteLine(b);      
            Console.WriteLine(c);      
        }
    }



}