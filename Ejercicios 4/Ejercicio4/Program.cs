using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine ("Ingrese el 1er numero:");
            n1 = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese el 2do numero:");
            n2 = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese el 3er numero:");
            n3 = int.Parse (Console.ReadLine());

            if (n1 + n2 > n2 * n3){
                Console.WriteLine ("La suma del 1er y el 2do numero,  es mayor al producto del 2do y el 3ero");
            } else{
                Console.WriteLine ("La suma del 1er y el 2do numero, no es mayor al producto del 2do y el 3ero");
            } 
                       
        
        }
    }
}
