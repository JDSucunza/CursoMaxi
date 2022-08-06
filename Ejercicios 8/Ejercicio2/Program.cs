using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int contador = 0, n;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine ("Ingrese un numero:");
                n = int.Parse (Console.ReadLine());
                
                contador = contador + par (n);

            }

            Console.WriteLine ("La cantidad de numeros pares es: " + contador);

        
        }

        static int par (int n){
            if (n % 2 == 0){
                return 1;
            } else {
                return 0;
            }
        }
    
    
    }
}
