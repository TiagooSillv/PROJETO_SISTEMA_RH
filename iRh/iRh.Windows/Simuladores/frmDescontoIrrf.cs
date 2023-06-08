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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iRh.Windows.Simuladores
{
    public partial class frmDescontoIrrf : Form
    {
        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(1);
            }
            progressBar1.Visible = false;
            lblLoading.Visible = false;

            if (string.IsNullOrEmpty(txtSalario.Text)) {

                MessageBox.Show("Informe o seu salário base por favor!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var descontoImpostoIrrf = Irrf.Calcula(salario);
                if (salario < 1903.98)
                {
                    MessageBox.Show("Sua faixa salarial está isenta do desconto do IRRF", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                lblResultado.Text = "R$" + descontoImpostoIrrf.ToString("F2");
                panel1.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
