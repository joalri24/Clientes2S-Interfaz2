using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazClientes2Secure
{
    /// <summary>
    /// Formulario que despliega un dialogo de entrada de información 
    /// cuando se va a crear un nuevo cliente.
    /// </summary>
    public partial class FormNuevoCliente : Form
    {
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------
        // Métodos
        // ------------------------------------------------------------------

        /// <summary>
        /// Activa el botón de aceptar cuando el campo del nombre no está vacío.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNombreCliente_TextChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = (textBoxNombreCliente.Text == "")? false:true; 
        }

        public String darNombreCliente()
        {
            return textBoxNombreCliente.Text;
        }

        public String darTipoAsociacion()
        {
            string respuesta = "Directo";

            if (radioButtonIntermediario.Checked)
                respuesta = radioButtonIntermediario.Text;

            return respuesta;
        }

    }
}
