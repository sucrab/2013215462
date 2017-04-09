using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class TipoEvaluacion
    {

        private string tipoEva;

        public string TipoEva
        {
            get { return tipoEva; }
            set { tipoEva = value; }
        }

        public TipoEvaluacion(string tipoEva1)
        {
            TipoEva = tipoEva1;
        }

        public TipoEvaluacion()
        {
            // TODO: Complete member initialization
        }


    }
}
