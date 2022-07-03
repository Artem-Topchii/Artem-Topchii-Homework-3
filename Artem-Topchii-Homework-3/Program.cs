using System;

namespace Artem_Topchii_Homework_3
{
    class Program
    {
        static int RaiseTheNumberAtoThePowerOfB(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        static void PrintAllNumbersThatAreDivisibleByA(int a)
        {
            for (int i = a; i <= 1000; i += a)
            {
                Console.WriteLine(i);
            }
        }

        static int FindTheNumberOfPositiveIntegersWhoseSquareIsLessThanA (int a)
        {
            int result = default;
            for (int i = 1; i * i < a; i++)
            {
                result++;
            }
            return result;
        }

        static int PrintTheLargestDivisorOfTheNumberA (int a)
        {
            return a / 2;
        }

        static void Main(string[] args)
        {
        //RAISE THE NUMBER A TO THE POWER OF B

            //Console.WriteLine(RaiseTheNumberAtoThePowerOfB(4,5));

        //PRINT ALL NUMBERS THAT ARE DIVISIBLE BY A

            //PrintAllNumbersThatAreDivisibleByA(120); 

        //FIND THE NUMBER OF POSITIVE INTEGERS WHOSE SQUARE IS LESS THAN A

            //Console.WriteLine(FindTheNumberOfPositiveIntegersWhoseSquareIsLessThanA(2)); 

        //PRINT THE LARGEST DIVISOR OF THE NUMBER A

            //Console.WriteLine(PrintTheLargestDivisorOfTheNumberA(10));
        }
    }
}
