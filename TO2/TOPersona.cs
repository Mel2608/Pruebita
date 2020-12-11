using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO2
{
    public class TOPersona
    {
        public string id { set; get; }
        public string nombre { set; get; }
        public string apellidos { set; get; }
        public string ocupacion { set; get; }
        public string estadoCivil { set; get; }
        public string sexo { set; get; }
        public DateTime fechaNacimiento { set; get; }

        public TOPersona(string id, string nombre, string apellidos, string ocupacion, string estadoCivil, string sexo, DateTime fechaNacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.ocupacion = ocupacion;
            this.estadoCivil = estadoCivil;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
        }

        public TOPersona()
        {

        }
    }
}

