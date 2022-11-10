using System;
using System.Collections.Generic;

namespace P04_PrefixCalculator
{
    /// <summary>
    /// Calculates postfix expression.
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter postfix expression of doubles > ");
            var prefixExp = Console.ReadLine();
            var result = PrefixCalc(prefixExp);
            Console.WriteLine($"{prefixExp} = {result}");
        }

        /// <summary>
        /// Calculates a prefix expression.
        /// </summary>
        /// <param name="prefixExp"></param>
        /// <returns></returns>
        public static double PrefixCalc(string prefixExp)
        {
            // split the expression
            var splitExp = prefixExp.Split(' ');
            
            // allocate a stack
            var stack = new Stack<double>();

            // run over all the elements of the expression
            foreach(var element in splitExp)
            {
                // if the current element is an operator
                if(element.IsBinaryOperator())
                {
                    // pop the two top number from the stack
                    var rightOperand = stack.Pop();
                    var leftOperand = stack.Pop();

                    // operate on them
                    var result = Calc(leftOperand, element, rightOperand);

                    // and push the result into the stack
                    stack.Push(result);
                }
                else // the current element is a number
                {
                    // push it into the stack
                    var value = double.Parse(element);
                    stack.Push(value);
                }
            }
            
            // return the result
            return stack.Pop();
        }


        /// <summary>
        /// Calculates a given simple exp.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        private static double Calc(double leftOperand, string op, double rightOperand)
        {
            var result = op switch
            {
                "+" => leftOperand + rightOperand,
                "-" => leftOperand - rightOperand,
                "*" => leftOperand * rightOperand,
                "/" => leftOperand / rightOperand,
                _ => throw new ArgumentException($"Unknown operator {op}."),
            };

            return result;
        }
    }

    public static class StringExtensions
    {
        /// <summary>
        /// An extension of class string that checks if a given string is a binary operator.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsBinaryOperator(this string str)
        {
            return str?.Length == 1 && "+-*/".Contains(str);
        }
    }

    // Exercises
    // Add the binary operator power. Use the sign "^" for the power operator. for example "2 3 ^" should returns 8.
    // Add the unary operators plus and minus. Use the signs "&+" and "&-" for the unary operators plus and minus, respectively. for example "2 3 * &-" should returns -6.
}
