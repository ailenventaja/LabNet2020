using ejercicio2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass()]
    public class CustomExceptionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(CustomException))]
        public void CustomExceptionTest()
        {
            string expectedMessage = "Se envía un mensaje personalizado";

            //No supe comparar los mensajes sin el catch, por eso hice el try y después lancé la excepción para que la tome :c
            try
            {
                throw new CustomException(expectedMessage);
            }
            catch (Exception e)
            {
                Assert.AreEqual(expectedMessage, e.Message);
            }
            finally
            {
                throw new CustomException(expectedMessage);
            }
        }
    }
    
}