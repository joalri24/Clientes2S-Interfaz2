﻿using System;
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
    public partial class Cliente : UserControl
    {

        // ------------------------------------------------
        // Constantes
        // ------------------------------------------------

        // Tamaños para maximizar y minimizar
        private const int ALTURA_ORIGINAL = 355;
        private const int ALTURA_MINIMIZADO = 25;

        // Texto de los botones de cambio de estado
        private const string URGENTE = "Urgente";
        private const string ATENCION = "Atención";
        private const string NORMAL = "Normal";

        // ------------------------------------------------
        // Atributos
        // ------------------------------------------------

        // ------------------------------------------------
        // Constructor
        // ------------------------------------------------


        public Cliente()
        {
            InitializeComponent();
        }


        // ------------------------------------------------
        // Métodos
        // ------------------------------------------------

        /// <summary>
        /// Minimiza el control cuando se hace click en el boton correspondiente.
        /// Lo maximiza si ya se encuentra minimizado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minimizar(object sender, EventArgs e)
        {
            if (tabControlCliente.Visible)
            {
                tabControlCliente.Visible = false;
                this.Height = ALTURA_MINIMIZADO;
                toolStripButtonMinimizar.Text = "[+]";
                toolStripButtonMinimizar.ToolTipText = "Maximizar";               
            }
            else
            {
                tabControlCliente.Visible = true;
                this.Height = ALTURA_ORIGINAL;
                toolStripButtonMinimizar.Text = "[-]";
                toolStripButtonMinimizar.ToolTipText = "Minimizar";
            }
        }

        /// <summary>
        /// Cambia el estilo del borde cuando se hace click en el textbox.
        /// Activa un borde 3d.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.BorderStyle = BorderStyle.Fixed3D;
        }

        /// <summary>
        /// Cambia el estilo del borde cuando se le quita el foco al textbox.
        /// Queda sin ningún borde.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Actualiza el nombre de la empresa en la barra superior cuando
        /// se modifica el campo correspondiente dentro de la pestaña de 
        /// resumen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNombreCliente_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            toolStripLabelCliente.Text = textbox.Text;
        }

        /// <summary>
        /// Cambia el estado del cliente. En la interfaz el color de la
        /// barra donde aparece el nombre cambia de color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambiarEstado(object sender, EventArgs e)
        {
            ToolStripButton boton = sender as ToolStripButton;
            
            if (boton.Text == URGENTE)
            {
                // El color de la barra y de los botones no es el mismo para
                // evitar que estos últimos se confundan con el fondo.
                toolStripCliente.BackColor = Color.IndianRed;
                boton.BackColor = Color.Firebrick;
            }
            else if (boton.Text == ATENCION)
            {
                toolStripCliente.BackColor = Color.SandyBrown;
                boton.BackColor = Color.DarkOrange;
            }
            else if (boton.Text == NORMAL)
            {
                toolStripCliente.BackColor = Color.Gainsboro;
                boton.BackColor = Color.LightGray;
            }
        }

    }
}
