using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CitasMedicas
{
    public class Especialidades
    {
        public int Id { get; set; }
        public string Especialidad { get; set; }
    }

    public class EspecialidadesBL
    {
        private Contexto _contexto;

        public BindingList<Especialidades> ListaEspecialidades { get; set; }

        public EspecialidadesBL()
        {
            _contexto = new Contexto();
            ListaEspecialidades = new BindingList<Especialidades>();
        }

        public BindingList<Especialidades> ObtenerEspecialidades()
        {
            _contexto.Especialidades.Load();
            ListaEspecialidades = _contexto.Especialidades.Local.ToBindingList();

            return ListaEspecialidades;
        }
    }
}
