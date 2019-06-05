using AppMoviles.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppMoviles.Servicios.Rest
{
    public class LoginAPIRest
    {
        private readonly HttpClient client;
        private MensajeError mensajeError;

        public LoginAPIRest()
        {
            if (client == null) { client = new HttpClient(); }

            mensajeError = new MensajeError();
        }

        public async Task<Tuple<Usuario, MensajeError>> LoginUsuario(Usuario usuario)
        {
            Usuario loginUsuario = null;
            try
            {
                Dictionary<string, string> queryParameters = new Dictionary<string, string>();
                queryParameters.Add("usu", usuario.Username);
                queryParameters.Add("pass", usuario.Password);
                var queryString = new FormUrlEncodedContent(queryParameters);
                var url = Constant.BASE_URL + Constant.LOGIN_URL + queryString.ReadAsStringAsync().Result;

                var content = await client.GetStringAsync(url);

                loginUsuario = JsonConvert.DeserializeObject<Usuario>(content);
                if (loginUsuario.EsValido)
                {
                    mensajeError.Mensaje = "Exitoso";
                    mensajeError.HasError = false;
                }
                else
                {
                    mensajeError.Mensaje = "Credenciales no validas";
                    mensajeError.HasError = true;
                }
            }

            catch (HttpRequestException e)
            {
                mensajeError.Mensaje = "Error de comunicacion";
                mensajeError.HasError = true;
            }

            var result = Tuple.Create<Usuario, MensajeError>(loginUsuario, mensajeError);
            return result;
        }
    }
}
