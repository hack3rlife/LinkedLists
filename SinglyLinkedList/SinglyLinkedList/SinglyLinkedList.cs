using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    public class SinglyLinkedList<T> : ICollection<T>
    {
        /// <summary>
        /// Gets the first node of the <see cref="SinglyLinkedList"/>
        /// </summary>
        public SinglyLinkedListNode<T> Head { get; set; }       

        /// <summary>
        /// Gets the number of nodes in <see cref="SinglyLinkedList"/>
        /// </summary>
        public int Count { get; set; }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Add a new node to the end of the Linked List
        /// </summary>
        /// <param name="item">Node's value</param>
        public void Add(T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
           
            if (this.Head == null)
            {
                this.Head = newNode;                    
            }
            else
            {
                newNode.Next = this.Head;
                this.Head = newNode;
            }

            this.Count++; 
        }

        /// <summary>
        /// Removes the first node from the Singly Linked List which value is equal to the provided value.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>The method will return true if a node is removed; otherwise false.</returns>
        public bool Remove(T item)
        {
            SinglyLinkedListNode<T> previous = null;
            SinglyLinkedListNode<T> current = this.Head;

            while (current != null)
            {
                if(current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        Head = Head.Next;
                    }

                    this.Count--;

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Removes all the node of a Singly Linked List.
        /// </summary>
        public void Clear()
        {
            this.Head = null;
            this.Count = 0;
        }

        /// <summary>
        /// Returns ture if the provided value exists within the list; otherwise false
        /// </summary>
        /// <param name="item">Matching value to be found</param>
        /// <returns>Returns true as soon as a node matching the value is found; otherwise false.</returns>
        public bool Contains(T item)
        {
            var current = this.Head;
            while (current!=null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Copies the values of the Singly Linked List into the provided array starting at the specified index array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                return;

            if (arrayIndex < 0)
                return;

            var current = this.Head;
            while (current != null && arrayIndex < array.Length)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Contains()
        {
            throw new NotImplementedException();
        }
    }
}