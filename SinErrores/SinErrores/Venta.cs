using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class Venta
    {
        cliente cli = new cliente();
        contrato con = new contrato();
        tipoPago tipp = new tipoPago();
        CentroDeAtencion caten = new CentroDeAtencion();
        lineaTelefonica lin = new lineaTelefonica();


        private string venta, cliente, contrato, tipopago, centraten, linea;

        public string Linea
        {
            get { return linea; }
            set { linea = value; }
        }

        public string Centraten
        {
            get { return centraten; }
            set { centraten = value; }
        }

        public string Tipopago
        {
            get { return tipopago; }
            set { tipopago = value; }
        }

        public string Contrato
        {
            get { return contrato; }
            set { contrato = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Venta1
        {
            get { return venta; }
            set { venta = value; }
        }


        public Venta(string vent)
        {
            Venta1 = vent;
            Cliente = cli.Cliente1;
            contrato = con.Contrato;
            tipopago = tipp.Tipopago;
            centraten = caten.CentroAtencion;
            linea = lin.Lineatelefonica;
        }

        public Venta()
        {

        }






    }
}
