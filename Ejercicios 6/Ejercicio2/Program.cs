using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, impares, cont, porc, mayor, masImpares = 0, ordenados = 0, grupoMasImpares = -1;
            bool estaOrdenado = true;

            for (int i = 0; i < 5; i++){
                Console.WriteLine ("Ingrese un numero:");
                n = int.Parse (Console.ReadLine ());

                impares = 0;
                cont = 0;
                mayor = n;
                
                while (n != 0){
                    cont ++;
                    if (n % 2 != 0){
                        impares++;
                    }
                    if (n > mayor){
                        estaOrdenado = false;
                    }
                    Console.WriteLine ("Ingrese un numero:");
                    n = int.Parse (Console.ReadLine ());
                }

                if (estaOrdenado){
                    ordenados = ordenados + 1;
                }

                porc = impares * 100 / cont;
                if (porc > masImpares ){
                    masImpares = porc;
                    grupoMasImpares = i + 1;
                }

            }

            Console.WriteLine ("El grupo con mayor porcentaje de impares es " + grupoMasImpares + ".");
            Console.WriteLine ("La cantidad de grupos ordenados de mayor a menor es: " + ordenados + ".");
        }
    }
}
