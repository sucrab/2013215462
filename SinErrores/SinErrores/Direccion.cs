using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class Direccion
    {
        Ubigeo ub = new Ubigeo();

        private string direcc, ubig;

        public string Ubig
        {
            get { return ubig; }
            set { ubig = value; }
        }

        public string Direcc
        {
            get { return direcc; }
            set { direcc = value; }
        }

        public Direccion()
        {

        }
        public Direccion(string direc)
        {
            Direcc = direc;
            Ubig = ub.Ubigeo1;

        }

    }
}
