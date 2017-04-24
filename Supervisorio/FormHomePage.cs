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
        public FormHomePage()
        {
            InitializeComponent();
        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "DESCONECTAR")
            {

            }
            else
            {
                try
                {
                    btnConectar.Text = "CONECTANDO";
                    await MetodosEstaticos.ConectarWebService(txtUrl.Text, "bearer", txtToken.Text, 1000);
                    if (!MetodosEstaticos.status)
                    {
                        MessageBox.Show("Por favor verifique a URL e o Token de acesso!");
                        btnConectar.Text = "CONECTAR";
                    }
                    else
                    {
                        richTextBox1.Visible = true;
                        btnConectar.Text = "DESCONECTAR";
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
        }

        private void btnConectar_TextChanged(object sender, EventArgs e)
        {
            if (btnConectar.Text == "CONECTAR")
                btnConectar.Enabled = true;

            else if (btnConectar.Text == "DESCONECTAR")
                btnConectar.Enabled = true;

            else
                btnConectar.Enabled = false;
        }
    }
}

