using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importeFinal;
            
            Console.WriteLine ("Ingrese el importe total:");
            importeFinal = float.Parse (Console.ReadLine ());
            
            if (importeFinal >= 1000 && importeFinal <5000){
                importeFinal = importeFinal * 0.9f;
            }   else if(importeFinal >= 5000){
                     importeFinal = importeFinal * 0.82f;    
                }   

            Console.WriteLine ("El importe a pagar es" + importeFinal);

        }
    }
}
