using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertidorTemperatura
{
    public partial class Form1 : Form
    {
        Temperatura temperatura = new Temperatura();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            temperatura.setNumero1(double.Parse(txtnumero.Text));
            lblresultado.Text = temperatura.resultado().ToString();
            lblresultado.Visible = true;
            txtnumero.Text = "";
            txtnumero.Text = "";
            txtnumero.Focus();
        }
    }
}
