using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class CentroDeAtencion
    {
        Direccion dir = new Direccion();
        private string centroAtencion;

        public string CentroAtencion
        {
            get { return centroAtencion; }
            set { centroAtencion = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public CentroDeAtencion() { }
        public CentroDeAtencion(string centro)
        {
            CentroAtencion = centro;
            Direccion = dir.Direcc;
        }
    }
}
