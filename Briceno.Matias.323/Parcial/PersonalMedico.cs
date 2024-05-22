using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;
        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRecidente) : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esRecidente;
            this.consultas = new List<Consulta>();
        }

        public static Consulta operator +(PersonalMedico pm, Paciente pte)
        {
            Consulta consulta = new(DateTime.Now, pte);
            pm.consultas.Add(consulta);
            return consulta;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("¿Finalizó residencia?");
            sb.Append(this.esResidente ? " SI\n" : " NO\n" );
            sb.AppendLine("ATENCIONES: ");
            if (consultas.Count != 0)
            {
                foreach (Consulta consulta in this.consultas)
                {
                    sb.AppendLine(consulta.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
