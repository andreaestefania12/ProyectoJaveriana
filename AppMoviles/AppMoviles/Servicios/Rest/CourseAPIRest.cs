using AppMoviles.Modelos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppMoviles.Servicios.Rest
{
    public class CourseAPIRest
    {
        private readonly HttpClient client;

        public List<Asignatura> asignaturas { get; set; }

        public CourseAPIRest()
        {
            if (client == null) { client = new HttpClient(); }
            if (asignaturas == null) { asignaturas = new List<Asignatura>(); }
        }


        public async Task<List<Asignatura>> getAsignaturas(Usuario usuario)
        {
            string content = "";
            var url = Constant.BASE_URL + Constant.COURSE_URL;
            client.DefaultRequestHeaders.Add("x-t6519fdd1s5q", usuario.Token);
            content = await client.GetStringAsync(url);
            List<Asignatura> asignaturas = JsonConvert.DeserializeObject<List<Asignatura>>(content);
            return asignaturas;
        }

        public Asignatura getAsignatura(string nombreAsignatura)
        {
            Asignatura asignatura = asignaturas.FirstOrDefault(p => p.Nombre == nombreAsignatura);
            return asignatura;
        }

        public List<Horario> getHorario(string nombreAsignatura)
        {
            List<Horario> horarios = asignaturas.FirstOrDefault(p => p.Nombre == nombreAsignatura).Horarios;
            return horarios;
        }

    }
}
