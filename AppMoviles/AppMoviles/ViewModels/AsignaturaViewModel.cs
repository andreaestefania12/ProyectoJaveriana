using AppMoviles.Modelos;
using AppMoviles.Servicios.Rest;
using System.Collections.Generic;

namespace AppMoviles.ViewModels
{
    public class AsignaturaViewModel : Asignatura
    {
        private List<Asignatura> asignaturas = new List<Asignatura>();
        CourseAPIRest servicioAsignatura = new CourseAPIRest();

        public AsignaturaViewModel(Usuario usuario)
        {
            this.InitialConfiguration(usuario);
        }

        public List<Asignatura> Asignaturas
        {
            get { return asignaturas; }
            set
            {
                asignaturas = value;
                OnPropertyChanged();
            }
        }

        private async void InitialConfiguration(Usuario usuario)
        {
            Asignaturas = await servicioAsignatura.getAsignaturas(usuario);
        }
    }
}
