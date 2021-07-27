using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CitasMedicas
{
    public class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
    }

    public class ProductosBL
    {
        Contexto _contexto;
        public BindingList<Productos> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Productos>();
        }

        public BindingList<Productos> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos= _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
        }

        private Resultado Validar(Productos productos)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (productos == null)
            {
                resultado.Mensaje = "Agregue un producto";
                resultado.Exitoso = false;

                return resultado;
            }
            if (Math.Abs(productos.Precio) < 0.0)
            {
                resultado.Mensaje = "Ingrese un Precio";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(productos.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripción";
                resultado.Exitoso = false;
            }
            return resultado;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarProducto(Productos productos)
        {
            var resultado = Validar(productos);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Productos();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
