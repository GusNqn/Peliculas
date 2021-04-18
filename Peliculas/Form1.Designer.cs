
namespace Películas
{
    partial class fPeliculas
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
            this.bAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tPeliculas = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bListar = new System.Windows.Forms.Button();
            this.lCantidad = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(70, 55);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.Text = "&Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            // 
            // tPeliculas
            // 
            this.tPeliculas.Location = new System.Drawing.Point(70, 29);
            this.tPeliculas.Name = "tPeliculas";
            this.tPeliculas.Size = new System.Drawing.Size(237, 20);
            this.tPeliculas.TabIndex = 2;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(151, 55);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 0;
            this.bBuscar.Text = "&Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(232, 55);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 0;
            this.bEliminar.Text = "&Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(70, 84);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(75, 23);
            this.bListar.TabIndex = 0;
            this.bListar.Text = "Listar";
            this.bListar.UseVisualStyleBackColor = true;
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(29, 123);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(115, 13);
            this.lCantidad.TabIndex = 3;
            this.lCantidad.Text = "Cantidad de Peliculas: ";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(232, 146);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            // 
            // fPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 183);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.tPeliculas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bAgregar);
            this.Name = "fPeliculas";
            this.Text = "Peliculas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPeliculas;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Button bCerrar;
    }
}

