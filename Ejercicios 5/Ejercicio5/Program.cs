using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, par = 0, impar = 0;
            bool  hayMax = false, hayMin = false;

            for (int i = 0; i < 20; i++){
                Console.WriteLine ("Ingrese un numero: ");
                n = int.Parse (Console.ReadLine());
                if (n % 2 == 0 ){
                    if (!hayMax){
                        par = n;
                        hayMax = !hayMax;
                    } else if(n > par){
                        par = n;
                    }
                } else if (!hayMin){
                    impar = n;
                    hayMin = !hayMin;
                }else if (n < impar) {
                        impar = n;
                } 
            }

            if (!hayMax){
                Console.WriteLine ("No se ingreso ningun numero par y el minimo de los impares es " + impar + ".");
            }
            if (!hayMin){
                Console.WriteLine ("No se ingreso ningun numero impar y el maximo de los pares es " + par + ".");
            }

            Console.WriteLine ("El mayor de los numeros pares es: " + par + " El menor de los numeros impares es " + impar + ".");
        }
    }
}
