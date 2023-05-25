using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }
        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                txtValorDaPassagem.Visible = false;
                lblValorDaPassagem.Visible = false;
            }
            else
            {
                txtValorDaPassagem.Visible = true;
                lblValorDaPassagem.Visible = true;
            }
        }

            private void btnCalcula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe o seu salário base por favor!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
                    try
            { 
                var salario = double.Parse(txtSalario.Text);
                var descontoValeTransporte = ValeTransporte.Calcula(salario);
                var valorDaPassagem = double.Parse(txtValorDaPassagem.Text);
                var quantidadeDePassagem = double.Parse(txtQuantidadeDePassagem.Text);
                var gastoComPassagem = (quantidadeDePassagem * valorDaPassagem) * 20;

                if(gastoComPassagem < descontoValeTransporte)
                {
                    panel1.Visible = true;
                    lblResultado.Text = "R$" + descontoValeTransporte.ToString("F2");
                    MessageBox.Show("Não vale a pena ultilizar o Beneficio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSalario.Focus();
                    return;
                }
                else
                {
                    panel1.Visible = true;
                    lblResultado.Text = "R$" + descontoValeTransporte.ToString("F2");
                    MessageBox.Show("Vale a pena ultilizar o Beneficio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSalario.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        

        
        }

        private void txtValorDaPassagem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorDaPassagem.Text))
            {
                lblQuantidadeDePassagem.Visible = false;
                txtQuantidadeDePassagem.Visible = false;
            }
            else
            {
                lblQuantidadeDePassagem.Visible = true;
                txtQuantidadeDePassagem.Visible = true;
            }
        }
    }
}
