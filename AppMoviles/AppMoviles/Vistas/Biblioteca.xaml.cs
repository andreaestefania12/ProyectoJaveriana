using AppMoviles.Modelos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMoviles.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Biblioteca : ContentPage
    {
        public Biblioteca(Usuario usuario)
        {
            InitializeComponent();
        }
    }
}