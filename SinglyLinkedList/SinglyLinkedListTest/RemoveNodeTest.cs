using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SinglyLinkedListTest
{
    [TestClass]
    public class RemoveNodeTest
    {
        [TestMethod]
        [TestCategory("SinglyLinkedList.Remove")]
        public void RemoveNodeEmptyList()
        {
            //arrange
            var list = new SinglyLinkedList.SinglyLinkedList<int>();

            //act
            var condition = list.Remove(0);

            //assert
            Assert.IsFalse(condition);
        }

        [TestMethod]
        [TestCategory("SinglyLinkedList.Remove")]
        public void RemoveFirstElement()
        {
            //arrange
            var value1 = 1;
            var value2 = 2;
            var value3 = 3;

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            list.Add(value3);
            list.Add(value2);
            list.Add(value1);                     

            //act
            var condition = list.Remove(value1);

            //assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [TestCategory("SinglyLinkedList.Remove")]
        public void RemoveMiddleNode()
        {
            //arrange
            var value1 = 1;
            var value2 = 2;
            var value3 = 3;

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            list.Add(value3);
            list.Add(value2);
            list.Add(value1);            

            //act
            var condition = list.Remove(value2);

            //assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [TestCategory("SinglyLinkedList.Remove")]
        public void RemoveLastNode()
        {
            //arrange
            var value1 = 1;
            var value2 = 2;
            var value3 = 3;

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            list.Add(value3);
            list.Add(value2);
            list.Add(value1);          

            //act
            var condition = list.Remove(value1);

            //assert
            Assert.IsTrue(condition);
        }

        /// <summary>
        /// Add a new to a brand new <see cref="SinglyLinkedList"/>.
        /// </summary>
        /// <remarks>Verify that the see cref="SinglyLinkedList"/> Count value is correct after adding some nodes.</remarks>
        [TestMethod]
        [TestCategory("SinglyLinkedList.Remove")]
        public void RemoveNodeVerifyCounter()
        {
            //arrange
            var values = new int[] { 5, 4, 3, 2, 1 };
            var expected = values.Length;

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            //act
            list.Remove(1);
            expected--;
            list.Remove(5);
            expected--;
            list.Remove(3);
            expected--;

            //assert
            var actual = list.Count;

            Assert.AreEqual<int>(expected, actual);
        }
    }
}
