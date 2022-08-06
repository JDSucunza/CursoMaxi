using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;

            Console.WriteLine ("Ingrese el 1er numero: ");
            n1 = float.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese el 2do numero: ");
            n2 = float.Parse (Console.ReadLine ());
            if (n2 < n1){
                n1 = n2;
            }
            Console.WriteLine ("Ingrese el 3er numero: ");
            n2 = float.Parse (Console.ReadLine ());
            if (n2 < n1){
                n1 = n2;
            }
            Console.WriteLine ("Ingrese el 4to numero: ");
            n2 = float.Parse (Console.ReadLine ());
            if (n2 < n1){
                n1 = n2;
            }
            
            
            Console.WriteLine ("El menor es: " + n1);
        
        }
    }
}
