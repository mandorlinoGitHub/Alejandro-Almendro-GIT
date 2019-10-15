using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_Essential_Training;

namespace _1_Essential_Training
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tabasco");
            testInstance.Sauces.Add("Sriracha");
            testInstance.Sauces.Add("Ranch");

            //Expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Ranch"));

            //Expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
