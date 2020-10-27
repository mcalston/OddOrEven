using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = IsOdd(6);
           Console.WriteLine(IsOdd(6));
        }

        public static bool IsOdd(int num)
        {
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());


            if (num % 2 == 0) 
            {

                Console.WriteLine("Your number is odd");

                return true;
            }
            else

            {

                Console.WriteLine("Your number is even");
                return false;
            }

        }
    }
}
