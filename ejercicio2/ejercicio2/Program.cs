using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidx a la consola donde nada puede malir sal.\n---------------------------------------------------\n\n1) Ingrese un valor para dividir por cero: ");
            int dividendo = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(dividendo.DivisionByZero());
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
            }
            finally
            {
                Console.WriteLine("\nEsa fue la primera operación finalizada.");
            }

            try
            {
                Console.WriteLine("\n2) Ingresar dos números para la segunda operación.\n\nDividendo: ");
                dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("\nDivisor: ");
                int divisor = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nEl resultado de la división es {dividendo.Division(divisor)}");   
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"\nSolo LeChuck divide por cero!\nError: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Seguro ingresaste una letra o no ingresaste nada!\nError: {e.Message}");
            }
            finally
            {
                Console.WriteLine("\nEsa fue la segunda operación finalizada.");
            }
            Console.WriteLine("\n3) Ahora voy a lanzar una excepción yo: \n");
            Logic logic = new Logic();
            try
            {
                logic.ThrowException();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"¡Una excepción salvaje ha aparecido!\n¡Excepción usó: {e.GetType()}! Es muy efectivo...\nDaño: {e.Message}");
            }
            finally
            {
                Console.WriteLine("\n:)\n");
            }

            try
            {
                throw new CustomException("Soy una excepción personalizada");
            }
            catch (Exception e)
            {
                Console.WriteLine("4) Esta excepción fue a propósito: \n\n");
                Console.WriteLine("***************************************************");
                Console.WriteLine("*                                                 *");
                Console.WriteLine($"*         {e.Message}         *");
                Console.WriteLine("*                                                 *");
                Console.WriteLine("***************************************************\n");
            }
            finally
            {
                Console.WriteLine("\nTodas las excepciones fueron capturadas con éxito. Que tenga un buen día.");
            }
            Console.ReadKey();
        }
    }
}
