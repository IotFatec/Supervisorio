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

    public partial class FormPrincipal : Form
    {

        List<Transelevador> listaDados;

        public FormPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            tSBHomePage_Click(sender, e);    
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //fecha o form filho de dentro do form principal
            if (this.ActiveMdiChild != null) ActiveMdiChild.Close();

            //Limpa as cores de fundo dos botões indicando que não há botão selecionado
            tSBHomePage.BackColor = Color.Gainsboro;
            tSBDados.BackColor = Color.Gainsboro;
            tSBAbout.BackColor = Color.Gainsboro;
        }

        private void tSBHomePage_Click(object sender, EventArgs e)
        {            
            tSBHomePage.BackColor = Color.Silver;     //Muda a cor de fundo do botão
            FormHomePage form = new FormHomePage(); //Intância de novo form
            form.MdiParent = this;                      //Indica o form pai
            form.Show();                                //Apresenta o form dentro do container
            form.Location = new Point(0, 0);            //Indica a posição do form         

            form.Size = new Size(this.Size.Width - 92, this.Size.Height - 44);                
                

        }        

        private void tSBDados_Click(object sender, EventArgs e)
        {
            tSBDados.BackColor = Color.Silver;     //Muda a cor de fundo do botão
            FormDados form = new FormDados(); //Intância de novo form
            form.MdiParent = this;                      //Indica o form pai
            form.Show();                                //Apresenta o form dentro do container
            form.Location = new Point(0, 0);            //Indica a posição do form         

            form.Size = new Size(this.Size.Width - 92, this.Size.Height - 44);
        }

        private void tSBAbout_Click(object sender, EventArgs e)
        {
            tSBAbout.BackColor = Color.Silver;     //Muda a cor de fundo do botão
            FormAbout form = new FormAbout(); //Intância de novo form
            form.MdiParent = this;                      //Indica o form pai
            form.Show();                                //Apresenta o form dentro do container
            form.Location = new Point(0, 0);            //Indica a posição do form         

            form.Size = new Size(this.Size.Width - 92, this.Size.Height - 44);
        }

    }
}
