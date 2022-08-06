using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Telefono t1 = new Telefono("samsung", "s10");
            Telefono t2 = new Telefono("xiaomi", "mi10");
            Telefono t3 = new Telefono("iphone", "13max");
            Telefono t4 = new Telefono("motorolla", "moto");
            Persona persona = new Persona("Diego");

            t1.CodigoOperador = 4;
            Console.WriteLine ("El codigo de operador del telefono es: " + t1.CodigoOperador);

            persona.Telefono = t1;

            Console.WriteLine(persona.hacerLLamada(t1));

            

            
        }
    }
}
