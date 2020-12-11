using System;

namespace TO
{
    public class TOPersona
    {

        private string id { set; get; }
        private string nombre { set; get; }
        private string apellidos { set; get; }
        private string ocupacion { set; get; }
        private string estadoCivil { set; get; }
        private string sexo { set; get; }
        private DateTime fechaNacimiento { set; get; }

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
