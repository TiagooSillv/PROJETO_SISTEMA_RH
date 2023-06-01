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
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }

        private void btnCalacula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe o seu salário base por favor!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();

                return;
            }
            if (string.IsNullOrEmpty(txtPericulosidade.Text))
            {

                MessageBox.Show("Informe as horas feitas por favor!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var horasPericulosidade = double.Parse(txtPericulosidade.Text);
                var calculoHoraPericulosidade = HorasPericulosidade.Calcula(salario, horasPericulosidade);
                lblResultado.Text = "R$" + calculoHoraPericulosidade.ToString("F2");
                panel1.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
