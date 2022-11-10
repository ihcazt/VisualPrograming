using System;

namespace P02_Calculator
{
    /// <summary>
    /// Calculates a simple arithmetic expression.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main function.
        /// </summary>
        public static void Main()
        {
            Console.Write("Enter a simple integer expression > ");
            string exp = Console.ReadLine();
            int result = Calc(exp);
            Console.WriteLine($"{exp} = {result}");
        }

        /// <summary>
        /// Calculates a given simple exp.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        private static int Calc(string exp)
        {
            // split the expression
            string[] splitExp = exp.Split(' ');
            int leftOperand = int.Parse(splitExp[0]);
            string op = splitExp[1];
            int rightOperand = int.Parse(splitExp[2]);
            
            // calculate the result
            int result;
            switch(op)
            {
                case "+":
                    result = leftOperand + rightOperand;
                    break;
                case "-":
                    result = leftOperand - rightOperand;
                    break;
                case "*":
                    result = leftOperand * rightOperand;
                    break;
                case "/":
                    result = leftOperand / rightOperand;
                    break;
                default:
                    throw new ArgumentException($"Unknown operator {op}.");
            }

            return result;
        }
    }

    // Exercises
    // Write a program that computes the GCD of two positive integers.
    // Write a program that checks iteratively if a positive integer >= 2 is prime.
}
