using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Telefono
    {
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;
        private string contacto;
        


        public Telefono(string marca, string modelo)
        {
            this.modelo = modelo;
            this.marca = marca;
            
        }        

        public string Modelo
        {
            get { return modelo; }
        }        
        public string Marca
        {
            get { return marca; } 
        }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }   
        }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (codigoOperador > 0 && codigoOperador < 4)
                {
                    codigoOperador = value;
                } else
                {
                    codigoOperador = 0;
                }
            }
        }

        public string Llamar()
        {
            return "Realizando llamada....";
        }

        public string Llamar(string contact)
        {
            
            this.contacto = contact;
            return "Llamando a " + contacto;
        }
    }
}
