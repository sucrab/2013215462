using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class EstadodeEvalu
    {

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public EstadodeEvalu(string estadoe)
        {
            Estado = estadoe;
        }

        public EstadodeEvalu()
        {
            // TODO: Complete member initialization
        }
    }
}
