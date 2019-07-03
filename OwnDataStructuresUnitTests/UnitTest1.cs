using System;
using OwnDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OwnDataStructuresUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        LinkedLists<int> ll = new LinkedLists<int>();
        [TestMethod]
        public void TestllDisplay()
        {
             int []arr = { 1, 2, 3, 4, 5 };
             int n = arr.Length;
             Node<int> root = ll.arrayToList(arr, n);
             ll.display(root); 
        }
    }
}
