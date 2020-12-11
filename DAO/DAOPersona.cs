using System;

using System.Data;
using System.Data.SqlClient;
using TO;

namespace DAO
{
    public class DAOPersona
    {


        public void cargarGrid(){
            SqlConnection conexion = new SqlConnection("Data Source = .; Initial Catalog = PRUEBA; Integrated Security = True");
        string query = "select * from PERSONA;";

        SqlCommand cmd = new SqlCommand(query, conexion);

        conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dataTable);
            conexion.Close();

            gridPersonas.DataSource = dataTable;
            }
    }
}
