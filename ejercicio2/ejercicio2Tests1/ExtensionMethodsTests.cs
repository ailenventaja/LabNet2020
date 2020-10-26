using ejercicio2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass()]
    public class ExtensionMethodsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionByZeroTest()
        {
            //arrange
            int a = 21;

            //act
            a.DivisionByZero();
        }

        [TestMethod()]
        public void DivisionTest()
        {
            //arrange
            int a = 21;
            int b = 3;
            int expected = 7;

            //act
            int actual = a.Division(b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionExceptionTest()
        {
            //arrange
            int a = 21;
            int b = 0;

            //act
            a.Division(b);
        }
    }
}