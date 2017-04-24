﻿using System;
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

        public static async 
        Task
ConectarWebService(string url, string tipo, string token, int tempoAtualizacao)
        {            
            string tokenApp = token;
            string urlApp = url;
            status = false;

            using (HttpClient client = new HttpClient())
            {
                try
                {

                    client.BaseAddress = new Uri(url);
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
    }
}
