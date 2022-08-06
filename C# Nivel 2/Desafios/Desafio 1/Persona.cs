using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Persona
    {
        private int edad;
        private string nombre;
        private object telefono;

        public Persona (string nombre)
        {
            this.nombre = nombre;
        }
        
        public int Edad { get { return edad; } set { edad = value; } }
        public string Nombre { get { return nombre; } }

        public object Telefono { get { return telefono; } set { telefono = value; }}

        public string hacerLLamada (Telefono telefono)
        {
           return "Persona esta " + telefono.Llamar();
        }


    
    
    
    }
}
