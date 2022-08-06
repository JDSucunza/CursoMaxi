using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float importeTotal, cantLitros;
            
            Console.WriteLine ("Ingrese el importe total de la venta:");
            importeTotal = float.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese la cantidad de litros vendidos:");
            cantLitros = float.Parse (Console.ReadLine());

           /* if (cantLitros > 100){
                
               if (cantLitros > 300 && cantLitros <= 500){
                    importeFinal = importeTotal * 0.85f;
               } else if (cantLitros > 500){
                    importeFinal = importeTotal * 0.75f;
                } else {
                    importeFinal = importeTotal * 0.90f;
                } 
            } else {
                importeFinal = importeTotal;
            }*/

                if (cantLitros > 500){
                    importeTotal = importeTotal * 0.75f;
                }else if (cantLitros > 300){
                    importeTotal = importeTotal * 0.85f;
                }else if (cantLitros > 100){
                    importeTotal = importeTotal * 0.90f;
                }
        
            Console.WriteLine ("La cantidad a pagar es: " + importeTotal);
        
        }


    }
}
