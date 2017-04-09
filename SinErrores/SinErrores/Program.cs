using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinErrores
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var eva = new Practica_2013215462.Evaluacion();
            
            string respuesta = "";
            string anuncio = "";

            Console.WriteLine("Ingrese Numero: ");
            int numero = int.Parse(Console.ReadLine());

            string nombre = eva.verificacion(numero);

            if (nombre.Equals("No se encuentra registrado"))
            {
                Console.WriteLine("No se encuentra registrado, Ingresar un usuario registrado");
                
            }
            else
            {
                string almac = eva.verificatili(numero);
                Console.WriteLine("Usuario: " + nombre + "// Tipo de Linea:" + almac);
                

                Console.WriteLine("1. Evaluar Linea");
                respuesta = Console.ReadLine();

                if (respuesta.Equals("Evaluar"))
                {
                    respuesta = Console.ReadLine();


                    Console.WriteLine("Reporte: \n Usuario: " + nombre + "\n Linea: " + numero + "\n Tipo de Linea: " + almac);

                    if (almac.Equals("Post-Pago"))
                    {
                        Console.WriteLine("Iniciar Proceso de Evaluacion?: Si/No");
                        respuesta = Console.ReadLine();
                        if (respuesta.Equals("Si"))
                        {
                            string tipoplan = eva.tipoplansacar(numero);
                            anuncio = eva.evaluardos(tipoplan);
                            Console.WriteLine(anuncio);
                        }
                        else
                        {
                            Console.WriteLine("Evaluacion Declinada");
                        }

                    }
                    else
                    {
                        anuncio = "Los planes Pre-Pago no pueden acceder a la Promocion";
                    }
                    Console.WriteLine(anuncio);


                }

            }


            
            
        }
    }
}
