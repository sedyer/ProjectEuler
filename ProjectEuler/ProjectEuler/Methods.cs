using System;

namespace ProjectEuler
{
    public class Methods
    {
        public static int SumOfFactorsFinder(int factor1, int factor2, int stopValue)
        {
            int sum = 0;

            for (int i = 1; i < stopValue; i++)
            {
                if (i % factor1 == 0 || i % factor2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int SumOfEvenFibonacciTerms(int endValue)
        {
            int sum = 2;

            int first = 1;

            int second = 2;

            while (first + second <= endValue)
            {
                int fibSum = first + second;

                if (fibSum % 2 == 0)
                {
                    sum += fibSum;
                }

                first = second;

                second = fibSum;
            }

            return sum;
        }

        public static long LargestFactor(long value)
        {
            for (long i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return value / i;
                }
            }

            return -1;
        }

        public static bool IsPrime(long value)
        {
            for (long i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static long LargestPrimeFactor(long value)
        {
            for (long i = 2; i < value; i++)
            {
                if (value % i == 0 && IsPrime(value / i))
                {
                    return value / i;
                }
            }

            return -1;
        }

        public static bool IsPalindrome(int value)
        {
            return value == ValueReverser(value);
        }

        public static int LargestPalindromeProduct()
        {
            int maxProduct = -1;

            for (int i = 999; i > 99; i--)
            {
                for (int j = i; j > 99; j--)
                {
                    int product = i * j;

                    if (IsPalindrome(product) && (product > maxProduct))
                    {
                        maxProduct = product;
                    }
                }
            }

            return maxProduct;
        }


        public static int ValueReverser(int value)
        {
            int val = value;

            string backwards = "";

            while (val > 0)
            {
                backwards = backwards + (val % 10).ToString();
                val = val / 10;
            }

            return Convert.ToInt32(backwards);
        }

        public static int SmallestNumberDivisibleByAllUpTo(int value)
        {
            int num = value;

            while (true)
            {
                for (int i = value; i > 1; i--)
                {
                    if (num % i != 0)
                    {
                        break;
                    }

                    if (i == 2) return num;
                }

                num += value;
            }
        }
    }
}
