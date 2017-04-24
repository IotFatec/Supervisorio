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
        }
    }
}
