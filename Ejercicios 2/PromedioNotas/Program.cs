using System;

namespace PromedioNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, promedio;
            
            Console.WriteLine("Ingrese la 1er nota");
            nota1 = int.Parse (Console.ReadLine ());
            Console.WriteLine("Ingrese la 2da nota");
            nota2 = int.Parse (Console.ReadLine ());
            Console.WriteLine("Ingrese la 3er nota");
            nota3 = int.Parse (Console.ReadLine ());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine ("El promedio del alumno es: " + promedio);
        }
    }
}
