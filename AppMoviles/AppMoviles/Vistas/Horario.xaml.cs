using AppMoviles.Modelos;
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
    public partial class Horario : TabbedPage
    {
        public Horario(Usuario usuario)
        {
            InitializeComponent();
            Children.Add(new PersonalH(usuario));
            Children.Add(new BuscarH());

        }
    }
}