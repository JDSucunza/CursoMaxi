using System;

namespace CalculadoraSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            float facturacionFinal, sueldoFinal;
            
            Console.WriteLine ("Ingrese la facturacion total del empleado:");
            facturacionFinal = float.Parse (Console.ReadLine());

            sueldoFinal = 15000 + (facturacionFinal * 5/100);
            
            Console.WriteLine ("El sueldo total es: " + sueldoFinal);
        }
    }
}
