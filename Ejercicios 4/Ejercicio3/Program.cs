using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionMicro, opcionRAM, ampliaDisco, costo;
            
            Console.WriteLine ("Ingrese la opcion de Micro 1, 2 o 3:");
            opcionMicro = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese la opcion de la memoria RAM 1, 2 o 3");
            opcionRAM = int.Parse (Console.ReadLine());
            
            switch (opcionMicro)
            {
                case 1 :    
                
                    if (opcionRAM == 1 || opcionRAM == 2){
                        if (opcionRAM == 1){
                            Console.WriteLine ("Estoy en opcion 1.1");
                            costo = 800;
                        } else {
                            Console.WriteLine ("Estoy en opcion 1.2");
                            costo = 900;
                        }
                    } else {
                         Console.WriteLine ("Estoy en opcion 1.3");
                         costo = 1000;
                    }
                    break;
                
                case 2:

                    if (opcionRAM == 1 || opcionRAM == 2){
                        if (opcionRAM == 1){
                            Console.WriteLine ("Estoy en opcion 2.1");
                            costo = 900;
                        } else {
                            Console.WriteLine ("Estoy en opcion 2.2");
                            costo = 1000;
                        }
                    } else {
                        Console.WriteLine ("Estoy en opcion 2.3");
                         costo = 1400;
                    }
                    break;
                
                default:
                    
                    if (opcionRAM == 1 || opcionRAM == 2){
                        if (opcionRAM == 1){
                            Console.WriteLine ("Estoy en opcion 3.1");
                            costo = 1200;
                        } else {
                            Console.WriteLine ("Estoy en opcion 3.2");
                            costo = 1400;
                        }
                    } else {
                         Console.WriteLine ("Estoy en opcion 3.3");
                         costo = 2000;
                    }
                    break;
                
            }
            
            Console.WriteLine ("Desea ampliar el espacio en disco por USD 300 extras?  1 = si, 0 = no");
            ampliaDisco = int.Parse (Console.ReadLine());

            if (ampliaDisco == 1){
                costo = costo + 300;
            }

            Console.WriteLine ("El costo de su equipor es: " + costo);
        }
    }
}
