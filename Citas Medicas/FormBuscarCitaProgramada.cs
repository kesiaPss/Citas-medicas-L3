using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.CitasMedicas;

namespace Citas_Medicas
{
    public partial class FormBuscarCitaProgramada : Form
    {
        private CitasBl _citas;
        public BindingList<Paciente> ListaPacientes { get; set; }
        public FormBuscarCitaProgramada()
        {
            InitializeComponent();

            _citas = new CitasBl();
            listaPacientesBindingSource.DataSource = _citas.ObtenerCitas();
            ListaPacientes = new BindingList<Paciente>();

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            Filtrar(nombreTextBox.Text);
        }

        private void Filtrar(string text)
        {

            ListaPacientes = _citas.ObtenerCitas();
            int cont = 0;
            foreach (var paciente in ListaPacientes)
            {
                if (paciente.Nombre.Contains(text))
                {
                    lblTexto.Text = "Si";
                    var Id = paciente.Id;

                    listaPacientesDataGridView.Rows[cont].Selected = true;

                    return;
                }
                else
                {
                    listaPacientesDataGridView.Rows[cont].Selected = false;
                    lblTexto.Text = "No";
                }
                cont++;
            }
        }
    }
}
