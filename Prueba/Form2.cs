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

            
            SqlConnection conexion = new SqlConnection("Data Source = .; Initial Catalog = PRUEBA; Integrated Security = True");
            string cadena = "insert into PERSONA (ID_PERSONA,NOMBRE,APELLIDOS,FECHA_NACIMIENTO,SEXO,OFICIO,ESTADO_CIVIL) values (@id, @nombre, @apellido, @fecha, @sexo, @oficio, @estadoCivil)";
            
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fecha", fechaNacimiento);
            comando.Parameters.AddWithValue("@sexo", sexo);
            comando.Parameters.AddWithValue("@oficio", oficio);
            comando.Parameters.AddWithValue("@estadoCivil", estadoCivil);
            
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos se guardaron correctamente");

            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
