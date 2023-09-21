using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ07
{
    public partial class frmReais : Form
    {
        public frmReais()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            Reais r;
            r = new Reais();
            r.setVdolar(int.Parse(txtVdolar.Text));
            r.setCdolar(int.Parse(txtCdolar.Text));
            r.calcularReais();

            lblResultado.Text = r.getReais().ToString();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }
    }
}
