using AppMoviles.Modelos;
using AppMoviles.Servicios.Rest;
using AppMoviles.Vistas;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMoviles.ViewModels
{
    public class UsuarioViewModel : Usuario
    {
        Usuario usuario;
        LoginAPIRest servicioLogin;
        private MensajeError mensajeError;

        public UsuarioViewModel()
        {
            usuario = new Usuario();
            servicioLogin = new LoginAPIRest();
            mensajeError = new MensajeError();
            LoginCommand = new Command(async () => await Login(), () => true);
        }

        public Command LoginCommand { get; set; }

        public MensajeError MensajeInfo
        {
            get { return mensajeError; }
            set
            {
                mensajeError = value;
                OnPropertyChanged();
            }
        }
        public async Task Login()
        {
            usuario.Username = Username;
            usuario.Password = Password;
            var result = await servicioLogin.LoginUsuario(usuario);
            MensajeInfo = result.Item2;
            Console.WriteLine(usuario.Nombre);
            Console.WriteLine(usuario.Emplid);
            if (!MensajeInfo.HasError)
            {
                usuario = result.Item1;
                Application.Current.MainPage = new MenuHamburguesa(usuario);
            }
        }
    }
}
