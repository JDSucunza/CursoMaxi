using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbito
{
    internal class Arquero : Jugador
    {
        private int vallaInvicta;

        public override Jugador(string name, int idRegistro)
        {
            this.vallaInvicta = 0;
        }
    }
}
