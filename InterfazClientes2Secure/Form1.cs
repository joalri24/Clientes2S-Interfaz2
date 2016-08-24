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
    public partial class Form1 : Form
    {

        // ------------------------------------------------
        // Constantes
        // ------------------------------------------------

        // ------------------------------------------------
        // Atributos
        // ------------------------------------------------

        private bool vacio;

        // ------------------------------------------------
        // Constructor
        // ------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            vacio = true;
        }


        // ------------------------------------------------
        // Métodos
        // ------------------------------------------------

        /// <summary>
        /// TODO Borrar. Atajo para crear nuevos clientes.
        /// </summary>
        private void newToolStripButton_Click(object sender, EventArgs e)
        {           
            TableLayoutPanel tablaFondo = tableLayoutClientes;
            if (vacio)
                vacio = false;
            else
                tablaFondo.RowCount++;

            tablaFondo.Controls.Add(new ClienteControl(), 0, tablaFondo.RowCount - 1);
            //Console.WriteLine("Rows: " + tablaFondo.RowCount);
        }

        /// <summary>
        /// Crear nuevo cliente cuando se hace click en el botón correspondiente.
        /// </summary>
        private void CrearCliente(object sender, EventArgs e)
        {
            FormNuevoCliente dialogo = new FormNuevoCliente();

            // Abre una ventana de dialogo para obtener la información del nuevo cliente.
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                TableLayoutPanel tablaFondo = tableLayoutClientes;
                ClienteControl controlCliente = new ClienteControl(dialogo.darNombreCliente());


                if (vacio)
                    vacio = false;
                else
                    tablaFondo.RowCount++;

                tablaFondo.Controls.Add(controlCliente, 0, tablaFondo.RowCount - 1);
            }           
            
        }
    }
}
