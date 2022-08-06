using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max, maxPos = 0;
            int [] numeros = new int [10];
            
            Console.WriteLine ("Ingrese numero: ");
            n = int.Parse (Console.ReadLine());
            max = n;
            
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine ("Ingrese numero: ");
                numeros [i] = int.Parse (Console.ReadLine ());
                     
                if (numeros [i] > max){
                    max = numeros [i];
                    maxPos = i;
                }

            }

            Console.WriteLine ("El valor maximo es: " + max );
            Console.WriteLine ("Esta en la posicion " + maxPos);
        }
    }
}
