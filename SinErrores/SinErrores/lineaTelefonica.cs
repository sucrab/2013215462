using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class lineaTelefonica
    {
        Tipolinea linea = new Tipolinea();

        administradorLinea admin = new administradorLinea();

        private string lineatelefonica;

        public string Lineatelefonica
        {
            get { return lineatelefonica; }
            set { lineatelefonica = value; }
        }

        private string tipolinea;

        public string Tipolinea
        {
            get { return tipolinea; }
            set { tipolinea = value; }
        }

        private string administrador;

        public string Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }



        public lineaTelefonica(string lineatele)
        {
            Lineatelefonica = lineatele;
            Tipolinea = linea.Tipolinea1;
            Administrador = admin.Administrador;
        }

        public lineaTelefonica()
        {
            // TODO: Complete member initialization
        }

    }
}
