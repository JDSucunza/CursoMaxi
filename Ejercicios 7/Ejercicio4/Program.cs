using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] articulos =  new int [15];
           int cantidad = 0;
           int numArticulo, masVendido = 0; 
        
            for (int i = 0; i < 15; i++)
            {
                articulos [i] = cantidad;
            }
            
            Console.WriteLine ("Ingrese el numero de articulo vendido (1-15). (Corta con 0)");
            numArticulo = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese la cantidad vendida del articulo.");
            cantidad = int.Parse (Console.ReadLine());
            
         
          while (numArticulo != 0){
                 
                articulos [numArticulo - 1] =  articulos [numArticulo] + cantidad;
                Console.WriteLine ("Ingrese el numero de articulo vendido (1-15). (Corta con 0)");
                numArticulo = int.Parse (Console.ReadLine());
                if (numArticulo != 0){
                    Console.WriteLine ("Ingrese la cantidad vendida del articulo.");
                    cantidad = int.Parse (Console.ReadLine());
                }

            } 

            for (int i = 0; i < 15; i++)
            {
                  if (articulos [i] > masVendido){
                     masVendido = i + 1;
                  }
                  if (articulos [i] == 0){
                    Console.WriteLine ((i + 1) + " No tiene ventas.");
                  }   
            }
                Console.WriteLine ("Del producto 10 se vendieron " + articulos [9]);
                Console.WriteLine ("El mas vendido es el producto " + masVendido);
        
        }
    }
}
