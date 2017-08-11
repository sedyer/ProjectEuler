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

        public static long LargestPrimeFactor (long value)
        {
            long result = value;

            for (long i = value - 2; i > 0; i -= 2)
            {
                bool isPrime = true;

                for (int j = 3; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        //not prime

                        isPrime = false;
                    }
                              
                }

                if (isPrime) break;  
            }

            return result;
        }
    }
}
