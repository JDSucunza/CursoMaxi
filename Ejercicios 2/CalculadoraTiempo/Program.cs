using System;

namespace CalculadoraTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int velPromedio, cantKm, tiempoAprox;
            Console.WriteLine("Ingrese la velocidad promedio de su vehiculo en km/h:");
            velPromedio = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese la cantidad de Kms de su viaje:");
            cantKm = int.Parse (Console.ReadLine ());

            tiempoAprox = cantKm / velPromedio;

            Console.WriteLine ("Tardara: " + tiempoAprox + hs);

        }
    }
}
