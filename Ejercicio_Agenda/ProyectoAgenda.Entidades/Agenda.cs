using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Entidades
{
    public class Agenda
    {
        private string _nombre;
        private List<Contacto> _contactos;
        private int _cantidadMaxima;

        public Agenda(string nombre)
        {
            _nombre = nombre;
            //Se inicializa _contactos para que en el metodo AgregarContacto no lo tome como nulo
            _contactos = new List<Contacto>();
            _cantidadMaxima = 50;
        }
     

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;  
            }
        }

        public List<Contacto> Contactos
        {
            get
            {
                return _contactos;
            }
        }

        public int CantidadMaxima
        {
            get
            {
                return _cantidadMaxima;
            }

        }
        public void AgregarContacto(Contacto contacto)
        {
            //valido que el contacto no exista. REGLA DE NEGOCIO: NO TELEFONOS REPETIDOS
            bool permitoAgregar = true;
            foreach (Contacto c in _contactos)
            {
                if (c.Telefono == contacto.Telefono)
                    permitoAgregar = false;
           
            }
            if(permitoAgregar)
            _contactos.Add(contacto);
        }

        public void EliminarContacto(string telefono)
        {
            foreach (Contacto c in Contactos)

            {
                if (c.Telefono == telefono)
                {
                    Contactos.Remove(c);
                    Console.WriteLine("Contacto eliminado.");
                }

                else
                {
                    Console.WriteLine("No se encuentra el contacto.");
                }
            }
        }

        //public Contacto TraerContactoFrecuente()
        //{
            //foreach (Contacto c in Contactos)
            //{

           // }
        //}

        public void LlamarContacto (string nombre)
        {
            foreach(Contacto c in Contactos)
            {
                if(c.Nombre == nombre)
                {
                    c.Llamar();
                }
            }
        }
    }
}
