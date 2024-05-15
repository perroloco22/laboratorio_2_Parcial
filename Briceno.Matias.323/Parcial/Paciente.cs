using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Paciente : Persona
    {
        private string diagnostico;

        public string Diagnostico { get => diagnostico; set => diagnostico = value; }

        public Paciente(string nombre, string apellido, DateTime nacimiento,string barrioRecidencia) : base(nombre, apellido, nacimiento)
        {
            this.diagnostico = "";
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Persona.FichaPersonal(this));
            sb.AppendLine($"Recide en: {this.barrioRecidencia}");
            sb.AppendLine(this.diagnostico);
            return sb.ToString();
        }

        //dispose inciiarcompoenent atributo compoenent

    }
}
