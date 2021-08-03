using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel;
using System.Linq;
using System;

namespace BL.CitasMedicas
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int MotivoId { get; set; }
        public Tipo MotivoCita { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public double Precio { get; set; }

        public Paciente()
        {
            Fecha = DateTime.Now;
            Hora = "07:00";
        }  
    }
    public class CitasBl
    {
        Contexto _contexto;
        public BindingList<Paciente> ListaPacientes { get; set; }

        public CitasBl()
        {
            _contexto = new Contexto();
            ListaPacientes = new BindingList<Paciente>();
        }

        public BindingList<Paciente> ObtenerCitas()
        {
            _contexto.Paciente.Load();
            ListaPacientes = _contexto.Paciente.Local.ToBindingList();
            return ListaPacientes;
        }

        public Resultado GuardarPaciente(Paciente paciente)
        {
            var resultado = Validar(paciente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarPaciente()
        {
            var nuevoPaciente = new Paciente();
            ListaPacientes.Add(nuevoPaciente);
        }

        public bool EliminarPaciente(int id)
        {
            foreach (var paciente in ListaPacientes)
            {
                if (paciente.Id == id)
                {
                    ListaPacientes.Remove(paciente);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Paciente paciente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (paciente == null)
            {
                resultado.Mensaje = "Ingrese un Paciente";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(paciente.Nombre) ==  true)
            {
                resultado.Mensaje = "Ingrese un nombre de paciente";
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
    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
