using System;

namespace _01_DynArr
{
    /// <summary>
    /// Implements dynamic array of elements of type T, where T is nullable.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynArr<T> : IArray<T>
    {
        /// <summary>
        /// The array.
        /// </summary>
        private T[] TheDynArr = new T[0];

        /// <summary>
        /// Creates array with elements of type T, where T is nullable.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public DynArr()
        {
            if (default(T) != null)
            {
                throw new InvalidOperationException("Not a nullable type.");
            }
        }

        public int Length => TheDynArr.Length;

        public void Set(int i, T x)
        {
            if (i < 0)
            {
                throw new IndexOutOfRangeException("index out of range.");
            }

            if (i >= Length)
            {
                Enlarge(i + 1);
            }


            if (x != null)
            {
                TheDynArr[i] = x;
            }
            else
            {
                TheDynArr[i] = x;

                if (x == null && i == Length - 1)
                {
                    Compaction();
                }
            }
        }

        public T Get(int i)
        {
            if (i < 0)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }

            if (i >= Length)
            {
                return default;
            }

            return TheDynArr[i];
        }

        public override string ToString()
        {
            var s = "{";
            foreach (var element in TheDynArr)
            {
                s += "(" + element + ")";
            }
            s += "}";

            return s;
        }

        /// <summary>
        /// Enlarge the array to a given size.
        /// </summary>
        /// <param name="size">the given index</param>
        private void Enlarge(int size)
        {
            T[] temp = new T[size];
            CopyAndReplace(temp, Length);
        }

        /// <summary>
        /// Free the empty space from the end of arr.
        /// </summary>
        private void Compaction()
        {
            var i = Length - 1;
            while (i >= 0 && TheDynArr[i] == null)
            {
                --i;
            }

            if (i < Length - 1)
            {
                int n = i + 1;

                T[] temp = new T[n];

                CopyAndReplace(temp, n);
            }
        }

        /// <summary>
        /// Copies the n first elements of the dynamic array to a given array and replaces the dynamic array with the given array.
        /// </summary>
        /// <param name="arr">The array to copy</param>
        /// <param name="n">The another array</param>
        private void CopyAndReplace(T[] arr, int n)
        {
            for (var i = 0; i < n; ++i)
            {
                arr[i] = TheDynArr[i];
            }

            TheDynArr = arr;
        }
    }
}
