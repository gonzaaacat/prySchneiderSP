namespace prySchneiderSP1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mspRegistro = new System.Windows.Forms.MenuStrip();
            this.registróToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mspRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mspRegistro
            // 
            this.mspRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registróToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mspRegistro.Location = new System.Drawing.Point(0, 0);
            this.mspRegistro.Name = "mspRegistro";
            this.mspRegistro.Size = new System.Drawing.Size(249, 24);
            this.mspRegistro.TabIndex = 0;
            this.mspRegistro.Text = "mspRegistro";
            // 
            // registróToolStripMenuItem
            // 
            this.registróToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClienteToolStripMenuItem,
            this.registroDeVendedorToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.registróToolStripMenuItem.Name = "registróToolStripMenuItem";
            this.registróToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registróToolStripMenuItem.Text = "Registro";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salirToolStripMenuItem.Text = "Salir...";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeClienteToolStripMenuItem.Text = "Cliente";
            this.registroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.registroDeClienteToolStripMenuItem_Click);
            // 
            // registroDeVendedorToolStripMenuItem
            // 
            this.registroDeVendedorToolStripMenuItem.Name = "registroDeVendedorToolStripMenuItem";
            this.registroDeVendedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeVendedorToolStripMenuItem.Text = "Vendedor";
            this.registroDeVendedorToolStripMenuItem.Click += new System.EventHandler(this.registroDeVendedorToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 86);
            this.Controls.Add(this.mspRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspRegistro;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ven Kaktus";
            this.mspRegistro.ResumeLayout(false);
            this.mspRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspRegistro;
        private System.Windows.Forms.ToolStripMenuItem registróToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

