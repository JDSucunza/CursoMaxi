using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbito
{
    internal class Jugador
    {
        private int idRegistro;
        private string name;
        private Equipo equipo;
       

        public Jugador (string name, int idRegistro) {

            this.idRegistro = idRegistro;
            this.name = name;

        }
        public int IdRegistro { get { return idRegistro; }}
        
        public string Name { get { return name; }}

        public void fichar (Equipo equipo)
        {
            this.equipo = equipo;
        }
    }
}
