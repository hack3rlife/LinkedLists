using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SinglyLinkedListTest
{
    [TestClass]
    public class CopyToTest
    {
        [TestMethod]
        [TestCategory("SinglyLinkedList.CopyTo")]
        public void CopyToTestPass()
        {
            //arrange
            var values = new int[] { 4, 3, 2, 1, 0 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            //act
            var array = new int[5];
            list.CopyTo(array, 0);

            //assert
            for (int i = 1; i < array.Length; i++)
            {
                Assert.AreEqual<int>(i, array[i]);
            }
        }

        [TestMethod]
        [TestCategory("SinglyLinkedList.CopyTo")]
        public void CopyToNullArray()
        {
            //arrange
            var values = new int[] { 4, 3, 2, 1, 0 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            //act
            int[] array = null;
            list.CopyTo(array, 0);

            //assert
            Assert.IsNull(array);
        }

        [TestMethod]
        [TestCategory("SinglyLinkedList.CopyTo")]
        public void CopyToArrayIndexGreaterThan0()
        {
            //arrange
            var values = new int[] { 4, 3, 2, 1, 0 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            //act
            int[] array = new int[5];
            list.CopyTo(array, 2);

            //assert
            for (int i = 2; i < array.Length; i++)
            {
                var actual = array[i];
                var expected = i-2;
                Assert.AreEqual<int>(expected,actual);
            }
        }

        [TestMethod]
        [TestCategory("SinglyLinkedList.CopyTo")]
        public void CopyToArrayIndexLesserThan0()
        {
            //arrange
            var values = new int[] { 4, 3, 2, 1, 0 };

            var list = new SinglyLinkedList.SinglyLinkedList<int>();
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }

            //act
            int[] array = new int[5];
            list.CopyTo(array, -2);

            //assert
            for (int i = 0; i < array.Length; i++)
            {
                var actual = array[i];
                var expected = 0;
                Assert.AreEqual<int>(expected, actual);
            }
        }
    }
}
