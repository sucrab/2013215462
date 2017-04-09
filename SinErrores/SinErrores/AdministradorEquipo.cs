using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class AdministradorEquipo
    {
        private string administradorequipo;

        public string Administradorequipo
        {
            get { return administradorequipo; }
            set { administradorequipo = value; }
        }

        public AdministradorEquipo()
        {


        }
        public AdministradorEquipo(string adminis)
        {
            Administradorequipo = adminis;
        }
    }
}
