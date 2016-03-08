using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SinglyLinkedListTest
{
    [TestClass]
    public class ClearListTest
    {
        [TestMethod]
        [TestCategory("SinglyLinkedList.Clear")]
        public void ClearVerifyListIsNull()
        {
            //arrange
            var values = new int[] { 5, 4, 3, 2, 1 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }
            //act
            list.Clear();

            //assert
            Assert.IsNull(list.Head);
        }

        [TestMethod]
        [TestCategory("SinglyLinkedList.Clear")]
        public void ClearVerifyCountIsZero()
        {
            //arrange
            var values = new int[] { 5, 4, 3, 2, 1 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }
            //act
            list.Clear();

            //assert
            Assert.IsTrue(list.Count == 0);
        }
    }
}
