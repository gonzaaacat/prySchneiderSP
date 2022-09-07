namespace prySchneiderSP1
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.lblCliente2 = new System.Windows.Forms.Label();
            this.lblVendedor2 = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblNúmeroFactura = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gpFacturas = new System.Windows.Forms.GroupBox();
            this.gpIdentificadores = new System.Windows.Forms.GroupBox();
            this.gpFacturas.SuspendLayout();
            this.gpIdentificadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(453, 150);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 29);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(135, 73);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(60, 21);
            this.cbClientes.TabIndex = 14;
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(135, 100);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(60, 21);
            this.cbVendedor.TabIndex = 15;
            // 
            // lblCliente2
            // 
            this.lblCliente2.AutoSize = true;
            this.lblCliente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente2.Location = new System.Drawing.Point(6, 71);
            this.lblCliente2.Name = "lblCliente2";
            this.lblCliente2.Size = new System.Drawing.Size(89, 20);
            this.lblCliente2.TabIndex = 16;
            this.lblCliente2.Text = "ID Cliente";
            // 
            // lblVendedor2
            // 
            this.lblVendedor2.AutoSize = true;
            this.lblVendedor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor2.Location = new System.Drawing.Point(6, 98);
            this.lblVendedor2.Name = "lblVendedor2";
            this.lblVendedor2.Size = new System.Drawing.Size(111, 20);
            this.lblVendedor2.TabIndex = 17;
            this.lblVendedor2.Text = "ID Vendedor";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(6, 16);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(135, 20);
            this.lblTipoFactura.TabIndex = 18;
            this.lblTipoFactura.Text = "Tipo de Factura";
            // 
            // lblNúmeroFactura
            // 
            this.lblNúmeroFactura.AutoSize = true;
            this.lblNúmeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmeroFactura.Location = new System.Drawing.Point(6, 58);
            this.lblNúmeroFactura.Name = "lblNúmeroFactura";
            this.lblNúmeroFactura.Size = new System.Drawing.Size(163, 20);
            this.lblNúmeroFactura.TabIndex = 19;
            this.lblNúmeroFactura.Text = "Número de Factura";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(6, 98);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(59, 20);
            this.lblMonto.TabIndex = 20;
            this.lblMonto.Text = "Monto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 25;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(71, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha";
            // 
            // gpFacturas
            // 
            this.gpFacturas.Controls.Add(this.lblNúmeroFactura);
            this.gpFacturas.Controls.Add(this.textBox1);
            this.gpFacturas.Controls.Add(this.comboBox1);
            this.gpFacturas.Controls.Add(this.textBox2);
            this.gpFacturas.Controls.Add(this.lblTipoFactura);
            this.gpFacturas.Controls.Add(this.lblMonto);
            this.gpFacturas.Location = new System.Drawing.Point(3, 12);
            this.gpFacturas.Name = "gpFacturas";
            this.gpFacturas.Size = new System.Drawing.Size(285, 132);
            this.gpFacturas.TabIndex = 27;
            this.gpFacturas.TabStop = false;
            // 
            // gpIdentificadores
            // 
            this.gpIdentificadores.Controls.Add(this.lblFecha);
            this.gpIdentificadores.Controls.Add(this.dateTimePicker1);
            this.gpIdentificadores.Controls.Add(this.lblCliente2);
            this.gpIdentificadores.Controls.Add(this.cbClientes);
            this.gpIdentificadores.Controls.Add(this.lblVendedor2);
            this.gpIdentificadores.Controls.Add(this.cbVendedor);
            this.gpIdentificadores.Location = new System.Drawing.Point(312, 12);
            this.gpIdentificadores.Name = "gpIdentificadores";
            this.gpIdentificadores.Size = new System.Drawing.Size(225, 132);
            this.gpIdentificadores.TabIndex = 0;
            this.gpIdentificadores.TabStop = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 190);
            this.Controls.Add(this.gpIdentificadores);
            this.Controls.Add(this.gpFacturas);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gpFacturas.ResumeLayout(false);
            this.gpFacturas.PerformLayout();
            this.gpIdentificadores.ResumeLayout(false);
            this.gpIdentificadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label lblCliente2;
        private System.Windows.Forms.Label lblVendedor2;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblNúmeroFactura;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gpFacturas;
        private System.Windows.Forms.GroupBox gpIdentificadores;
    }
}