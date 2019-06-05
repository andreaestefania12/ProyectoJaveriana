using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMoviles.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleAsignatura : ContentPage
    {
        public DetalleAsignatura(String nombre, float nota, string inasistencia)
        {
            InitializeComponent();
            MyItemNameShow.Text = nombre;
            MyIngrediantItemShow.Text = nota.ToString();
            MyImageCall.Text = inasistencia;
        }
    }
}