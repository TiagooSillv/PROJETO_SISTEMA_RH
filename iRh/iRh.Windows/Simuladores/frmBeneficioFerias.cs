using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(3);
            }
            progressBar1.Visible = false;
            lblLoading.Visible = false;

            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe o seu salário base por favor!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var vendaDeFerias = double.Parse(cmbDiasVendidos.Text);
                double valorFerias = Ferias.Calcula(salario, vendaDeFerias);
                var descontoInss = Inss.Calcula(salario);
                
                valorFerias += salario - descontoInss;

                lblResultado.Text = "R$" + valorFerias.ToString("F2");
                panel1.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbVendaDeFerias_CheckedChanged(object sender, EventArgs e)
        {
            cmbDiasVendidos.Visible = true;
            
        }

        private void rbVendaDeFeriasNao_CheckedChanged(object sender, EventArgs e)
        {
            cmbDiasVendidos.Visible = false;
            cmbDiasVendidos.Text = "0".ToString();
        }
    }
}
