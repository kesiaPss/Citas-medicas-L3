using System;
using System.Windows.Forms;
using BL.CitasMedicas;

namespace Citas_Medicas
{
    public partial class FormCrearCitaMedica : Form
    {
        private CitasBl _citas;
        private DoctoresBl _doctores;
        private TiposBl _tipos;

        public FormCrearCitaMedica()
        {
            InitializeComponent();

            _citas = new CitasBl();
            listaPacientesBindingSource.DataSource = _citas.ObtenerCitas();

            _doctores = new DoctoresBl();
            listaDoctoresBindingSource.DataSource = _doctores.ObtenerDoctores();

            _tipos = new TiposBl();
            listaTiposBindingSource.DataSource = _tipos.ObtenerTipos();
        }

        private void listaPacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaPacientesBindingSource.EndEdit();
            var paciente = (Paciente)listaPacientesBindingSource.Current;

            var resultado = _citas.GuardarPaciente(paciente);

            if (resultado.Exitoso == true)
            {
                listaPacientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cita Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _citas.AgregarPaciente();
            listaPacientesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;

        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea Eliminar esta Cita?", "Eliminar Cita", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }

        }

        private void Eliminar(int id)
        {
            var resultado = _citas.EliminarPaciente(id);

            if (resultado == true)
            {
                listaPacientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al eliminar Paciente");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _citas.CancelarCambios();
        }

    }
}
