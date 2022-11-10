using System.Collections.Generic;

namespace _03_LinkedList
{
    /// <summary>
    /// A linked list of a given type T that implement an enumerator.
    /// </summary>
    /// <typeparam name="T">The type of objects in the list.</typeparam>
    /// <remarks> An enumerator supports a simple iteration over a collection of a specified type.<br/>
    /// It implements a method called GetEnumerator that iterates through a collection, in that case the linked list.</remarks>
    public interface ILinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// The size of the list.
        /// </summary>
		long Size { get; }

        /// <summary>
        /// Indicates if the list is empty.
        /// </summary>
        /// <returns></returns>
        bool Empty { get; }

        /// <summary>
        /// The first element of the list, if any, otherwise null.
        /// </summary>
        /// <returns></returns>
        T First { get; }

        /// <summary>
        /// Adds new element at the head of the list.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool AddFirst(T element);

        /// <summary>
        /// Adds new element at the tail of the list.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool AddLast(T element);

        /// <summary>
        /// Checks if the list contains an element.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool Contains(T element);

        /// <summary>
        /// Removes and returns the first element of the list, if any, otherwise returns null and removes nothing.
        /// </summary>
        /// <returns></returns>
        T RemoveFirst();

        /// <summary>
        /// Removes and returns the last element of the list, if any, otherwise returns null and removes nothing.
        /// </summary>
        /// <returns></returns>
        T RemoveLast();

        /// <summary>
        /// Removes a given element, if exists, from the list. On success returns true, otherwise, returns false.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool Remove(T element);

        /// <summary>
        /// Removes all the elements, if any, of the list.
        /// </summary>
        void Clear();
    }
}
