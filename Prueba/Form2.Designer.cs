namespace Prueba
{
    partial class Form2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lvlEstadoCivil = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblOficio = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboCivil = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.tituloIngresar = new System.Windows.Forms.Label();
            this.InfechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(90, 159);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(93, 218);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(141, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de Nacimiento";
            // 
            // lvlEstadoCivil
            // 
            this.lvlEstadoCivil.AutoSize = true;
            this.lvlEstadoCivil.Location = new System.Drawing.Point(93, 288);
            this.lvlEstadoCivil.Name = "lvlEstadoCivil";
            this.lvlEstadoCivil.Size = new System.Drawing.Size(81, 17);
            this.lvlEstadoCivil.TabIndex = 2;
            this.lvlEstadoCivil.Text = "Estado Civil";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(93, 107);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(85, 17);
            this.lblIdentificador.TabIndex = 3;
            this.lblIdentificador.Text = "Identificador";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(477, 158);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(480, 217);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 17);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Location = new System.Drawing.Point(480, 286);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(44, 17);
            this.lblOficio.TabIndex = 6;
            this.lblOficio.Text = "Oficio";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(468, 383);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(91, 36);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(265, 383);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(92, 36);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(265, 101);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 22);
            this.txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(265, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // comboCivil
            // 
            this.comboCivil.FormattingEnabled = true;
            this.comboCivil.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viudo(a)"});
            this.comboCivil.Location = new System.Drawing.Point(265, 277);
            this.comboCivil.Name = "comboCivil";
            this.comboCivil.Size = new System.Drawing.Size(171, 24);
            this.comboCivil.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(585, 159);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(179, 22);
            this.txtApellido.TabIndex = 13;
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(585, 282);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(179, 22);
            this.txtOficio.TabIndex = 14;
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.comboSexo.Location = new System.Drawing.Point(585, 212);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(179, 24);
            this.comboSexo.TabIndex = 15;
            // 
            // tituloIngresar
            // 
            this.tituloIngresar.AutoSize = true;
            this.tituloIngresar.Location = new System.Drawing.Point(369, 26);
            this.tituloIngresar.Name = "tituloIngresar";
            this.tituloIngresar.Size = new System.Drawing.Size(117, 17);
            this.tituloIngresar.TabIndex = 16;
            this.tituloIngresar.Text = "Ingresar Persona";
            // 
            // InfechaNacimiento
            // 
            this.InfechaNacimiento.Location = new System.Drawing.Point(253, 218);
            this.InfechaNacimiento.Name = "InfechaNacimiento";
            this.InfechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.InfechaNacimiento.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.InfechaNacimiento);
            this.Controls.Add(this.tituloIngresar);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.comboCivil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lvlEstadoCivil);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lvlEstadoCivil;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboCivil;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label tituloIngresar;
        private System.Windows.Forms.DateTimePicker InfechaNacimiento;
    }
}