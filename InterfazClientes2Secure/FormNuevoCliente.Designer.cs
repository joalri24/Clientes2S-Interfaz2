namespace InterfazClientes2Secure
{
    partial class FormNuevoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelTipoAsociacion = new System.Windows.Forms.Label();
            this.radioButtonDirecto = new System.Windows.Forms.RadioButton();
            this.radioButtonIntermediario = new System.Windows.Forms.RadioButton();
            this.textBoxNombreContacto = new System.Windows.Forms.TextBox();
            this.labelNombreContacto = new System.Windows.Forms.Label();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.radioButtonIntermediario);
            this.groupBoxInfo.Controls.Add(this.radioButtonDirecto);
            this.groupBoxInfo.Controls.Add(this.labelTipoAsociacion);
            this.groupBoxInfo.Controls.Add(this.textBoxNombreCliente);
            this.groupBoxInfo.Controls.Add(this.labelNombreCliente);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.Brown;
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(345, 166);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Información Empresa";
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.Controls.Add(this.textBoxCorreo);
            this.groupBoxContacto.Controls.Add(this.labelCorreo);
            this.groupBoxContacto.Controls.Add(this.textBoxTelefono);
            this.groupBoxContacto.Controls.Add(this.labelTelefono);
            this.groupBoxContacto.Controls.Add(this.textBoxCargo);
            this.groupBoxContacto.Controls.Add(this.labelCargo);
            this.groupBoxContacto.Controls.Add(this.buttonSeleccionar);
            this.groupBoxContacto.Controls.Add(this.textBoxNombreContacto);
            this.groupBoxContacto.Controls.Add(this.labelNombreContacto);
            this.groupBoxContacto.ForeColor = System.Drawing.Color.Brown;
            this.groupBoxContacto.Location = new System.Drawing.Point(363, 12);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(350, 166);
            this.groupBoxContacto.TabIndex = 1;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Contacto Principal (opcional)";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(638, 184);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAceptar.Location = new System.Drawing.Point(557, 184);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(7, 33);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(66, 18);
            this.labelNombreCliente.TabIndex = 0;
            this.labelNombreCliente.Text = "Nombre:";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCliente.Location = new System.Drawing.Point(79, 30);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(260, 24);
            this.textBoxNombreCliente.TabIndex = 1;
            // 
            // labelTipoAsociacion
            // 
            this.labelTipoAsociacion.AutoSize = true;
            this.labelTipoAsociacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoAsociacion.Location = new System.Drawing.Point(7, 89);
            this.labelTipoAsociacion.Name = "labelTipoAsociacion";
            this.labelTipoAsociacion.Size = new System.Drawing.Size(137, 18);
            this.labelTipoAsociacion.TabIndex = 2;
            this.labelTipoAsociacion.Text = "Tipo de asociación:";
            // 
            // radioButtonDirecto
            // 
            this.radioButtonDirecto.AutoSize = true;
            this.radioButtonDirecto.Checked = true;
            this.radioButtonDirecto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonDirecto.Location = new System.Drawing.Point(10, 118);
            this.radioButtonDirecto.Name = "radioButtonDirecto";
            this.radioButtonDirecto.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDirecto.TabIndex = 3;
            this.radioButtonDirecto.TabStop = true;
            this.radioButtonDirecto.Text = "Directo";
            this.radioButtonDirecto.UseVisualStyleBackColor = true;
            // 
            // radioButtonIntermediario
            // 
            this.radioButtonIntermediario.AutoSize = true;
            this.radioButtonIntermediario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonIntermediario.Location = new System.Drawing.Point(122, 118);
            this.radioButtonIntermediario.Name = "radioButtonIntermediario";
            this.radioButtonIntermediario.Size = new System.Drawing.Size(103, 17);
            this.radioButtonIntermediario.TabIndex = 4;
            this.radioButtonIntermediario.Text = "Por intermediario";
            this.radioButtonIntermediario.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreContacto
            // 
            this.textBoxNombreContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreContacto.Location = new System.Drawing.Point(82, 30);
            this.textBoxNombreContacto.Name = "textBoxNombreContacto";
            this.textBoxNombreContacto.Size = new System.Drawing.Size(232, 24);
            this.textBoxNombreContacto.TabIndex = 3;
            // 
            // labelNombreContacto
            // 
            this.labelNombreContacto.AutoSize = true;
            this.labelNombreContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreContacto.Location = new System.Drawing.Point(6, 33);
            this.labelNombreContacto.Name = "labelNombreContacto";
            this.labelNombreContacto.Size = new System.Drawing.Size(66, 18);
            this.labelNombreContacto.TabIndex = 2;
            this.labelNombreContacto.Text = "Nombre:";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(320, 30);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(25, 25);
            this.buttonSeleccionar.TabIndex = 4;
            this.buttonSeleccionar.Text = "...";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargo.Location = new System.Drawing.Point(82, 60);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(232, 24);
            this.textBoxCargo.TabIndex = 6;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.Location = new System.Drawing.Point(6, 63);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(53, 18);
            this.labelCargo.TabIndex = 5;
            this.labelCargo.Text = "Cargo:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(82, 89);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(232, 24);
            this.textBoxTelefono.TabIndex = 8;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(6, 92);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(70, 18);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "Télefono:";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(82, 118);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(232, 24);
            this.textBoxCorreo.TabIndex = 10;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(6, 121);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(59, 18);
            this.labelCorreo.TabIndex = 9;
            this.labelCorreo.Text = "Correo:";
            // 
            // FormNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 216);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBoxContacto);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "FormNuevoCliente";
            this.Text = "2Secure Clientes - Añadir nuevo usuario";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxContacto.ResumeLayout(false);
            this.groupBoxContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.RadioButton radioButtonIntermediario;
        private System.Windows.Forms.RadioButton radioButtonDirecto;
        private System.Windows.Forms.Label labelTipoAsociacion;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.TextBox textBoxNombreContacto;
        private System.Windows.Forms.Label labelNombreContacto;
    }
}