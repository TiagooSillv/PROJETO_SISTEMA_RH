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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe o seu salário base por favor!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var mesesTrabalhados = double.Parse(cmbMesesTrabalhados.Text);
                var verificador = Pis.Calcula(salario, mesesTrabalhados);
                lblresultado.Text = "R$" + verificador.ToString("F2");
                
                if (salario > 1320.00)
                {
                    MessageBox.Show("Somente pessoas com salario minimo tem direito a beneficio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          

        }

        private void rbTempoDeCarteiraNao_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Somente pessoas com mais de 5 anos de carteira assinada tem direito ao beneficio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
