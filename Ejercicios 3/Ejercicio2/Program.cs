using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine ("Ingrese un numero:");
            numero1 = int.Parse (Console.ReadLine());

            if (numero1 < 0){
                Console.WriteLine ("Su numero es negativo");
            } else{
                Console.WriteLine ("Su numero es positivo");
                }
        }
    }           
}
