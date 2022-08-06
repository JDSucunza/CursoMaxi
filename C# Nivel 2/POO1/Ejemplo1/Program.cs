using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.setEdad(20);
            
        
            Botella b1 = new Botella();
            b1.Capacidad = 200;

            Perro perro1 = new Perro();
            Perro perro2 = new Perro();
            Perro perro3 = new Perro();

            perro1.Nombre = Jack;
            perro2.Nombre = Rex;
            perro3.Nombre = Piston;

            Console.WriteLine("El perro 1 se llama:  " + perro1.Nombre);
            Console.ReadKey();


        }

    }
}
