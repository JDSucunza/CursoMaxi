using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor;
            Console.WriteLine ("Ingrese un numero:");
            mayor = int.Parse (Console.ReadLine());

            for (int i = 0; i < 9; i++){
                Console.WriteLine ("Ingrese un numero:");
                n = int.Parse (Console.ReadLine());
                if (n > mayor){
                    mayor = n;
                }
            }
            Console.WriteLine ("El mayor es: " + mayor);
        }
    }
}
