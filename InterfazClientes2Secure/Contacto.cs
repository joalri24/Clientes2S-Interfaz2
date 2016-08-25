using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazClientes2Secure
{
    class Contacto
    {
        // ------------------------------------------------------------------
        // Constantes
        // ------------------------------------------------------------------

        // ------------------------------------------------------------------
        // Atributos
        // ------------------------------------------------------------------

        public string Nombre;
        public string Cargo;
        public string Telefono;
        public string Celular;
        public string Correo;
        public string Notas;
        public DateTime UltimoContacto;


        // ------------------------------------------------------------------
        // Constructores
        // ------------------------------------------------------------------

        public Contacto()
        {
            UltimoContacto = DateTime.Now;
            Console.WriteLine(UltimoContacto);
        }

        // ------------------------------------------------------------------
        // Métodos
        // ------------------------------------------------------------------
    }
}
