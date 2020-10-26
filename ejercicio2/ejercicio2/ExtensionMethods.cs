namespace ejercicio2
{
    public static class ExtensionMethods
    {

        public static int DivisionByZero(this int a)
        {
            return a / 0;
        }

        public static int Division (this int a, int b)
        {
            return a/b;
        }
    }
}
