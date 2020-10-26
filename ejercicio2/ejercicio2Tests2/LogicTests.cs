using ejercicio2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void ThrowExceptionTest()
        {
            //arrange
            Logic logic = new Logic();

            //act
            logic.ThrowException();
        }
    }
}

    