namespace EjercicioComplementario4
{
    partial class Form1
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.cmbMonedaDestino = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(87, 119);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // cmbMonedaOrigen
            // 
            this.cmbMonedaOrigen.FormattingEnabled = true;
            this.cmbMonedaOrigen.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "JPY",
            "GBP",
            "CHF"});
            this.cmbMonedaOrigen.Location = new System.Drawing.Point(87, 198);
            this.cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            this.cmbMonedaOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaOrigen.TabIndex = 1;
            this.cmbMonedaOrigen.Text = " moneda de entrada";
            // 
            // cmbMonedaDestino
            // 
            this.cmbMonedaDestino.FormattingEnabled = true;
            this.cmbMonedaDestino.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "JPY",
            "GBP",
            "CHF"});
            this.cmbMonedaDestino.Location = new System.Drawing.Point(303, 197);
            this.cmbMonedaDestino.Name = "cmbMonedaDestino";
            this.cmbMonedaDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaDestino.TabIndex = 2;
            this.cmbMonedaDestino.Text = "Convertir a";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(303, 119);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(172, 282);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(456, 118);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbMonedaDestino);
            this.Controls.Add(this.cmbMonedaOrigen);
            this.Controls.Add(this.txtCantidad);
            this.Name = "Form1";
            this.Text = "Convertidor de Monedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbMonedaOrigen;
        private System.Windows.Forms.ComboBox cmbMonedaDestino;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSalir;
    }
}

