using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont, nLista = 0;

            Console.WriteLine ("Ingrese un numero: ");
            n = int.Parse (Console.ReadLine());

            while (n > 0){
                cont = 0;
                nLista ++;
                while (n > 0){
                    cont ++ ;
                    Console.WriteLine ("Ingrese un numero: ");
                    n = int.Parse (Console.ReadLine());
                }
                Console.WriteLine ("La lista: " + nLista + " tiene " + cont + " numeros.");
                Console.WriteLine ("Ingrese un numero: ");
                n = int.Parse (Console.ReadLine());
                
            }
        }
    }
}
