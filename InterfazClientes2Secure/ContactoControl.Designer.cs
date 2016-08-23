namespace InterfazClientes2Secure
{
    partial class ContactoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactoControl));
            this.toolStripContacto = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonMinimizarContacto = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelContacto = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonEliminarContacto = new System.Windows.Forms.ToolStripButton();
            this.splitContainerContacto = new System.Windows.Forms.SplitContainer();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxOtros = new System.Windows.Forms.GroupBox();
            this.toolStripContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContacto)).BeginInit();
            this.splitContainerContacto.Panel1.SuspendLayout();
            this.splitContainerContacto.Panel2.SuspendLayout();
            this.splitContainerContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContacto
            // 
            this.toolStripContacto.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripContacto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMinimizarContacto,
            this.toolStripLabelContacto,
            this.toolStripButtonEliminarContacto});
            this.toolStripContacto.Location = new System.Drawing.Point(0, 0);
            this.toolStripContacto.Name = "toolStripContacto";
            this.toolStripContacto.Size = new System.Drawing.Size(902, 25);
            this.toolStripContacto.TabIndex = 2;
            this.toolStripContacto.Text = "Empresa Pepito";
            // 
            // toolStripButtonMinimizarContacto
            // 
            this.toolStripButtonMinimizarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMinimizarContacto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripButtonMinimizarContacto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMinimizarContacto.Image")));
            this.toolStripButtonMinimizarContacto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMinimizarContacto.Name = "toolStripButtonMinimizarContacto";
            this.toolStripButtonMinimizarContacto.Size = new System.Drawing.Size(24, 22);
            this.toolStripButtonMinimizarContacto.Text = "[-]";
            this.toolStripButtonMinimizarContacto.ToolTipText = "Minimizar";
            // 
            // toolStripLabelContacto
            // 
            this.toolStripLabelContacto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelContacto.Name = "toolStripLabelContacto";
            this.toolStripLabelContacto.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabelContacto.Text = "Pepito Pérez";
            // 
            // toolStripButtonEliminarContacto
            // 
            this.toolStripButtonEliminarContacto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonEliminarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEliminarContacto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButtonEliminarContacto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminarContacto.Image")));
            this.toolStripButtonEliminarContacto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminarContacto.Name = "toolStripButtonEliminarContacto";
            this.toolStripButtonEliminarContacto.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEliminarContacto.Text = "X";
            // 
            // splitContainerContacto
            // 
            this.splitContainerContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerContacto.Location = new System.Drawing.Point(0, 25);
            this.splitContainerContacto.Name = "splitContainerContacto";
            // 
            // splitContainerContacto.Panel1
            // 
            this.splitContainerContacto.Panel1.Controls.Add(this.groupBoxInfo);
            // 
            // splitContainerContacto.Panel2
            // 
            this.splitContainerContacto.Panel2.Controls.Add(this.groupBoxOtros);
            this.splitContainerContacto.Size = new System.Drawing.Size(902, 260);
            this.splitContainerContacto.SplitterDistance = 434;
            this.splitContainerContacto.TabIndex = 3;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfo.ForeColor = System.Drawing.Color.Brown;
            this.groupBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(434, 260);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Contacto";
            // 
            // groupBoxOtros
            // 
            this.groupBoxOtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOtros.ForeColor = System.Drawing.Color.Brown;
            this.groupBoxOtros.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOtros.Name = "groupBoxOtros";
            this.groupBoxOtros.Size = new System.Drawing.Size(464, 260);
            this.groupBoxOtros.TabIndex = 0;
            this.groupBoxOtros.TabStop = false;
            this.groupBoxOtros.Text = "Otros";
            // 
            // ContactoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerContacto);
            this.Controls.Add(this.toolStripContacto);
            this.Name = "ContactoControl";
            this.Size = new System.Drawing.Size(902, 285);
            this.toolStripContacto.ResumeLayout(false);
            this.toolStripContacto.PerformLayout();
            this.splitContainerContacto.Panel1.ResumeLayout(false);
            this.splitContainerContacto.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContacto)).EndInit();
            this.splitContainerContacto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripContacto;
        private System.Windows.Forms.ToolStripButton toolStripButtonMinimizarContacto;
        private System.Windows.Forms.ToolStripLabel toolStripLabelContacto;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminarContacto;
        private System.Windows.Forms.SplitContainer splitContainerContacto;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxOtros;
    }
}
