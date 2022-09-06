using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agenda.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contacto c1 = new Contacto("Alexis", "Aguirre", "2523", "Ignacio Canal 869", 22);
            Contacto c2 = new Contacto("Suyai", "Gonzales","2233", "Av Cabildo", 25);
            Contacto c3 = new Contacto("Ariel", "Perez", "1234", "Av Santa Fe", 32);
        }
    }
}
