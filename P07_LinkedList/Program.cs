using System;

namespace _03_LinkedList
{
    static class Program
    {
        private static void Main()
        {
            LinkedList<int?> list = new LinkedList<int?>();
            Console.WriteLine(list.RemoveFirst());
            Console.WriteLine(list);
            Console.WriteLine(list.Size);
            Console.WriteLine(list.Empty);
            for (var val = 0; val < 10; ++val)
            {
                list.AddLast(val);
                Console.WriteLine(list);
            }
            Console.WriteLine(list.AddLast(null));
            Console.WriteLine(list.Size);
            Console.WriteLine(list.Empty);
            Console.WriteLine(list.RemoveFirst());
            Console.WriteLine(list);
            Console.WriteLine(list.Size);
            Console.WriteLine(list.RemoveLast());
            Console.WriteLine(list);
            Console.WriteLine(list.Size);
            Console.WriteLine(list.Remove(4));
            Console.WriteLine(list.Remove(null));
            Console.WriteLine(list);
            Console.WriteLine(list.Size);
            for (var val = 0; val > -5; --val)
            {
                list.AddFirst(val);
                Console.WriteLine(list);
            }
            Console.WriteLine(list.Size);
            foreach (var val in list)
            {
                Console.WriteLine(val + ": " + list.Contains(val));
            }
            foreach (var val in list)
            {
                Console.Write("(" + val + ")");
            }
            Console.WriteLine();
            list.Clear();
            Console.WriteLine(list);
        }
    }
}

// Exercises
// 1. Write an interface of stack (name it IStack)
// 2. Write a class of stack that implements the interface IStack using LinkedList.
// 3. Write a static function that calculates a value of a given postfix expression using your implementation of stack.
