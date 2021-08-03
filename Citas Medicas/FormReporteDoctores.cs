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
    public partial class FormReporteDoctores : Form
    {
        public FormReporteDoctores()
        {
            InitializeComponent();

            var _doctor = new DoctoresBl();
            var bindingSource = new BindingSource();

            bindingSource.DataSource = _doctor.ObtenerDoctores();

            var reporte = new ReporteDoctores();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer.ReportSource = reporte;
            crystalReportViewer.RefreshReport();
        }
    }
}
