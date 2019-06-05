using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMoviles.Modelos
{
    public class MensajeError : INotifyPropertyChanged
    {
        private string mensaje;
        private bool hasError;

        public bool HasError
        {
            get { return hasError; }
            set { hasError = value; OnPropertyChanged(); }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
