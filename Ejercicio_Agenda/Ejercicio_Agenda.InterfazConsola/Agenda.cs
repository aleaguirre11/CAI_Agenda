using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agenda.InterfazConsola
{
    public class Agenda
    {
        public Agenda(string nombre, string tipo, int cantidadMaxima)
        {
            _nombreAgenda = nombre;
            _tipoAgenda = tipo;
            _cantidadMaxima = cantidadMaxima;
        }

        private string _nombreAgenda;
        private string _tipoAgenda;
        private int _cantidadMaxima;
     


        public string NombreAgenda
        {
            get
            {
                return _nombreAgenda;
            }
            set
            {
                _nombreAgenda = value;  
            }
        }

        public string Tipo
        {
            get
            {
                return _tipoAgenda;
            }
            set
            {
                _tipoAgenda = value;
            }
        }

        public int CantidadMaxima
        {
            get
            {
                return _cantidadMaxima; 
            }
        }
    }
}
