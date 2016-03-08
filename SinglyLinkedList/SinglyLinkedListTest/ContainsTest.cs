using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SinglyLinkedListTest
{
    [TestClass]
    public class ContainsTest
    {
        [TestMethod]
        [TestCategory("SinglyLinkedList.Contains")]
        public void ContainsValueFound()
        {
            //arrange
            var values = new int[] { 5, 4, 3, 2, 1 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }
            //act
            var condition = list.Contains(3);

            //assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        [TestCategory("SinglyLinkedList.Contains")]
        public void ContainsValueNotFound()
        {
            //arrange
            var values = new int[] { 5, 4, 3, 2, 1 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }
            //act
            var condition = list.Contains(10);

            //assert
            Assert.IsFalse(condition);
        }
    }
}
