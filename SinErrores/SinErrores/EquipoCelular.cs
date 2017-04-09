using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class EquipoCelular
    {
        AdministradorEquipo objA = new AdministradorEquipo();

        private string equipocelular;

        public string Equipocelular
        {
            get { return equipocelular; }
            set { equipocelular = value; }
        }
        private string administrador;

        public string Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }

        public EquipoCelular(string equipo)
        {

            Administrador = objA.Administradorequipo;
            Equipocelular = equipo;
        }

        public EquipoCelular()
        {
            // TODO: Complete member initialization
        }


    }
}
