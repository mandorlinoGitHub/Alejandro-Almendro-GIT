using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_Essential_Training;

namespace _1_Essential_Training
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.GroceryList.Length, 4);
            Assert.AreEqual(testInstance.GroceryList[0], "leche");
        }
        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
        }
    }
}
