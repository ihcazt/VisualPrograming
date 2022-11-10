using System;
using System.Collections;
using System.Collections.Generic;

namespace _03_LinkedList
{
    /// <summary>
    /// A linked list of elements of type T, where T is nullable.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : ILinkedList<T>
    {
        /// <summary>
        /// The head of the list;
        /// </summary>
        private Link<T> first;

        /// <summary>
        /// Constructs an empty list.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public LinkedList()
        {
            if (default(T) != null)
            {
                throw new InvalidOperationException("Not a nullable type.");
            }

            Clear();
        }

        public long Size { get; private set; }

        public bool Empty => Size == 0;

        public T First
        {
            get
            {
                if (Empty)
                {
                    return default;
                }

                return first.data;
            }
        }

        public bool AddFirst(T element)
        {
            if (element == null)
            {
                return false;
            }

            first = new Link<T>(element, first);
            ++Size;

            return true;
        }

        public bool AddLast(T element)
        {
            if (Empty)
            {
                return AddFirst(element);
            }
            else
            {
                if (element == null)
                {
                    return false;
                }

                var p = first;
                while (p.next != null)
                {
                    p = p.next;
                }

                p.next = new Link<T>(element, null);
                ++Size;

                return true;
            }
        }

        public bool Contains(T element)
        {
            var p = first;
            while (p?.data.Equals(element) == false)
            {
                p = p.next;
            }

            return p != null;
        }

        public T RemoveFirst()
        {
            if (Empty)
            {
                return default;
            }

            var data = first.data;

            first = first.next;
            --Size;

            return data;
        }

        public T RemoveLast()
        {
            if (Size <= 1)
            {
                return RemoveFirst();
            }

            var p = first;
            while (p.next.next != null)
            {
                p = p.next;
            }

            var data = p.next.data;
            p.next = null;
            --Size;

            return data;
        }

        public bool Remove(T element)
        {
            if (Empty)
            {
                return false;
            }

            if (first.data.Equals(element))
            {
                RemoveFirst();
                return true;
            }

            var p = first;
            while (p.next?.data.Equals(element) == false)
            {
                p = p.next;
            }

            if (p.next == null)
                return false;

            p.next = p.next.next;
            --Size;

            return true;
        }

        public void Clear()
        {
            first = null;
            Size = 0;
        }

        public override string ToString()
        {
            var s = "{";
            foreach (var element in this)
            {
                s += "(" + element + ")";
            }
            s += "}";

            return s;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var p = first; p != null; p = p.next)
            {
                yield return p.data;
            }
        }

        // needed because the generic IEnumerator<T> implements IEnumerator.
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// A link of a linked list of an elements of type E.
        /// </summary>
        /// <typeparam name="E"></typeparam>
        private class Link<E>
        {
            /// <summary>
            /// The data.
            /// </summary>
            internal E data;

            /// <summary>
            /// The next link.
            /// </summary>
            internal Link<E> next;

            /// <summary>
            /// Trivial constructor.
            /// </summary>
            /// <param name="data"></param>
            /// <param name="next"></param>
            internal Link(E data, Link<E> next)
            {
                this.data = data;
                this.next = next;
            }
        }
    }
}
