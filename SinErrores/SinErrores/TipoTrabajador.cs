using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class TipoTrabajador
    {
        private string tipodeTrabajador;

        public string TipodeTrabajador
        {
            get { return tipodeTrabajador; }
            set { tipodeTrabajador = value; }
        }



        public TipoTrabajador(string tipotrabaj)
        {
            TipodeTrabajador = tipotrabaj;
        }

        public TipoTrabajador()
        {
            // TODO: Complete member initialization
        }
    }
}
