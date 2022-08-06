using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, acum = 0, cont = 0;

            for (int i = 0; i < 20; i++){
                Console.WriteLine ("Ingrese edad: ");
                edad = int.Parse (Console.ReadLine());
                if (edad > 18){
                    acum = acum + edad;
                    cont ++;
                }
            }
            acum = acum / cont;
            Console.WriteLine ("Promedio de edad de los mayores de 18: " + acum);

        }
    }
}
