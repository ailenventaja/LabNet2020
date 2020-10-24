using System;
using System.Collections.Generic;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Transporte avion1 = new Avion(150);
            Transporte avion2 = new Avion(100);
            Transporte avion3 = new Avion(130);
            Transporte avion4 = new Avion(300);
            Transporte avion5 = new Avion(230);
            Transporte automovil1 = new Automovil(2);
            Transporte automovil2 = new Automovil(5);
            Transporte automovil3 = new Automovil(4);
            Transporte automovil4 = new Automovil(3);
            Transporte automovil5 = new Automovil(2);

            List<Transporte> transportes = new List<Transporte>();

            transportes.Add(avion1);
            transportes.Add(avion2);
            transportes.Add(avion3);
            transportes.Add(avion4);
            transportes.Add(avion5);
            transportes.Add(automovil1);
            transportes.Add(automovil2);
            transportes.Add(automovil3);
            transportes.Add(automovil4);
            transportes.Add(automovil5);

            int numeroAvion = 1;
            int numeroAuto = 1;

            for (int i = 0; i < 10; i++)
            {
                
                if (transportes[i] is Avion)
                {
                    Console.WriteLine("Avion " + numeroAvion + ": " + transportes[i].Pasajeros + " pasajeros.");
                    numeroAvion++;
                }


                else
                {
                    Console.WriteLine("Automovil " + numeroAuto + ": " + transportes[i].Pasajeros + " pasajeros.");
                    numeroAuto++;
                }
            }

            Console.ReadKey();

        }
    }
}
