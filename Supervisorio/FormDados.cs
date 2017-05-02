using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supervisorio
{
    public partial class FormDados : Form
    {
        public FormDados()
        {
            InitializeComponent();
        }

        private void FormDados_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MetodosEstaticos.listaDados;
            AtualizarGraficoGeral();
        }

        private void AtualizarGraficoIndividual(int id)
        {
            lblPrateleira.Text = "PRATELEIRA " + id;
            chGrafIndivid.Titles.Clear();
            chGrafIndivid.Series[0].Points.Clear();
            chGrafIndivid.Series.Clear();
            chGrafIndivid.Series.Add("Quantidade em estoque");
            chGrafIndivid.Series.Add("Quantidade mínima");
            

            chGrafIndivid.Titles.Add(MetodosEstaticos.listaDados[id - 1].nome);
            chGrafIndivid.Titles[0].Font = new Font("Arial", 20, FontStyle.Bold);
            chGrafIndivid.Titles[0].ForeColor = Color.SeaGreen;
            
            chGrafIndivid.Series[0].Points.Add(MetodosEstaticos.listaDados[id - 1].estocado);
            chGrafIndivid.Series[0].Points[0].Color = Color.BlueViolet;
            chGrafIndivid.Series[0].Points[0].LegendText = "Quantidade em estoque";
            
            chGrafIndivid.Series[1].Points.Add(MetodosEstaticos.listaDados[id - 1].minimo);
            chGrafIndivid.Series[1].Points[0].Color = Color.IndianRed;
            chGrafIndivid.Series[1].Points[0].LegendText = "Quantidade mínima";
            
        }

        private void AtualizarGraficoGeral()
        {
            try
            {
                //Título do gráfico
                chGrafGeral.Titles.Add("Ocupação das prateleiras");
                chGrafGeral.Titles[0].Font = new Font("Arial", 20, FontStyle.Bold);
                chGrafGeral.Titles[0].ForeColor = Color.SeaGreen;

                //Seleção do tipo de gráfico
                chGrafGeral.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                //Adicionando dados ao gráfico geral------------------------------------------------------

                //Prateleira 1
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[0].estocado);
                chGrafGeral.Series[0].Points[0].Color = Color.Blue;
                chGrafGeral.Series[0].Points[0].LegendText = MetodosEstaticos.listaDados[0].nome;

                //Prateleira 2
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[1].estocado);
                chGrafGeral.Series[0].Points[1].Color = Color.Green;
                chGrafGeral.Series[0].Points[1].LegendText = MetodosEstaticos.listaDados[1].nome;

                //Prateleira 3
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[2].estocado);
                chGrafGeral.Series[0].Points[2].Color = Color.Red;
                chGrafGeral.Series[0].Points[2].LegendText = MetodosEstaticos.listaDados[2].nome;

                //Prateleira 4
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[3].estocado);
                chGrafGeral.Series[0].Points[3].Color = Color.Violet;
                chGrafGeral.Series[0].Points[3].LegendText = MetodosEstaticos.listaDados[3].nome;

                //Prateleira 5
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[4].estocado);
                chGrafGeral.Series[0].Points[4].Color = Color.Yellow;
                chGrafGeral.Series[0].Points[4].LegendText = MetodosEstaticos.listaDados[4].nome;

                //Prateleira 6
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[5].estocado);
                chGrafGeral.Series[0].Points[5].Color = Color.Silver;
                chGrafGeral.Series[0].Points[5].LegendText = MetodosEstaticos.listaDados[5].nome;

                //Prateleira 7
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[6].estocado);
                chGrafGeral.Series[0].Points[6].Color = Color.SandyBrown;
                chGrafGeral.Series[0].Points[6].LegendText = MetodosEstaticos.listaDados[6].nome;

                //Prateleira 8
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[7].estocado);
                chGrafGeral.Series[0].Points[7].Color = Color.RoyalBlue;
                chGrafGeral.Series[0].Points[7].LegendText = MetodosEstaticos.listaDados[7].nome;

                //Prateleira 9
                chGrafGeral.Series[0].Points.Add(MetodosEstaticos.listaDados[8].estocado);
                chGrafGeral.Series[0].Points[8].Color = Color.Purple;
                chGrafGeral.Series[0].Points[8].LegendText = MetodosEstaticos.listaDados[8].nome;
            }

            catch
            {
                MessageBox.Show("Não foi possível atualizar os dados!\nVerifique sua conexão!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void AtualizarInformacoes(int id)
        {
            try
            {
                AtualizarGraficoIndividual(id);
                Transelevador aux;
                switch (id)
                {
                    case 1:
                        aux = MetodosEstaticos.listaDados[0];
                        richInformacoes.Text = aux.ToString();                        
                        break;

                    case 2:
                        aux = MetodosEstaticos.listaDados[1];
                        richInformacoes.Text = aux.ToString();
                        break;

                    case 3:
                        aux = MetodosEstaticos.listaDados[2];
                        richInformacoes.Text = aux.ToString();
                        break;

                    case 4:
                        aux = MetodosEstaticos.listaDados[3];
                        richInformacoes.Text = aux.ToString();
                        break;

                    case 5:
                        aux = MetodosEstaticos.listaDados[4];
                        richInformacoes.Text = aux.ToString();
                        break;

                    case 6:
                        aux = MetodosEstaticos.listaDados[5];
                        richInformacoes.Text = aux.ToString();
                        break;

                    case 7:
                        aux = MetodosEstaticos.listaDados[6];
                        richInformacoes.Text = aux.ToString();
                        break;

                    case 8:
                        aux = MetodosEstaticos.listaDados[7];
                        richInformacoes.Text = aux.ToString();
                        break;

                    case 9:
                        aux = MetodosEstaticos.listaDados[8];
                        richInformacoes.Text = aux.ToString();
                        break;

                    default:
                        return;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível atualizar os dados!\nVerificque sua conexão!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await MetodosEstaticos.ConectarWebService();
                dataGridView1.DataSource = MetodosEstaticos.listaDados;
            }
            catch
            {
                MessageBox.Show("Não foi possível atualizar");
            }
        }

        private void btnEst1_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(1);
        }

        private void btnEst2_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(2);
        }

        private void btnEst3_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(3);
        }

        private void btnEst4_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(4);
        }

        private void btnEst5_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(5);
        }

        private void btnEst6_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(6);
        }

        private void btnEst7_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(7);
        }

        private void btnEst8_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(8);
        }

        private void btnEst9_Click(object sender, EventArgs e)
        {
            AtualizarInformacoes(9);
        }
    }
}
