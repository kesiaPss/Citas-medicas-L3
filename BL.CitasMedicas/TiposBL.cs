using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BL.CitasMedicas
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
    public class TiposBl
    {
        private Contexto _contexto;

        public BindingList<Tipo> ListaTipos { get; set; }
        
        public TiposBl()
        {
            _contexto = new Contexto();
            ListaTipos = new BindingList<Tipo>();
        }

        public BindingList<Tipo> ObtenerTipos()
        {
            _contexto.Tipos.Load();
            ListaTipos = _contexto.Tipos.Local.ToBindingList();

            return ListaTipos;
        }
    }
}
