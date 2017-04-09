using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class tipoPago
    {
        private string tipopago;

        public string Tipopago
        {
            get { return tipopago; }
            set { tipopago = value; }
        }

        public tipoPago(string pago)
        {
            Tipopago = pago;
        }

        public tipoPago()
        {
            // TODO: Complete member initialization
        }
    }
}
