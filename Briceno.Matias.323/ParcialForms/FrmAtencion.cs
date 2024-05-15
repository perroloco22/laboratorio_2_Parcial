using Parcial;
namespace ParcialForms
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedIndex != -1 && lstPacientes.SelectedIndex != -1)
            {
                Paciente p = (Paciente)lstPacientes.SelectedItem;
                p.Diagnostico = "Paciente curado";
                lstMedicos.SelectedIndex = -1;
                lstPacientes.SelectedIndex = -1;
                Consulta consulta = new Consulta(DateTime.Now,p);
                MessageBox.Show(consulta.ToString(),"Atencion finalizada",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.","Error en los datos");
            }
        }
        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstMedicos.SelectedIndex !=  -1)
            {
                PersonalMedico persona = (PersonalMedico)lstMedicos.SelectedItem;
                rtbInfoMedico.Text = Persona.FichaPersonal(persona);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
