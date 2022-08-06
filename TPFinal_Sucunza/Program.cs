using System;

namespace TPFinal_Sucunza
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
            //A partir de dichos datos informar:
            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            int numero, mayorPar = 0, cantImpares = 0, menorPrimos = 0;
            bool hayPar = false;
            bool hayPrimos = false;

            Console.WriteLine ("Ingrese un numero: (Corta con 0)");
            numero = int.Parse (Console.ReadLine ());
            
            while (numero != 0){
                
                if (esPar (numero)){
                    mayorPar = mayor (mayorPar, numero);
                    hayPar = true;
                } else {
                    cantImpares = cantImpares + 1;
                    
                }

                if (esPrimo (numero) && !hayPrimos){
                    menorPrimos = numero;
                    hayPrimos = true;
                } else if (esPrimo (numero)){
                    menorPrimos = menor (menorPrimos, numero);
                }

                Console.WriteLine ("Ingrese un numero: (Corta con 0)");
                numero = int.Parse (Console.ReadLine ());
            }

            if (!hayPar){
                Console.WriteLine ("No hay numeros pares en su lista.");
            } else {
                Console.WriteLine ("El mayor de los numeros pares es: " + mayorPar);
            }
            
            Console.WriteLine ("La cantidad de numeros impares es: " + cantImpares);

            if (!hayPrimos){
                Console.WriteLine ("No hay numeros primos en su lista.");
            } else {
                Console.WriteLine ("El menor de los numeros primos es: " + menorPrimos);
            }

        }
    
        static bool esPar (int n){
            return n % 2 == 0;
        }

        static int mayor (int n1,int n2){
            int mayor = 0;
            if (n1 > n2){
                mayor = n1;
            } else {
                mayor = n2;
            }
            return mayor;
        }

        static int menor (int n1,int n2){
            int menor = 0;
            if (n1 < n2){
                menor = n1;
            } else {
                menor = n2;
            }
            return menor;
        }

        static bool esPrimo (int n){
            int contador = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0){
                    contador = contador + 1;
                }
            }

            return contador <= 2;
        }
    
    
    }
}
