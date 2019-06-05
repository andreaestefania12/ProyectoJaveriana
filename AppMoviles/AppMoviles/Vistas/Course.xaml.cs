using AppMoviles.Modelos;
using AppMoviles.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMoviles.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Course : ContentPage
    {
        AsignaturaViewModel context;
        public Course(Usuario usuario)
        {
            InitializeComponent();
            context = new AsignaturaViewModel(usuario);
            BindingContext = context;
        }

        private async void OnItemSelect(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Asignatura;
            await Navigation.PushAsync(new DetalleAsignatura(mydetails.Nombre, mydetails.Nota, mydetails.Inasistencia));

        }
    }
}