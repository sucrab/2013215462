using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class cliente
    {
        
        private string cli;
        // string[] nombres = new string[100];

        string[] nombres = { "Victor Diaz", "Brenda Garcia", "Julio Diaz", "Veronica Cortegana", "Juan Quijada"};

        
        public string Cliente1
        {
            get { return cli; }
            set { cli = value; }
        }

        public cliente()
        {
            
        }
        public cliente( int numero)
        {
            Cliente1 = generarCliente(numero);
        }

        public string generarCliente(int num)
        {
            if(num == 982096748 )
            {
                return nombres[0];
            }
            if(num == 942463134 )
            {
                return nombres[1];
            }
            if(num == 123456789){
                return nombres[2];
            }
            if (num == 123456788)
            {
                return nombres[3];
            }
            if (num == 123456787)
            {
                return nombres[4];
            }
            return "No se encuentra registrado";
            
        }

     
    }
}
