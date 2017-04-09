using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class administradorLinea
    {
        private string administrador;

        public string Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }

        public administradorLinea(string admin)
        {
            Administrador = admin;
        }

        public administradorLinea()
        {

        }
    }
}