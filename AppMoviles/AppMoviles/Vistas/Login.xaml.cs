using AppMoviles.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMoviles.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        UsuarioViewModel context = new UsuarioViewModel();
        public Login()
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}