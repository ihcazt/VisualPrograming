using System;

namespace _01_DynArr
{
    /// <summary>
    /// An array of type T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IArray<T>
    {
        /// <summary>
        /// The actual length of the array. The position of the last not null element plus one.
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Sets the array cell in a given index with a given element.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="i"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        void Set(int i, T x);

        /// <summary>
        /// Returns the element in a given index in the array.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        T Get(int i);
    }
}
