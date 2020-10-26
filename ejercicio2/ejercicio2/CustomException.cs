using System;

namespace ejercicio2
{
    public class CustomException: Exception
    {
        private string message;
        public CustomException (string message) :base(message)
        {
            this.message = message;
        }

        public override string Message
        {
            get { return this.message; }
        }
    }
}
