using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazClientes2Secure
{
    public partial class ContactoControl : UserControl
    {

        // ------------------------------------------------------------------
        // Constantes
        // ------------------------------------------------------------------

        // Tamaños para maximizar y minimizar
        private const int ALTURA_ORIGINAL = 285;
        private const int ALTURA_MINIMIZADO = 25;


        // ------------------------------------------------------------------
        // Atributos
        // ------------------------------------------------------------------

        // ------------------------------------------------------------------
        // Constructor
        // ------------------------------------------------------------------

        public ContactoControl()
        {
            InitializeComponent();
        }


        // ------------------------------------------------------------------
        // Métodos
        // ------------------------------------------------------------------

        /// <summary>
        /// Minimiza el control cuando se hace click en el boton correspondiente.
        /// Lo maximiza si ya se encuentra minimizado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minimizar(object sender, EventArgs e)
        {
            if (splitContainerContacto.Visible)
            {
                splitContainerContacto.Visible = false;
                this.Height = ALTURA_MINIMIZADO;
                toolStripButtonMinimizarContacto.Text = "[+]";
                toolStripButtonMinimizarContacto.ToolTipText = "Maximizar";
            }
            else
            {
                splitContainerContacto.Visible = true;
                this.Height = ALTURA_ORIGINAL;
                toolStripButtonMinimizarContacto.Text = "[-]";
                toolStripButtonMinimizarContacto.ToolTipText = "Minimizar";
            }
        }
    }
}
