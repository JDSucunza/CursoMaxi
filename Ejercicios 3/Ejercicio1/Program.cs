using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine ("Ingrese un numero:");
            numero1 = int.Parse (Console.ReadLine());

            if (numero1 > 10){
                Console.WriteLine ("Su numero es mayor a 10");
            } else {
                  Console.WriteLine ("Su numero no es mayor a 10");
                }
        }
    }
}
