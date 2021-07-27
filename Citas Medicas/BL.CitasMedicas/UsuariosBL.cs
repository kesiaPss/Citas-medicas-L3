using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CitasMedicas
{
	public class Usuario
	{
		public int Id { get; set; }
		public string NombreUsuario { get; set; }
		public string Contrasena { get; set; }
	}
	public class UsuariosBL
	{
		private Contexto _contexto;

		 public BindingList<Usuario> ListaUsuarios { get; set; }

			public UsuariosBL()
			{
				_contexto = new Contexto();
				ListaUsuarios = new BindingList<Usuario>();
			}

			public BindingList<Usuario> ObtenerUsuarios()
			{
				_contexto.Usuarios.Load();
				ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

				return ListaUsuarios;
			}
		}

}

