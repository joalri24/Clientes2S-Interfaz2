using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazClientes2Secure
{
    public class Tarea
    {
        // ------------------------------------------------------------------
        // Constantes
        // ------------------------------------------------------------------

        // ------------------------------------------------------------------
        // Atributos
        // ------------------------------------------------------------------

        public string Nombre;
        public string Descripcion;
        public DateTime fecha;


        // ------------------------------------------------------------------
        // Constructores
        // ------------------------------------------------------------------

        public Tarea ()
        {

        }

        public Tarea(string nombre)
        {
            Nombre = nombre;
        }

        // ------------------------------------------------------------------
        // Métodos
        // ------------------------------------------------------------------

    }
}
