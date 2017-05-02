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

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            if(MetodosEstaticos.status)
            {
                richTextBox1.Visible = true;
                btnConectar.Text = "DESCONECTAR";            
            }
            else
            {
                richTextBox1.Visible = false;
                btnConectar.Text = "CONECTAR";
            }
        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "DESCONECTAR")
            {
                richTextBox1.Visible = false;
                btnConectar.Text = "CONECTAR";
                MetodosEstaticos.status = false;
            }
            else
            {
                try
                {
                    btnConectar.Text = "CONECTANDO";
                    await MetodosEstaticos.ConectarWebService(txtUrl.Text, "bearer", txtToken.Text);
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
                    btnConectar.Text = "CONECTAR";
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

        #region Eventos dos textBox

        private void txtUrl_Click(object sender, EventArgs e)
        {
            txtUrl.Clear();
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            if (txtUrl.Text == "")
                txtUrl.Text = "Digite a URL";
        }

        private void txtToken_Click(object sender, EventArgs e)
        {
            txtToken.Clear();
        }


        private void txtToken_Leave(object sender, EventArgs e)
        {
            if (txtToken.Text == "")
                txtToken.Text = "Insira aqui o token";
        }


        #endregion

    }
}

