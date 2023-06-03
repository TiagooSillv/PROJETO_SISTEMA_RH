using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void rbSolicitouBeneficioSim_CheckedChanged(object sender, EventArgs e)
        {
            lblVezesSolicitadas.Visible = true;
            txtVezesSolicitadas.Visible = true;
        }

        private void rbSolicitouBeneficioNao_CheckedChanged(object sender, EventArgs e)
        {
            txtVezesSolicitadas.Visible = false;
            lblVezesSolicitadas.Visible= false;
            txtVezesSolicitadas.Text = "0";
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            var vezesSolicitadas = double.Parse(txtVezesSolicitadas.Text);
            var mesesTrabalhados = double.Parse(txtMesesTrabalhados.Text);
            var verificadorResultado = SeguroDesemprego.Calcula(vezesSolicitadas, mesesTrabalhados);
            lblresultado.Text = "Você está apto a receber " +  verificadorResultado.ToString() + " parcelas!";
            
        }
    }
}
