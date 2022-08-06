using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            
            Console.WriteLine("Ingrese el 1er numero");
            n1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese el 2do numero");
            n2 = int.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese el 3er numero");
            n3 = int.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese el 4to numero");
            n4 = int.Parse (Console.ReadLine());
        
            if (n1 <= n2){
                Console.WriteLine ("Los numeros no estan ordenados de forma decreciente.");
            } else if (n2 <= n3) {
                 Console.WriteLine ("Los numeros no estan ordenados de forma decreciente.");
            } else if (n3 <= n4){
                Console.WriteLine ("Los numeros no estan ordenados de forma decreciente.");
            } else {
                Console.WriteLine ("Los numeros estan ordenados de forma decreciente.");
            }
        
        }
    }
}
