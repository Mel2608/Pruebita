namespace Prueba
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
            this.consultar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.ingresar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.tabla_Personas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(259, 214);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(131, 61);
            this.consultar.TabIndex = 2;
            this.consultar.Text = "Consultar Persona";
            this.consultar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(425, 220);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(126, 55);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar Persona";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(259, 133);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(131, 57);
            this.ingresar.TabIndex = 4;
            this.ingresar.Text = "Ingresar Persona";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(425, 133);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(126, 57);
            this.actualizar.TabIndex = 5;
            this.actualizar.Text = "Actualizar Persona";
            this.actualizar.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(349, 74);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(112, 17);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "BIENVENIDOS!!!!";
            // 
            // tabla_Personas
            // 
            this.tabla_Personas.AutoSize = true;
            this.tabla_Personas.Location = new System.Drawing.Point(352, 343);
            this.tabla_Personas.Name = "tabla_Personas";
            this.tabla_Personas.Size = new System.Drawing.Size(84, 17);
            this.tabla_Personas.TabIndex = 7;
            this.tabla_Personas.Text = "PERSONAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 245);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 683);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabla_Personas);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.consultar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label tabla_Personas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

