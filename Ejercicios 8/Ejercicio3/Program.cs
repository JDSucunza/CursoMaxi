using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n, contador = 0, acum = 0;

            Console.WriteLine ("Ingrese un numero:");
            n = int.Parse (Console.ReadLine());

            while (n != 0)
            {
                if (primo(n) == 1 ){
                    contador = contador + 1;
                    acum = acum + n;
                }
                Console.WriteLine ("Ingrese un numero:");
                n= int.Parse (Console.ReadLine());
            }

            Console.WriteLine ("El promedio de los numeros primos es: " + promedio (acum, contador));
        }

        static int primo (int n1){

            
            int contador = 0, num = n1, resultado = 0;
            
            for (int i = 1; i < num; i++)
            {
                 if (num % i == 0){
                    contador = contador + 1;
                }
            }

            if (contador <= 2){
                resultado = 1;
            }
        
            return resultado;
        
        }
    
        static int promedio (int sumaTotal, int cantidadElementos){
                return sumaTotal / cantidadElementos;
        }
    }
}
