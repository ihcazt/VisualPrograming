using System;

namespace P03_Recurrence
{
    /// <summary>
    /// Calculates factorial iteratively and recursively.
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter non-negative integer > ");
            int n = int.Parse(Console.ReadLine());
            int result = IterativeFactorial(n);
            Console.WriteLine($"[{nameof(IterativeFactorial)}] {n}! = {result}");
            result = RecursiveFactorial(n);
            Console.WriteLine($"[{nameof(RecursiveFactorial)}] {n}! = {result}");
        }

        /// <summary>
        /// Iteratively computes factorial of a given non-negative integer value.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int IterativeFactorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; ++i)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Recursively computes factorial of a given non-negative integer value.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int RecursiveFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * RecursiveFactorial(n - 1);
        }
    }

    // Exercises
    // Write a program that computes recursively the GCD of two positive integers.
}
