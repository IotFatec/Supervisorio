using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Supervisorio
{
    public partial class FormHomePage : Form
    {
        public string token;
        public string url;

        public FormHomePage()
        {
            InitializeComponent();
        }

        public List<Transelevador> produtos;
                

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            //Verifica se o botão contém a mensagem "Conectar", sinaliza se houve ou não a conexão
            if (btnConectar.Text == "CONECTAR")
            {
                
                token = txtToken.Text;                
                url = txtUrl.Text;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Authorization = new
                        System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",
                        token);
                    //Tenta fazer a requisição GET ao WebApi
                    try
                    {
                        btnConectar.Text = "CONECTANDO";
                        var resposta = await client.GetAsync("");

                        //Resposta da requisição GET
                        string dados = await resposta.Content.ReadAsStringAsync();

                        //Passa para uma lista todos os dados do Json da resposta
                       produtos = new JavaScriptSerializer().Deserialize<List<Transelevador>>(dados);

                        //Gera exceção caso a resposta do WebApi não seja "OK"
                        if (resposta.ReasonPhrase != "OK")
                        {
                            throw new Exception("Token de acesso negado!");
                        }

                        //                mostrarGraficos(produtos);
                        btnConectar.Text = "DESCONECTAR";
                        //                lblStatus.Visible = false;
                        timer1.Start();
                        txtToken.Enabled = false;
                    }
                    catch (Exception erro)
                    {
                        btnConectar.Text = "CONECTAR";
                        btnConectar.Enabled = true;
                        MessageBox.Show("Não foi possivel conectar!   " + erro.Message);
                        //                lblStatus.Text = erro.Message;
                        //                lblStatus.Visible = true;
                    }
                }
            }
            else if (btnConectar.Text == "DESCONECTAR")
            {
                txtToken.Enabled = true;
                btnConectar.Text = "CONECTAR";
            }
            txtToken.Text = "";
        }

        private void btnConectar_TextChanged(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Conectar")
                btnConectar.Enabled = true;

            else if (btnConectar.Text == "Desconectar")
                btnConectar.Enabled = true;

            else
                btnConectar.Enabled = false;
        }
    }
}

