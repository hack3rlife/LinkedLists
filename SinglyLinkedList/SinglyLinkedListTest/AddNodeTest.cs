using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SinglyLinkedListTest
{
    [TestClass]
    public class AddNodeTest
    {
        /// <summary>
        /// Add a new node to a brand new <see cref="SinglyLinkedList"/>.        
        /// </summary>
        /// <remarks>Verify the newNode is added as Head of the SinglyLinkedList at it is null.</remarks>
        [TestMethod]
        [TestCategory("SinglyLinkedList.Add")]
        public void AddNewNodeEmptyList()
        {
            //arrange
            var value = 1;
            var list = new SinglyLinkedList.SinglyLinkedList<int>();

            //act
            list.Add(value);

            //assert
            var expected = value;
            var actual = list.Head.Value;

            Assert.AreEqual<int>(expected, actual);
        }

        /// <summary>
        /// Add a new to a brand new <see cref="SinglyLinkedList"/>
        /// </summary>
        /// <remarks>Verify the newNode is added at the beginning of the list and newNode will be the new Head of the SinglyLinkedList.</remarks>
        [TestMethod]
        [TestCategory("SinglyLinkedList.Add")]
        public void AddNewNodeExistingList()
        {
            //arrange
            var value1 = 1;
            var value2 = 2;
            var list = new SinglyLinkedList.SinglyLinkedList<int>();

            //act
            list.Add(value1);
            list.Add(value2);

            //assert
            var expected = value2;
            var actual = list.Head.Value;

            Assert.AreEqual<int>(expected, actual);
        }

        /// <summary>
        /// Add a new to a brand new <see cref="SinglyLinkedList"/>.
        /// </summary>
        /// <remarks>Verify that the see cref="SinglyLinkedList"/> Count value is correct after adding some nodes.</remarks>
        [TestMethod]
        [TestCategory("SinglyLinkedList.Add")]
        public void AddNewNodeVerifyCounter()
        {
            //arrange
            var values = new int[] { 5, 4, 3, 2, 1 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();

            //act
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            //assert
            var expected = values.Length;
            var actual = list.Count;

            Assert.AreEqual<int>(expected, actual);
        }
    }
}