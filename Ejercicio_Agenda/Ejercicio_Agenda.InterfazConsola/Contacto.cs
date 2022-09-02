using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agenda.InterfazConsola
{
    public class Contacto
    {
        //El constructor es el punto de acceso por donde se crea la instancia

        public Contacto(string nombre)
        {
            _nombre = nombre;
            _llamadas = 0;
        }

        //atributo de clase
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private int _llamadas;

        

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

        public int Llamadas
        {
            get
            {
                return _llamadas;    //------> Solo lectura(no tiene set)
            }
        }

        //public int edad()
        //{

        //}
            

    }
}
