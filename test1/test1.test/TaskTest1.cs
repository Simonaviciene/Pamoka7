using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test1;

namespace test1.test
{
    [TestClass]
    public class TaskTest1
    {
        [TestMethod]
        public void TaxShouldBe5PrecentWhen()
        {
            // Arange
            
            // Act
            decimal rezult = Program.Tax(40000);

            // Assert
            Assert.AreEqual(rezult, 2000);
        }
        [TestMethod]
        public void TaxShouldBe15PrecentWhenSum()
        {
            // Arange

            // Act
            decimal rezult = Program.Tax(50000);

            // Assert
            Assert.AreEqual(rezult, 7500);
        }
        [TestMethod]
        public void TaxShouldBe25PrecentWhenSumIsMore100000()
        {
            // Arange

            // Act
            decimal rezult = Program.Tax(1000000);

            // Assert
            Assert.AreEqual(rezult, 250000);
        }
        [TestMethod]
        public void TaxShouldBe5PrecentWhen0()
        {
            // Arange

            // Act
            decimal rezult = Program.Tax(0);

            // Assert
            Assert.AreEqual(rezult, 0);
        }
    }
}
