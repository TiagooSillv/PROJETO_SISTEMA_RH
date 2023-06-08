using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void btnCalacula_Click(object sender, EventArgs e)

        {
            lblLoading.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            for(int i = 0; i <= progressBar1.Maximum; i++)
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
                return;
            }
            if (string.IsNullOrEmpty(txtAdicionalNoturno.Text))
            {
                MessageBox.Show("Informe quantas horas noturnas fez esse mês!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var horasNoturnas = double.Parse(txtAdicionalNoturno.Text);
                var valorDoAdicionalNoturno = AdicionalNoturno.Calcula(salario, horasNoturnas);
                lblResultado.Text = "R$" + valorDoAdicionalNoturno.ToString("F2");
                panel1.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAdicionalNoturno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    return;
                }
                if (string.IsNullOrEmpty(txtAdicionalNoturno.Text))
                {
                    MessageBox.Show("Informe quantas horas noturnas fez esse mês!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }
                try
                {
                    var salario = double.Parse(txtSalario.Text);
                    var horasNoturnas = double.Parse(txtAdicionalNoturno.Text);
                    var valorDoAdicionalNoturno = AdicionalNoturno.Calcula(salario, horasNoturnas);
                    lblResultado.Text = "R$" + valorDoAdicionalNoturno.ToString("F2");
                    panel1.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
