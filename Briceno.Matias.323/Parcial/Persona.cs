using System.Text;

namespace Parcial
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public int Edad { get => DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year -1; }
        public string NombreCompleto{ get => $"{this.apellido}, {this.nombre}";}

        public Persona(string nombre, string apellido, DateTime nacimiento) :this(nombre,apellido,nacimiento,""){}

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
        {
            this.nacimiento = nacimiento;
            this.apellido = apellido;
            this.nombre = nombre;
            this.barrioRecidencia = barrioRecidencia;            
        }

        public override string ToString()
        {
            return this.NombreCompleto;
        }

        public static string FichaPersonal(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(persona.ToString());
            sb.AppendLine($"EDAD: {persona.Edad}");
            sb.AppendLine(persona.FichaExtra());
            return sb.ToString();
        }

        internal abstract string FichaExtra();
        
    }
}
