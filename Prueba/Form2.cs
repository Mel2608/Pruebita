using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using BL2;
using TO2;

namespace Prueba
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            DateTime fechaNacimiento = InfechaNacimiento.Value;
            String sexo = comboSexo.SelectedItem + "";
            String oficio = txtOficio.Text;
            String estadoCivil = comboCivil.SelectedItem + "";

            TOPersona persona = new TOPersona(id, nombre, apellido, oficio, estadoCivil, sexo, fechaNacimiento);
            BLPersona inBL = new BLPersona();
            inBL.ingresarPersona(persona);
           
            MessageBox.Show("Los datos se guardaron correctamente");

            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BLPersona bl = new BLPersona();
            if (Form1.accion.Equals("Consultar"))
            {
                TOPersona personaConsultada = bl.consultarPersona(Form1.id_Actual);

                btnIngresar.Visible = false;
                tituloIngresar.Text = "Consultar Persona";
                txtId.Text = personaConsultada.id;
                txtNombre.Text = personaConsultada.nombre;
                txtApellido.Text = personaConsultada.apellidos;
                InfechaNacimiento.Value = personaConsultada.fechaNacimiento;
                comboSexo.SelectedItem = personaConsultada.sexo.Trim();
                comboCivil.SelectedItem = personaConsultada.estadoCivil;
                txtOficio.Text = personaConsultada.ocupacion;
               
            }
        }
    }
}
