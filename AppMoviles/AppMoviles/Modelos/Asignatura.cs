using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMoviles.Modelos
{
    public class Asignatura : INotifyPropertyChanged
    {
        [JsonProperty("nom")]
        private string nombre;

        [JsonProperty("notp")]
        private float nota;

        [JsonProperty("crse_id")]
        private int id;

        [JsonProperty("coda")]
        private int codigo;

        [JsonProperty("porci")]
        private string inasistencia;

        [JsonProperty("horario")]
        private List<Horario> horarios;

        //Metodos
        #region Getters/Setters
        public List<Horario> Horarios
        {
            get { return horarios; }
            set { horarios = value; OnPropertyChanged(); }
        }

        public string Inasistencia
        {
            get { return inasistencia; }
            set { inasistencia = value; OnPropertyChanged(); }
        }


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; OnPropertyChanged(); }
        }


        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }


        public float Nota
        {
            get { return nota; }
            set { nota = value; OnPropertyChanged(); }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; OnPropertyChanged(); }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
