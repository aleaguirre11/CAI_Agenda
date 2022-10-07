using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgenda.Entidades;

namespace Ejercicio_Agenda.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contacto c1 = new Contacto("Alexis", "Aguirre", "2523", "Ignacio Canal 869", 22);
            Contacto c2 = new Contacto("Suyai", "Gonzales","2233", "Av Cabildo", 25);
            Contacto c3 = new Contacto("Ariel", "Perez", "1234", "Av Santa Fe", 32);

            try
            {
                Agenda agendaElectronica = new Agenda("Mi Agenda");
                agendaElectronica.AgregarContacto(c1);
                agendaElectronica.AgregarContacto(c2);
                agendaElectronica.AgregarContacto(c3);

                
                    bool consolaActiva = true;

                while(consolaActiva)
                {
                    DesplegarOpcionesMenu();
                    string opcionMenu = Console.ReadLine();

                    switch(opcionMenu)
                    {
                        case "1":
                            Listar(agendaElectronica);
                            break;

                        case "2":
                            Agregar(agendaElectronica);
                            break;

                        case "3":
                            eliminarContacto(agendaElectronica);
                            break;
                        case "4":
                            Llamar(agendaElectronica);
                            break;
                        case "x":
                            consolaActiva = false;
                            break;

                            default:
                            break;
   
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general");
            }
        }

        public static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1- Mostrar lista de contactos. " + "\n" + "2- Agregar contacto. " + "\n" + "3- Eliminar contacto. " + "\n" + "4- Llamar");
        }

        public static void Listar(Agenda agenda)
        {
            foreach(Contacto c in agenda.Contactos)
            {
                Console.WriteLine(c.Nombre + " - " + c.Telefono + " - " + c.Llamadas);
            }
        }

        public static void Agregar(Agenda agendaElectronica)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese un apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese un telefono: ");
            string telefono = Console.ReadLine();

            Console.WriteLine("Ingrese una direccion: ");
            string direccion = Console.ReadLine();

            Console.WriteLine("Ingrese la edad: ");
            int edad = Convert.ToByte(Console.ReadLine());
            

            Contacto c1 = new Contacto(nombre, apellido, telefono, direccion, edad);
            agendaElectronica.AgregarContacto(c1);
        }

        public static void eliminarContacto(Agenda agendaElectronica)
        { 
            Console.WriteLine("Ingrese el telefono del contacto a eliminar: ");
            string telefono = Console.ReadLine();

            agendaElectronica.EliminarContacto(telefono);   
        }

        //public static void Traer(Agenda agendaElectronica)
        //{
            //agendaElectronica.TraerContactoFrecuente();
        //}

        public static void Llamar(Agenda agendaElectronica)
        {
            Console.WriteLine("Ingrese el nombre del contacto a llamar: ");
            string nombre = Console.ReadLine();

            agendaElectronica.LlamarContacto(nombre);
        }
    }
}
