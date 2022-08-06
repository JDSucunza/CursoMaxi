using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine ("Ingrese el 1er numero: ");
            n1 = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese el 2do numero: ");
            n2 = int.Parse (Console.ReadLine());

            if (n1 > n2){
                resultado = n1 - n2;
            } else if(n1 == n2){
                    resultado = n1 + n2;
                } else {
                        resultado = n1 * n2;
                    }

            Console.WriteLine ("El resultado es: " + resultado);        
        }
    }
}