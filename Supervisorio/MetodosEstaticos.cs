using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Supervisorio
{
    public static class MetodosEstaticos
    {
        public static List<Transelevador> listaDados;
        public static string respostaPedido;
        public static bool status =false;
        private static string tokenApp;
        private static string urlApp;
        private static string tipoApp = "Bearer";

        public static async Task ConectarWebService(string url, string tipo, string token)
        {            
            tokenApp = token;
            urlApp = "http://iiot-webapi2.azurewebsites.net/api/products";
            status = false;

            using (HttpClient client = new HttpClient())
            {
                try
                {

                    client.BaseAddress = new Uri(urlApp);
                    client.DefaultRequestHeaders.Authorization = new
                        System.Net.Http.Headers.AuthenticationHeaderValue(tipo,
                        token);
                }
                catch
                {
                    return;
                }
                
                //Tenta fazer a requisição GET ao WebApi
                try
                {                    
                    var resposta = await client.GetAsync("");

                    //Resposta da requisição GET
                    string dados = await resposta.Content.ReadAsStringAsync();

                    //Passa para uma lista todos os dados do Json da resposta
                    listaDados = new JavaScriptSerializer().Deserialize<List<Transelevador>>(dados);
                    respostaPedido = resposta.ReasonPhrase;

                    //Gera exceção caso a resposta do WebApi não seja "OK"
                    if (resposta.ReasonPhrase != "OK")
                    {
                        throw new Exception("Token de acesso negado!");                        
                    }
                    status = true;
                }
                catch
                {
                    throw new Exception("Token de acesso negado!");
                }
            }
            
        }


        public static async Task ConectarWebService()
        {
            status = false;

            using (HttpClient client = new HttpClient())
            {
                try
                {

                    client.BaseAddress = new Uri(urlApp);
                    client.DefaultRequestHeaders.Authorization = new
                        System.Net.Http.Headers.AuthenticationHeaderValue(tipoApp,
                        tokenApp);
                }
                catch
                {
                    return;
                }

                //Tenta fazer a requisição GET ao WebApi
                try
                {
                    var resposta = await client.GetAsync("");

                    //Resposta da requisição GET
                    string dados = await resposta.Content.ReadAsStringAsync();

                    //Passa para uma lista todos os dados do Json da resposta
                    listaDados = new JavaScriptSerializer().Deserialize<List<Transelevador>>(dados);

                    //Gera exceção caso a resposta do WebApi não seja "OK"
                    if (resposta.ReasonPhrase != "OK")
                    {
                        throw new Exception("Token de acesso negado!");
                    }
                    status = true;
                }
                catch
                {
                    throw new Exception("Token de acesso negado!");
                }
            }

        }
    }
}
