using System;

namespace _01_DynArr
{
    internal static class Program
    {
        private static void Main()
        {
            IArray<int?> arr = Read();
            Console.WriteLine(arr);
            SelectionSort(arr);
            Console.WriteLine(arr);
            if (arr.Length >= 2)
            {
                arr.Set(arr.Length - 2, null);
                Console.WriteLine(arr);
            }
            if (arr.Length >= 1)
            {
                arr.Set(arr.Length - 1, null);
                Console.WriteLine(arr);
            }
            SelectionSort(arr);
            Console.WriteLine(arr);
            Console.WriteLine("(" + arr.Get(100) + ")");
            //// throw exception
            //_ = new DynArr<int>();
        }

        private static IArray<int?> Read()
        {
            var arr = new DynArr<int?>();
            Console.Write("Enter size >> ");
            var size = int.Parse(Console.ReadLine().Trim());
            for (var i = 0; i < size; ++i)
            {
                Console.Write("Enter [" + i + "] >> ");
                arr.Set(i, int.Parse(Console.ReadLine().Trim()));
            }
            return arr;
        }

        private static void SelectionSort(IArray<int?> arr)
        {
            for (var i = 0; i < arr.Length - 1; ++i)
            {
                Swap(arr, i, MinIdx(arr, i));
            }
        }

        private static int MinIdx(IArray<int?> arr, int i)
        {
            var mi = i;
            for (var j = i + 1; j < arr.Length; ++j)
            {
                if (arr.Get(j) < arr.Get(mi))
                {
                    mi = j;
                }
            }

            return mi;
        }

        private static void Swap(IArray<int?> arr, int i, int j)
        {
            var t = arr.Get(i);
            arr.Set(i, arr.Get(j));
            arr.Set(j, t);

        }
    }
}

// Exercises
// 1. Add to the following functions:
//        Insertion sort.
//        ReversePrint - function that prints the element of the array in reverse order.
