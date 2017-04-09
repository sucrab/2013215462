using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2013215462
{
    class Evaluacion
    {
        lineaTelefonica li = new lineaTelefonica();
        EquipoCelular equi = new EquipoCelular();
        Plan pla = new Plan();
        trabajador trab = new trabajador();
        EstadodeEvalu esta = new EstadodeEvalu();
        TipoEvaluacion tipe = new TipoEvaluacion();
       
        Venta ven = new Venta();
        CentroDeAtencion cen = new CentroDeAtencion();
        TipoPlan tipopla = new TipoPlan();

        private string evaluacion, linea, equipo, plan, trabajador, estado, tipoEv, clien, vent = "", centro;

        public string Evaluacion1
        {
            get { return evaluacion; }
            set { evaluacion = value; }
        }

        public string Centro
        {
            get { return centro; }
            set { centro = value; }
        }

        public string Vent
        {
            get { return vent; }
            set { vent = value; }
        }

        public string Clien
        {
            get { return clien; }
            set { clien = value; }
        }

        public string TipoEv
        {
            get { return tipoEv; }
            set { tipoEv = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Trabajador
        {
            get { return trabajador; }
            set { trabajador = value; }
        }

        public string Plan
        {
            get { return plan; }
            set { plan = value; }
        }

        public string Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }

        public string Linea
        {
            get { return linea; }
            set { linea = value; }
        }


        public string verificatili(int num)
        {
            Tipolinea tip = new Tipolinea(num);
            return tip.Tipolinea1;
            
        }

        public string verificacion(int num)
        {
            cliente cli = new cliente(num);

            return cli.Cliente1;
        }

        public Evaluacion(string evaluacion)
        {
            Evaluacion1 = evaluacion;
            Linea = li.Lineatelefonica;
            Equipo = equi.Equipocelular;
            Plan = pla.Plan1;
            Trabajador = trab.Trabajador;
            Estado = esta.Estado;
            tipoEv = tipe.TipoEva;
            
            Vent = ven.Venta1;
            Centro = cen.CentroAtencion;


        }

        public Evaluacion()
        {

        }

        public string evaluardos(string plan)
        {
            string mensaje = "";
            
            if (plan.Equals("Conexion 69"))
            {
                mensaje = "El usuario con plan: " + plan + " Cuenta con el estado: Renovacion aprobada";

            }
            if (plan.Equals("Conexion 21"))
            {
                mensaje = "El usuario con plan: " + plan + " Cuenta con el estado: Nueva Linea Aprobada";
            }

            if(plan.Equals("Conexion 99"))
            {
                mensaje = "El usuario con plan: " + plan + " Cuenta con el estado: Portabilidad Aprobada";
            }
            return mensaje;
        }

        public string tipoplansacar(int num)
        {
            TipoPlan obj = new TipoPlan(num);
            return obj.TipoPlan1;
        }
    }
}
