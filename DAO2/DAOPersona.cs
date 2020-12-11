using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO2;
using System.Data;
using System.Data.SqlClient;


namespace DAO2
{
    public class DAOPersona
    {
        private DataTable dataTable = new DataTable();
        public DataTable cargarGrid()
        {
            SqlConnection conexion = new SqlConnection("Data Source = .; Initial Catalog = PRUEBA; Integrated Security = True");
            string query = "select * from PERSONA;";

            SqlCommand cmd = new SqlCommand(query, conexion);

            conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            conexion.Close();
            return dataTable;
        }

        public void ingresarPersona(TOPersona persona)
        {
            SqlConnection conexion = new SqlConnection("Data Source = .; Initial Catalog = PRUEBA; Integrated Security = True");
            string cadena = "insert into PERSONA (ID_PERSONA,NOMBRE,APELLIDOS,FECHA_NACIMIENTO,SEXO,OFICIO,ESTADO_CIVIL) values (@id, @nombre, @apellido, @fecha, @sexo, @oficio, @estadoCivil)";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@id", persona.id);
            comando.Parameters.AddWithValue("@nombre", persona.nombre);
            comando.Parameters.AddWithValue("@apellido", persona.apellidos);
            comando.Parameters.AddWithValue("@fecha", persona.fechaNacimiento);
            comando.Parameters.AddWithValue("@sexo", persona.sexo);
            comando.Parameters.AddWithValue("@oficio", persona.ocupacion);
            comando.Parameters.AddWithValue("@estadoCivil", persona.estadoCivil);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public TOPersona consultarPersona(String id)
        {
            SqlConnection conexion = new SqlConnection("Data Source = .; Initial Catalog = PRUEBA; Integrated Security = True");
            string cadena = "Select * from Persona where ID_PERSONA = @id";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@id", id);

            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            TOPersona persona = new TOPersona();
            while(reader.Read())
            {
                persona.id = reader.GetString(0);
                persona.nombre = reader.GetString(1);
                persona.apellidos = reader.GetString(2);
                persona.fechaNacimiento = reader.GetDateTime(3);
                persona.sexo = reader.GetString(4);
                persona.ocupacion = reader.GetString(5);
                persona.estadoCivil = reader.GetString(6);
            }
            conexion.Close();
            return persona;
        }
    }
}
