using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMoviles.Modelos
{
    public class Horario : INotifyPropertyChanged
    {
        [JsonProperty("feci")]
        private DateTime fechaInicial;

        [JsonProperty("hora")]
        private string hora;

        [JsonProperty("saln")]
        private string salon;

        [JsonProperty("fecf")]
        private DateTime fechaFinal;

        [JsonProperty("doc")]
        private string docente;

        [JsonProperty("dia")]
        private int dia;

        //Metodos
        #region Getters/Setters
        public int Dia
        {
            get { return dia; }
            set { dia = value; OnPropertyChanged(); }
        }


        public string Docente
        {
            get { return docente; }
            set { docente = value; OnPropertyChanged(); }
        }


        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; OnPropertyChanged(); }
        }


        public string Salon
        {
            get { return salon; }
            set { salon = value; OnPropertyChanged(); }
        }


        public string Hora
        {
            get { return hora; }
            set { hora = value; OnPropertyChanged(); }
        }


        public DateTime FechaInicial
        {
            get { return fechaInicial; }
            set { fechaInicial = value; OnPropertyChanged(); }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
