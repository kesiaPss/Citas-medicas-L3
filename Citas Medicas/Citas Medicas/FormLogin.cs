using BL.CitasMedicas;
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
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = textBox1.Text;
            var contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = @"Verificando...";
            Application.DoEvents();

           var resultado = _seguridad.Autorizar(usuario, contrasena);

            if (resultado == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                button1.Enabled = true;
                button1.Text = "Aceptar";
                textBox1.Clear();  
                textBox2.Clear();
                textBox1.Focus();

                Application.DoEvents();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
