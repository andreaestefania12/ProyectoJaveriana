using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMoviles.Modelos
{
    public class Usuario : INotifyPropertyChanged
    {
        //Atributos
        #region
        private long idCliente;
        private string username;
        private string password;

        [JsonProperty("valido")]
        private bool esValido;

        [JsonProperty("nombre")]
        private string nombre;

        [JsonProperty("apellido")]
        private string apellido;

        [JsonProperty("periodo")]
        private string periodo;

        [JsonProperty("emplid")]
        private string emplid;

        [JsonProperty("x-t6519fdd1s5q")]
        private string token;
        #endregion

        //Metodos
        #region Getters/Setters
        public string Token
        {
            get { return token; }
            set { token = value; OnPropertyChanged(); }
        }


        public string Emplid
        {
            get { return emplid; }
            set { emplid = value; OnPropertyChanged(); }
        }


        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; OnPropertyChanged(); }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public bool EsValido
        {
            get { return esValido; }
            set
            {
                esValido = value;
                OnPropertyChanged();
            }
        }


        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }


        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }


        public long IdCliente
        {
            get { return idCliente; }
            set
            {
                idCliente = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
