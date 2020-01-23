using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSavarankiskas3;

namespace TestSavarankiskas3.test
{
    [TestClass]
    public class TestSavarankiskas
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arange

            // Act
            bool isvada = Program.ArSkaiciusLyginis(10);
            // Assert
            Assert.AreEqual(isvada, true);
        }
    }
}
