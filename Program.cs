using System;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
        }

        private static int findDigits(int n)
        {
            int count = 0;
            var digits = n.ToString();

            foreach (var item in digits)
            {
                int divisor = Convert.ToInt32(item.ToString());

                if (divisor != 0 && n % divisor ==0)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
