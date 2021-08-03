using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citas_Medicas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void crearCitaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCrearCitaMedica = new FormCrearCitaMedica();
            formCrearCitaMedica.MdiParent = this;
            formCrearCitaMedica.Show();

        }

        private void buscarCitasProgramadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBuscarCitasProgramadas = new FormBuscarCitaProgramada();
            formBuscarCitasProgramadas.MdiParent = this;
            formBuscarCitasProgramadas.Show();
        }

        private void mantenimientoDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formListaDoctoresYEspecialidades = new FormDoctores();
            formListaDoctoresYEspecialidades.MdiParent = this;
            formListaDoctoresYEspecialidades.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buscarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormBuscarCitaProgramada();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormReporteDoctores();
            formFactura.MdiParent = this;
            formFactura.Show();
        }
    }
}
