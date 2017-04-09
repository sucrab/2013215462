using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class Provincia
    {

        Departamento dpt = new Departamento();

        private string provincia;

        public string Provincia1
        {
            get { return provincia; }
            set { provincia = value; }
        }
        private string departamento;

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public Provincia()
        {

        }

        public Provincia(string prov)
        {
            Provincia1 = prov;
            Departamento = dpt.Departamento1;

        }
    }
}
