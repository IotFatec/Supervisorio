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
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.BackColor.R.ToString() + " " + this.BackColor.G.ToString() + " " + this.BackColor.B.ToString() + " " + this.BackColor.A.ToString());
        }
    }
}
