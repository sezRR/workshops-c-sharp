using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ref keyword and Out keyword are conver value types to reference types. 
            // If you want to use Ref keyword you need to set value for, which value data type you prefer, 
            // before the use ref keyword but we do not have this obligation for Out keyword. 
            // If you want to use Out keyword you need to set value for, which value data type you prefer, after use out keyword.

            int number1 = 10;
            int number2 = 20;

            Console.WriteLine("------------DEFAULT------------");

            var result1 = Default(number1, number2);
            Console.WriteLine("Result: " + result1);
            Console.WriteLine("Number 1: " + number1);

            Console.WriteLine("\n------------REF------------");

            var result2 = RefKeyword(ref number1, number2);
            Console.WriteLine("Result: " + result2);
            Console.WriteLine("Number 1: " + number1);

            Console.WriteLine("\n------------OUT------------");

            int numberout1;
            int numberout2 = 20;

            var result3 = OutKeyword(out numberout1, numberout2);
            Console.WriteLine("Result: " + result2);
            Console.WriteLine("Number 1: " + numberout1);
        }

        static int Default(int number1, int number2)
        {
            number1 = 30;

            return number1 + number2;
        }

        static int RefKeyword(ref int number1, int number2)
        {
            number1 = 30;

            // If you want to do not set a value for number 1, your program can continue debugging/working perfectly.

            return number1 + number2;
        }

        static int OutKeyword(out int numberout1, int numberout2)
        {
            numberout1 = 30;

            // If you will not set the value of numberout1 you are going to take a exception

            return numberout1 + numberout2;
        }
    }
}
