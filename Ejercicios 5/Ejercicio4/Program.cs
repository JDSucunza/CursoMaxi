using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse (Console.ReadLine());

            if (n == 1 || n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0 || n % 11 == 0 ){
                if (n ==1 || n != 2 && n != 3 && n != 5 && n != 7 && n != 11){
                    Console.WriteLine ("El numero " + n + " no es primo.");
                } else {
                    Console.WriteLine ("El numero " + n + " es primo.");
                }
            
            } else {
                Console.WriteLine ("El numero " + n + " es primo.");
            }
        }
    }
}
