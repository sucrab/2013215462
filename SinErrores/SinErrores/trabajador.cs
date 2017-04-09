using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class trabajador
    {
        TipoTrabajador tip = new TipoTrabajador();

        private string trabaja;

        public string Trabajador
        {
            get { return trabaja; }
            set { trabaja = value; }
        }
        private string tipTraba;

        public string TipTraba
        {
            get { return tipTraba; }
            set { tipTraba = value; }
        }

        public trabajador() { }

        public trabajador(string trab)
        {
            Trabajador = trab;

            TipTraba = tip.TipodeTrabajador;
        }
    }
}