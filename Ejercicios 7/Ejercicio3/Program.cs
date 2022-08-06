using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letraActual, letra1, letra2;
            int largo, posCadena = 0;
            
            
            Console.WriteLine ("Ingrese el numero de letras de su texto fuente.");
            largo = int.Parse (Console.ReadLine());
            
            char[] cadena = new  char [largo + 1];

            Console.WriteLine ("Ingrese su texto letra por letra. (Termina con punto)");
            letraActual = char.Parse (Console.ReadLine());
            
            while (posCadena < largo && letraActual != '.' ){
                cadena [posCadena] = letraActual;
                letraActual = char.Parse (Console.ReadLine());
                posCadena ++;
            }
            cadena [posCadena] = '\0';
            posCadena = 0;

            Console.WriteLine ("Ingrese la letra a reemplazar.");
            letra1 = char.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese la letra que va a reemplazar a la anterior.");
            letra2 = char.Parse(Console.ReadLine ());

            while (cadena [posCadena] != '\0' ){
                if (cadena [posCadena] == letra1){
                    cadena [posCadena] = letra2;
                }
                posCadena ++;
            }

            posCadena = 0;
            while (cadena[posCadena] != '\0'){
                Console.Write (cadena [posCadena]);
                posCadena ++;
            }
        }
    }
}
