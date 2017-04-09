using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class contrato
    {
        private string contra;

        public string Contrato
        {
            get { return contra; }
            set { contra = value; }
        }

        public contrato(string contra)
        {
            Contrato = contra;

        }

        public contrato()
        {
            // TODO: Complete member initialization
        }
    }
}
