using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class TipoPlan
    {
        private string tipoPlan;

        public string[] planes = { "Conexion 69", "Conexion 29", "Conexion 99" };

        public string TipoPlan1
        {
            get { return tipoPlan; }
            set { tipoPlan = value; }
        }

        public TipoPlan()
        {

        }
    
        public TipoPlan(int num)
        {
            tipo(num);
        }

        public void tipo(int num)
        {
             
            if ( num == 982096748)
            {
                TipoPlan1 = "Conexion 69";
            }
            if ( num == 942463134)
            {
                TipoPlan1 = "Conexion 29";
            }
            if ( num == 123456789)
            {
                TipoPlan1 = "Conexion 99";
            }
        }
    }
}
