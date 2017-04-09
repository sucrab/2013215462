using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class Distrito
    {
        Provincia prov = new Provincia();

        private string distrito;

        public string Distrito1
        {
            get { return distrito; }
            set { distrito = value; }
        }
        private string provincia;

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public Distrito()
        {


        }

        public Distrito(string dis)
        {
            Distrito1 = dis;
            provincia = prov.Provincia1;
        }


    }
}
