using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testavimoSavarankikas2;

namespace testavimoSavarankikas2.test
{
    [TestClass]
    public class Savarankiskas2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arange
            // Act 
            string rezultatas = Program.ApverstiEilute("qwertyuiop[");
            // Assert
            Assert.AreEqual(rezultatas, "[poiuytrewq");
        }


        [TestMethod]
        public void TestMethod2()
        {
            // Arange
            // Act 
            string rezultatas = Program.ApverstiEilute("{");
            // Assert
            Assert.AreEqual(rezultatas, "{");
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Arange
            // Act 
            string rezultatas = Program.ApverstiEilute("");
            // Assert
            Assert.AreEqual(rezultatas, "");
        }
    }
}
