using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO2;
using TO2;
using System.Data;
using System.Data.SqlClient;

namespace BL2
{
    public class BLPersona
    {

        public void ingresarPersona(TOPersona persona)
        {
            DAOPersona dao = new DAOPersona();
            dao.ingresarPersona(persona);
        }

        public DataTable listaPersonas()
        {
            DAOPersona dao = new DAOPersona();
            return dao.cargarGrid();
        }

        public TOPersona consultarPersona(String id)
        {
            DAOPersona dao = new DAOPersona();
            return dao.consultarPersona(id);
        }

        public void actualizarPersona(String id)
        {
            DAOPersona dao = new DAOPersona();
        }

    }
}
