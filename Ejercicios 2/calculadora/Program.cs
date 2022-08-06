using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int resultado;
            
            Console.WriteLine("Ingrese un numero:");
            n1 = int.Parse(Console.ReadLine ());
            Console.WriteLine ("Ingrese un numero");
            n2 = int.Parse(Console.ReadLine ());
            
            resultado = n1 + n2;
            Console.WriteLine ("El resultado es:" + resultado);
        }
    }
}
