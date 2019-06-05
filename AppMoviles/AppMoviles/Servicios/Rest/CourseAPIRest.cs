using AppMoviles.Modelos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppMoviles.Servicios.Rest
{
    public class CourseAPIRest
    {
        private readonly HttpClient client;

        public CourseAPIRest()
        {
            if (client == null) { client = new HttpClient(); }
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

    }
}
