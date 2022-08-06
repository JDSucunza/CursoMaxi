using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont1 = 0, cont2 = 0;

            for (int i = 0; i < 10; i++ ){

                Console.WriteLine ("Ingrese un numero: ");
                n = int.Parse (Console.ReadLine());
                cont1 = 0;
                    for (int x = 1; x <= n; x++){
                        if (n % x == 0){
                            cont1 = cont1 + 1;
                               
                        }
                        if (cont1 == 2){
                        
                            cont2 = cont2 + 1;            
                        }
                    }
                    

            }

            Console.WriteLine ("Hay " + cont2 + " numeros primos.");
        }
    }
}
