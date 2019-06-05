using AppMoviles.Modelos;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMoviles.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleAsignatura : ContentPage
    {
        public DetalleAsignatura(Asignatura asignatura)
        {
            InitializeComponent();
            MyNameShow.Text = $"Asignatura: {asignatura.Nombre}";
            MyNotaShow.Text = $"Nota: {asignatura.Nota.ToString()}";
            MyInaShow.Text= $"Inasistencia: {asignatura.Inasistencia}";
            MyDocenteShow.Text = $"Docente: { asignatura.Horarios[0].Docente}";
        }
    }
}