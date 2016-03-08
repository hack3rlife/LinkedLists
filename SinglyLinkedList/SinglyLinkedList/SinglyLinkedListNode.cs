using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        /// <summary>
        /// Gets or sets the value stored in <see cref="SinglyLinkedListNode"/>
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// Gets or sets current node's link to the following <see cref="SinglyLinkedListNode"/>
        /// </summary>
        public SinglyLinkedListNode<T> Next { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value"><see cref="Value"/></param>
        /// <param name="next"><see cref="Next"/></param>
        public SinglyLinkedListNode(T value, SinglyLinkedListNode<T> next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
