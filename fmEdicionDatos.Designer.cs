
namespace _02EdicionDatos
{
    partial class fmEdicionDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEdicionDatos));
            this.laEuros = new System.Windows.Forms.Label();
            this.laPesetas = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnIntroducirDatos = new System.Windows.Forms.Button();
            this.tbEuros = new System.Windows.Forms.TextBox();
            this.tbPesetas = new System.Windows.Forms.TextBox();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.laCodigoPostal = new System.Windows.Forms.Label();
            this.laCodigoPostalFijo = new System.Windows.Forms.Label();
            this.laDniCif = new System.Windows.Forms.Label();
            this.laLocalidad = new System.Windows.Forms.Label();
            this.laTelefono = new System.Windows.Forms.Label();
            this.laDniCifFijo = new System.Windows.Forms.Label();
            this.laLocalidadFijo = new System.Windows.Forms.Label();
            this.laTelefonoFijo = new System.Windows.Forms.Label();
            this.laEmail = new System.Windows.Forms.Label();
            this.laDireccion = new System.Windows.Forms.Label();
            this.laNombre = new System.Windows.Forms.Label();
            this.laEmailFijo = new System.Windows.Forms.Label();
            this.laDireccionFijo = new System.Windows.Forms.Label();
            this.laNombreFijo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombrePrincipal = new System.Windows.Forms.TextBox();
            this.pnDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // laEuros
            // 
            this.laEuros.AutoSize = true;
            this.laEuros.Location = new System.Drawing.Point(111, 43);
            this.laEuros.Name = "laEuros";
            this.laEuros.Size = new System.Drawing.Size(34, 13);
            this.laEuros.TabIndex = 0;
            this.laEuros.Text = "Euros";
            // 
            // laPesetas
            // 
            this.laPesetas.AutoSize = true;
            this.laPesetas.Location = new System.Drawing.Point(231, 43);
            this.laPesetas.Name = "laPesetas";
            this.laPesetas.Size = new System.Drawing.Size(45, 13);
            this.laPesetas.TabIndex = 1;
            this.laPesetas.Text = "Pesetas";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Enabled = false;
            this.btnCambiar.Location = new System.Drawing.Point(157, 99);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 2;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Location = new System.Drawing.Point(754, 32);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(75, 23);
            this.btnAcercaDe.TabIndex = 3;
            this.btnAcercaDe.Text = "Acerca de ...";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnIntroducirDatos
            // 
            this.btnIntroducirDatos.Location = new System.Drawing.Point(734, 98);
            this.btnIntroducirDatos.Name = "btnIntroducirDatos";
            this.btnIntroducirDatos.Size = new System.Drawing.Size(116, 23);
            this.btnIntroducirDatos.TabIndex = 4;
            this.btnIntroducirDatos.Text = "Introduce Datos";
            this.btnIntroducirDatos.UseVisualStyleBackColor = true;
            this.btnIntroducirDatos.Click += new System.EventHandler(this.btnIntroducirDatos_Click);
            // 
            // tbEuros
            // 
            this.tbEuros.Location = new System.Drawing.Point(88, 59);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(100, 20);
            this.tbEuros.TabIndex = 5;
            this.tbEuros.Text = "0";
            this.tbEuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEuros.Click += new System.EventHandler(this.tbPesetas_Click);
            this.tbEuros.TextChanged += new System.EventHandler(this.tbEuros_TextChanged);
            this.tbEuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuros_KeyPress);
            // 
            // tbPesetas
            // 
            this.tbPesetas.Location = new System.Drawing.Point(209, 59);
            this.tbPesetas.Name = "tbPesetas";
            this.tbPesetas.Size = new System.Drawing.Size(100, 20);
            this.tbPesetas.TabIndex = 6;
            this.tbPesetas.Text = "0";
            this.tbPesetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPesetas.Click += new System.EventHandler(this.tbPesetas_Click);
            this.tbPesetas.TextChanged += new System.EventHandler(this.tbEuros_TextChanged);
            this.tbPesetas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuros_KeyPress);
            // 
            // pnDatos
            // 
            this.pnDatos.Controls.Add(this.tbNombrePrincipal);
            this.pnDatos.Controls.Add(this.laCodigoPostal);
            this.pnDatos.Controls.Add(this.laCodigoPostalFijo);
            this.pnDatos.Controls.Add(this.laDniCif);
            this.pnDatos.Controls.Add(this.laLocalidad);
            this.pnDatos.Controls.Add(this.laTelefono);
            this.pnDatos.Controls.Add(this.laDniCifFijo);
            this.pnDatos.Controls.Add(this.laLocalidadFijo);
            this.pnDatos.Controls.Add(this.laTelefonoFijo);
            this.pnDatos.Controls.Add(this.laEmail);
            this.pnDatos.Controls.Add(this.laDireccion);
            this.pnDatos.Controls.Add(this.laNombre);
            this.pnDatos.Controls.Add(this.laEmailFijo);
            this.pnDatos.Controls.Add(this.laDireccionFijo);
            this.pnDatos.Controls.Add(this.laNombreFijo);
            this.pnDatos.Controls.Add(this.label1);
            this.pnDatos.Location = new System.Drawing.Point(-1, 307);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(886, 302);
            this.pnDatos.TabIndex = 7;
            this.pnDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDatos_Paint);
            // 
            // laCodigoPostal
            // 
            this.laCodigoPostal.AutoSize = true;
            this.laCodigoPostal.Location = new System.Drawing.Point(727, 164);
            this.laCodigoPostal.Name = "laCodigoPostal";
            this.laCodigoPostal.Size = new System.Drawing.Size(41, 13);
            this.laCodigoPostal.TabIndex = 14;
            this.laCodigoPostal.Text = "label15";
            // 
            // laCodigoPostalFijo
            // 
            this.laCodigoPostalFijo.AutoSize = true;
            this.laCodigoPostalFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCodigoPostalFijo.Location = new System.Drawing.Point(587, 162);
            this.laCodigoPostalFijo.Name = "laCodigoPostalFijo";
            this.laCodigoPostalFijo.Size = new System.Drawing.Size(108, 17);
            this.laCodigoPostalFijo.TabIndex = 13;
            this.laCodigoPostalFijo.Text = "Codigo Postal";
            // 
            // laDniCif
            // 
            this.laDniCif.AutoSize = true;
            this.laDniCif.Location = new System.Drawing.Point(441, 235);
            this.laDniCif.Name = "laDniCif";
            this.laDniCif.Size = new System.Drawing.Size(41, 13);
            this.laDniCif.TabIndex = 12;
            this.laDniCif.Text = "label13";
            // 
            // laLocalidad
            // 
            this.laLocalidad.AutoSize = true;
            this.laLocalidad.Location = new System.Drawing.Point(441, 164);
            this.laLocalidad.Name = "laLocalidad";
            this.laLocalidad.Size = new System.Drawing.Size(41, 13);
            this.laLocalidad.TabIndex = 11;
            this.laLocalidad.Text = "label12";
            // 
            // laTelefono
            // 
            this.laTelefono.AutoSize = true;
            this.laTelefono.Location = new System.Drawing.Point(441, 98);
            this.laTelefono.Name = "laTelefono";
            this.laTelefono.Size = new System.Drawing.Size(41, 13);
            this.laTelefono.TabIndex = 10;
            this.laTelefono.Text = "label11";
            // 
            // laDniCifFijo
            // 
            this.laDniCifFijo.AutoSize = true;
            this.laDniCifFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDniCifFijo.Location = new System.Drawing.Point(331, 233);
            this.laDniCifFijo.Name = "laDniCifFijo";
            this.laDniCifFijo.Size = new System.Drawing.Size(62, 17);
            this.laDniCifFijo.TabIndex = 9;
            this.laDniCifFijo.Text = "DNI/CIF";
            // 
            // laLocalidadFijo
            // 
            this.laLocalidadFijo.AutoSize = true;
            this.laLocalidadFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLocalidadFijo.Location = new System.Drawing.Point(331, 162);
            this.laLocalidadFijo.Name = "laLocalidadFijo";
            this.laLocalidadFijo.Size = new System.Drawing.Size(78, 17);
            this.laLocalidadFijo.TabIndex = 8;
            this.laLocalidadFijo.Text = "Localidad";
            // 
            // laTelefonoFijo
            // 
            this.laTelefonoFijo.AutoSize = true;
            this.laTelefonoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTelefonoFijo.Location = new System.Drawing.Point(331, 96);
            this.laTelefonoFijo.Name = "laTelefonoFijo";
            this.laTelefonoFijo.Size = new System.Drawing.Size(72, 17);
            this.laTelefonoFijo.TabIndex = 7;
            this.laTelefonoFijo.Text = "Telefono";
            // 
            // laEmail
            // 
            this.laEmail.AutoSize = true;
            this.laEmail.Location = new System.Drawing.Point(225, 235);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(35, 13);
            this.laEmail.TabIndex = 6;
            this.laEmail.Text = "label7";
            // 
            // laDireccion
            // 
            this.laDireccion.AutoSize = true;
            this.laDireccion.Location = new System.Drawing.Point(225, 164);
            this.laDireccion.Name = "laDireccion";
            this.laDireccion.Size = new System.Drawing.Size(35, 13);
            this.laDireccion.TabIndex = 5;
            this.laDireccion.Text = "label6";
            // 
            // laNombre
            // 
            this.laNombre.AutoSize = true;
            this.laNombre.Location = new System.Drawing.Point(225, 98);
            this.laNombre.Name = "laNombre";
            this.laNombre.Size = new System.Drawing.Size(35, 13);
            this.laNombre.TabIndex = 4;
            this.laNombre.Text = "label5";
            // 
            // laEmailFijo
            // 
            this.laEmailFijo.AutoSize = true;
            this.laEmailFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEmailFijo.Location = new System.Drawing.Point(134, 233);
            this.laEmailFijo.Name = "laEmailFijo";
            this.laEmailFijo.Size = new System.Drawing.Size(47, 17);
            this.laEmailFijo.TabIndex = 3;
            this.laEmailFijo.Text = "Email";
            // 
            // laDireccionFijo
            // 
            this.laDireccionFijo.AutoSize = true;
            this.laDireccionFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDireccionFijo.Location = new System.Drawing.Point(134, 162);
            this.laDireccionFijo.Name = "laDireccionFijo";
            this.laDireccionFijo.Size = new System.Drawing.Size(76, 17);
            this.laDireccionFijo.TabIndex = 2;
            this.laDireccionFijo.Text = "Direccion";
            // 
            // laNombreFijo
            // 
            this.laNombreFijo.AutoSize = true;
            this.laNombreFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNombreFijo.Location = new System.Drawing.Point(134, 96);
            this.laNombreFijo.Name = "laNombreFijo";
            this.laNombreFijo.Size = new System.Drawing.Size(64, 17);
            this.laNombreFijo.TabIndex = 1;
            this.laNombreFijo.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOS DATOS INTRODUCIDOS SON:";
            // 
            // tbNombrePrincipal
            // 
            this.tbNombrePrincipal.Location = new System.Drawing.Point(160, 24);
            this.tbNombrePrincipal.Name = "tbNombrePrincipal";
            this.tbNombrePrincipal.ReadOnly = true;
            this.tbNombrePrincipal.Size = new System.Drawing.Size(100, 20);
            this.tbNombrePrincipal.TabIndex = 15;
            // 
            // fmEdicionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 608);
            this.Controls.Add(this.pnDatos);
            this.Controls.Add(this.tbPesetas);
            this.Controls.Add(this.tbEuros);
            this.Controls.Add(this.btnIntroducirDatos);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.laPesetas);
            this.Controls.Add(this.laEuros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmEdicionDatos";
            this.Text = "Edicion Datos";
            this.Load += new System.EventHandler(this.fmEdicionDatos_Load);
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laEuros;
        private System.Windows.Forms.Label laPesetas;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnIntroducirDatos;
        private System.Windows.Forms.TextBox tbEuros;
        private System.Windows.Forms.TextBox tbPesetas;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.Label laCodigoPostal;
        private System.Windows.Forms.Label laCodigoPostalFijo;
        private System.Windows.Forms.Label laDniCif;
        private System.Windows.Forms.Label laLocalidad;
        private System.Windows.Forms.Label laTelefono;
        private System.Windows.Forms.Label laDniCifFijo;
        private System.Windows.Forms.Label laLocalidadFijo;
        private System.Windows.Forms.Label laTelefonoFijo;
        private System.Windows.Forms.Label laEmail;
        private System.Windows.Forms.Label laDireccion;
        private System.Windows.Forms.Label laNombre;
        private System.Windows.Forms.Label laEmailFijo;
        private System.Windows.Forms.Label laDireccionFijo;
        private System.Windows.Forms.Label laNombreFijo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombrePrincipal;
    }
}

