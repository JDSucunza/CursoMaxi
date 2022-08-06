using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum = 0, prom, cont = 0;
            int [] numeros = new int [10];
            int [] mayores = new int [10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine ("Ingrese un numero: ");
                numeros [i] = int.Parse (Console.ReadLine());
                acum = acum + numeros [i];
            }

            prom = acum / 10;

            for (int x = 0; x < 10; x++)
            {
                if (numeros [x] > prom){
                    Console.WriteLine (numeros [x] + " es mayor al promedio.");
                }
            }

            
        }
    }    
}
