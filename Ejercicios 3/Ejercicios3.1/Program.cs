using System;

namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine ("Ingrese un numero:");
            numero1 = int.Parse (Console.ReadLine());
            if (numero1 > 10){
                Console.WriteLine ("El numero es mayor a 10" );
            }   else {
                    Console.WriteLine ("El numero no es mayor a 10");
                }

        }
    }
}
