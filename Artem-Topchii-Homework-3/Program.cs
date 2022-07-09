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
            int i = Math.Abs(a);

            if (a < -1 || a > 1)
            {
                for (i--; a % i != 0; i--);
            }

            return i;
        }

        static int SumOfAllNumberThatAreDivisibleBy7(int a, int b)
        {
            if (a > b)
            {
                SwapTwoValues(ref a, ref b);
            }

            int sum = 0;

            for (; a <= b; a++)
            {
                if (a % 7 == 0)
                {
                    sum += a;
                }
            }

            return sum;
        }

        static int FindFibonacciNumber(int n)
        {
            int FibonacciNumber = 0;
            int x1 = 0;
            int x2 = 1;

            if (n >= 0 && n <= 1)
            {
                FibonacciNumber = n;
            }

            for (int i = 2; i <= n; i++)
            {
                FibonacciNumber = x1 + x2;
                x1 = x2;
                x2 = FibonacciNumber;
            }

            return FibonacciNumber;
        }

        static int FindGreatestCommonDivisor(int a, int b)
        {
            int greatestCommonDivisor = default;
            int absValueOfa = Math.Abs(a);
            int absValueOfb = Math.Abs(b);

            if (absValueOfa < absValueOfb)
            {
                SwapTwoValues(ref absValueOfa, ref absValueOfb);
            }

            if (absValueOfb == 0)
            {
                greatestCommonDivisor = absValueOfa;
            }
            else
            {
                while (absValueOfa % absValueOfb != 0)
                {
                    int remainder = absValueOfa % absValueOfb;
                    absValueOfa = absValueOfb;
                    absValueOfb = remainder;
                }

                greatestCommonDivisor = absValueOfb;
            }

            return greatestCommonDivisor;
        }

        static int FindTheNumberUsingBinarySearchAlgorithm(int a)
        {
            int result = 0;

            for (int i = 0; i <= a; i++)
            {
                if (i * i * i == a)
                {
                    result = i;
                }
            }

            return result;
        }

        static int FindTheNumberOfOddDigitsInThisNumber(int a)
        {
            int result = 0;

            for (int i = 0; i <= a; i++)
            {
                if (i % 2 != 0)
                {
                    result ++;
                }
            }

            return result;
        }

        static int ReverseNumber(int a)
        {
            int reversedNumber = 0;

            while (a > 0)
            {
                reversedNumber = reversedNumber * 10 + a % 10;
                a /= 10;
            }

            return reversedNumber;
        }

        static string CheckRepeatedDigits(int a, int b)
        {
            string checking = "NO";
            char[] arrayA = a.ToString().ToCharArray();
            char[] arrayB = b.ToString().ToCharArray();

            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] == arrayB[j])
                    {
                        checking = "YES"; 
                    }
                }
            }

            return checking;
        }
        
        static (int, int) SwapTwoValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return (a, b);
        }

        static void Main(string[] args)
        {
        //RAISE THE NUMBER A TO THE POWER OF B

            //Console.WriteLine(RaiseTheNumberAtoThePowerOfB(4,5)); 

        //FIND THE NUMBER OF POSITIVE INTEGERS WHOSE SQUARE IS LESS THAN A

            //Console.WriteLine(FindTheNumberOfPositiveIntegersWhoseSquareIsLessThanA(2)); 

        //PRINT THE LARGEST DIVISOR OF THE NUMBER A

            //Console.WriteLine(PrintTheLargestDivisorOfTheNumberA(-1));

        //SUM OF ALL NUMBER THAT ARE DIVISIBLE BY 7

            //Console.WriteLine(SumOfAllNumberThatAreDivisibleBy7(50, 5));

        //FIND FIBONACCI NUMBER

            //Console.WriteLine(FindFibonacciNumber(0));

        //FIND GREATEST COMMON DIVISOR 

            //Console.WriteLine(FindGreatestCommonDivisor(-100,7));

        //FIND THE NUMBER USING BINARY SEARCH ALGORITHM

            //Console.WriteLine(FindTheNumberUsingBinarySearchAlgorithm(64));

        //FIND THE NUMBER OF ODD DIGITS IN THIS NUMBER

            //Console.WriteLine(FindTheNumberOfOddDigitsInThisNumber(3));

        //REVERSE NUMBER

            //Console.WriteLine(ReverseNumber(32616));

        //CHECK REPEATED DIGITS

            //Console.WriteLine(CheckRepeatedDigits(32616,888));
        }
    }
}
