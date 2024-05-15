using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha { get => fecha; }
        public Paciente Paciente { get => paciente; }

        public Consulta(DateTime fecha,Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public override string ToString() => $"{this.Fecha} se ha atendido a {this.paciente}";
    }
}
