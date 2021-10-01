
namespace _02EdicionDatos
{
    partial class EdicionDatos
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
            this.laEuros = new System.Windows.Forms.Label();
            this.laPesetas = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnIntroducirDatos = new System.Windows.Forms.Button();
            this.tbEuros = new System.Windows.Forms.TextBox();
            this.tbPesetas = new System.Windows.Forms.TextBox();
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
            // 
            // btnIntroducirDatos
            // 
            this.btnIntroducirDatos.Location = new System.Drawing.Point(734, 98);
            this.btnIntroducirDatos.Name = "btnIntroducirDatos";
            this.btnIntroducirDatos.Size = new System.Drawing.Size(116, 23);
            this.btnIntroducirDatos.TabIndex = 4;
            this.btnIntroducirDatos.Text = "Introduce Datos";
            this.btnIntroducirDatos.UseVisualStyleBackColor = true;
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
            // EdicionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 608);
            this.Controls.Add(this.tbPesetas);
            this.Controls.Add(this.tbEuros);
            this.Controls.Add(this.btnIntroducirDatos);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.laPesetas);
            this.Controls.Add(this.laEuros);
            this.Name = "EdicionDatos";
            this.Text = "Form1";
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
    }
}

