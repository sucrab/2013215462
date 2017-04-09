using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class Plan
    {
        TipoPlan tip = new TipoPlan();


        private string plan;

        public string Plan1
        {
            get { return plan; }
            set { plan = value; }
        }
        private string tipoPla;

        public string TipoPla
        {
            get { return tipoPla; }
            set { tipoPla = value; }
        }

        public Plan()
        {

        }

        public Plan(string plan1)
        {
            
            Plan1 = plan1;
            TipoPla = tip.TipoPlan1;
        }
    }
}
