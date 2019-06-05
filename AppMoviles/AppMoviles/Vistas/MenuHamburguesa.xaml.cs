using AppMoviles.Modelos;
using AppMoviles.ViewModels;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMoviles.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuHamburguesa : MasterDetailPage
    {
        UsuarioViewModel context;
        public MenuHamburguesa(Usuario usuario)
        {
            context = new UsuarioViewModel(usuario);
            InitializeComponent();
            Init(usuario);
            BindingContext = context;
        }

        void Init(Usuario usuario)
        {
            List<Menu> menu = new List<Menu>
            {
                new Menu { Page = new Course(usuario), MenuTitle = "Asignaturas", Icon = "biblioteca.png" },
                new Menu { Page = new Horario(usuario), MenuTitle = "Horario", Icon = "horario.png" },
                new Menu { Page = new Biblioteca(usuario), MenuTitle = "Biblioteca", Icon = "biblio.png" },
                new Menu { Page = new Login(), MenuTitle = "Cerrar Sesión", Icon = "exit.png" }
            };

            ListMenu.ItemsSource = menu;
            Detail = new Xamarin.Forms.NavigationPage(new Course(usuario))
            {
                BarBackgroundColor = Color.FromHex("#033E8C"),
                BarTextColor = Color.White
            };
        }

        void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false; //El menú hamburguesa se esconde 
                if (menu.MenuTitle == "Cerrar Sesión")
                {
                    this.Navigation.PushModalAsync(new Login());
                }
                else
                {
                    Detail = new Xamarin.Forms.NavigationPage(menu.Page)
                    {
                        BarBackgroundColor = Color.FromHex("#033E8C"),
                        BarTextColor = Color.White
                    };
                }

            }
        }

        public class Menu
        {
            public string MenuTitle
            {
                get; set;
            }

            public ImageSource Icon { get; set; }

            public Page Page { get; set; }
        }


    }
}