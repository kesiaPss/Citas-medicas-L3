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
    public partial class FormFactura : Form
    {
        private FacturaBL _facturaBl;
        private CitasBl _citasBl;
        private ProductosBL _productosBl;

        public FormFactura()
        {
            InitializeComponent();

            _facturaBl = new FacturaBL();
            listaFacturasBindingSource.DataSource = _facturaBl.ObtenerFacturas();

            _citasBl = new CitasBl();
            listaPacientesBindingSource.DataSource = _citasBl.ObtenerCitas();

            _productosBl = new ProductosBL();
            listaProductosBindingSource.DataSource = _productosBl.ObtenerProductos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBl.AgregarFactura();
            listaFacturasBindingSource.MoveLast();

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

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturasBindingSource.EndEdit();

            var factura = (Factura)listaFacturasBindingSource.Current;
            var resultado = _facturaBl.GuardarFatura(factura);

            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _facturaBl.CancelarCambios();
        }

        private void AgregarDetalle()
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBl.AgregarFacturaDetalle(factura);

            DeshabilitarHabilitarBotones(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;
            if (MessageBox.Show("¿Quitar producto?", "Quitar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _facturaBl.RemoverFacturaDetalle(factura, facturaDetalle);

                DeshabilitarHabilitarBotones(false);
            }
        }



        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBl.CalcularFactura(factura);

            listaFacturasBindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea anular esta factura?", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _facturaBl.AnularFactura(id);
            if (resultado == true)
            {
                 listaFacturasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular factura");
            }
        }
        private void listaFacturasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            VerAnular();
        }

        private void VerAnular()
        {
            var factura = (Factura)listaFacturasBindingSource.Current;

            if (factura != null && factura.Id != 0 && factura.Activo == false)
            {
                lblAnulado.Visible = true;
            }
            else
            {
                lblAnulado.Visible = false;
            }
        }
        private void FormFactura_Load(object sender, EventArgs e)
        {
            CargarBotones();
        }
        private void CargarBotones()
        {
            int contador = 1, x = 10, y = 10, nBotones = 1;
            foreach (var producto in _productosBl.ListaProductos)
            {
                Button boton = new Button();
                boton.BackColor = Color.DarkSlateGray;
                boton.FlatAppearance.BorderSize = 0;
                boton.FlatStyle = FlatStyle.Flat;
                boton.ForeColor = Color.Tan;
                boton.Size = new Size(120, 70);
                boton.TabIndex = 0;
                boton.UseVisualStyleBackColor = false;

                boton.Name = "btnProductos" + contador.ToString();
                boton.Location = new Point(x, y);
                boton.Text = producto.Descripcion + " " + producto.Precio;
                boton.Tag = producto.Id;

                boton.Click += btnProductos_Click;

                panelProductos.Controls.Add(boton);

                nBotones++;

                if (nBotones <= 3)
                {
                    x += 130;
                }
                else
                {
                    x = 10;
                    y += 75;
                    nBotones = 1;
                }

                contador++;

            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var facturaActual = (Factura)listaFacturasBindingSource.Current;
            if (facturaActual != null)
            {
                var botonEnvia = (Button)sender;
                var id = Convert.ToInt32(botonEnvia.Tag);
                foreach (var producto in _productosBl.ListaProductos)
                {
                    if (producto.Id == id)
                    {

                        //MessageBox.Show(producto.Descripcion);
                        AgregarDetalle();

                        var factura = (Factura)listaFacturasBindingSource.Current;
                        int prod = factura.Id;

                        facturaDetalleDataGridView.Rows[facturaDetalleDataGridView.RowCount-1].Cells[0].Value = producto.Id;

                        _facturaBl.CalcularFactura(factura);

                        listaFacturasBindingSource.ResetBindings(false);
                        facturaDetalleBindingSource.ResetBindings(false);

                        DeshabilitarHabilitarBotones(false);

                        return;
                    }
                }
            }

        }

    }
}
