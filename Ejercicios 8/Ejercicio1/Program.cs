using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int precio, cantidad, montoTotal;

            Console.WriteLine ("Ingrese el precio del producto:");
            precio = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese la cantidad vendida del producto:");
            cantidad = int.Parse (Console.ReadLine ());

            montoTotal = producto (precio, cantidad);

            Console.WriteLine ("El monto total a pagar es: " +montoTotal);
        
        }
    
        static int producto (int n1,int n2){
            return n1 * n2;
        } 
    }
}
