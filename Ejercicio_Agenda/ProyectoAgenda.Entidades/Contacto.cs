using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Entidades
{
    public class Contacto
    {
        //El constructor es el punto de acceso por donde se crea la instancia

        public Contacto(string nombre, string apellido, string telefono, string direccion, int edad)
        {
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            _edad = edad;
            _llamadas = 0;   
        }

        //atributo de clase
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private int _llamadas;
        private int _edad;

        

        //los metodos pueden ser de dos tipos: funcion o subrutina
        //Estos tipos se denominan firma, es la forma en la que se desarrolla
        //Una funcion devuelve algo y la subrutina no(void)
        //Copiar en cuaderno

        //atributos encapsulados -----> propiedades

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

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }
        
        public string Telefono
        {
            get
            {
                return _telefono;
            }
        }



        public int Llamadas
        {
            get
            {
                return _llamadas;    //------> Solo lectura(no tiene set)
            }
        }

        public int edad
        {
            get
            {
                return _edad;
            }
               
        }
            

    }
}
