using AppMoviles.Modelos;
using AppMoviles.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMoviles.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalH : ContentPage
    {
        AsignaturaViewModel context;
    
        public PersonalH(Usuario usuario)
        {
            InitializeComponent();
            context = new AsignaturaViewModel(usuario);
            BindingContext = context;
        }
    }
}