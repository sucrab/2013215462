using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class Tipolinea
    {

        // string [] tipolin = {}

        private string tipolinea1;

        public string Tipolinea1
        {
            get { return tipolinea1; }
            set { tipolinea1 = value; }
        }

        public Tipolinea()
        {


        }

        public Tipolinea(int num)
        {
            tipolin(num);

        }
        public void tipolin(int num)
        {
            if (num == 982096748 || num == 942463134 || num == 123456789)
            {

                Tipolinea1 = "Post-Pago";
            }
            else
            {
                Tipolinea1 = "Pre-Pago";
            }
        }
            
    
        
    }
}
