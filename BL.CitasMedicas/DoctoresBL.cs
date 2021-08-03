using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.CitasMedicas;

namespace BL.CitasMedicas
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int EspecialidadId { get; set; }
        public Especialidades Especialidad { get; set; }
        public double Precio { get; set; }
        public int Disponibilidad { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
    }

    public class DoctoresBl
    {
        Contexto _contexto;
        public BindingList<Doctor> ListaDoctores { get; set; }

        public DoctoresBl()
        {
            _contexto = new Contexto();
            ListaDoctores = new BindingList<Doctor>();
        }

        public BindingList<Doctor> ObtenerDoctores()
        {
            _contexto.Doctor.Load();
            ListaDoctores = _contexto.Doctor.Local.ToBindingList();
            return ListaDoctores;
        }

        private Resultado ValidarDr(Doctor doctor)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (doctor.Disponibilidad == 0)
            {
                resultado.Mensaje = "Ingrese Disponibilidad";
                resultado.Exitoso = false;
            }

            if (Math.Abs(doctor.Precio) < 0.0)
            {
                resultado.Mensaje = "Ingrese un Precio";
                resultado.Exitoso = false;
            }

            if ((doctor.EspecialidadId) == 0)
            {
                resultado.Mensaje = "Ingrese una Especialidad";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(doctor.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre de doctor";
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

        public Resultado GuardarDoctor(Doctor doctor)
        {
            var resultado = ValidarDr(doctor);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarDoctor()
        {
            var nuevoDoctor = new Doctor();
            ListaDoctores.Add(nuevoDoctor);
        }

        public bool Eliminardoctor(int id)
        {
            foreach (var doctor in ListaDoctores)
            {
                if (doctor.Id == id)
                {
                    ListaDoctores.Remove(doctor);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }

}
