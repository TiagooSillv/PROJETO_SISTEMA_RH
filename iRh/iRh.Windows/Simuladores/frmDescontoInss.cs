using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmDescontoInss : Form
    {
        //CONTRUTOR É O PRIMEIRO QUE VAI FUNCIONAR QUANDO SE INICIA UM PROGRAMA
        public frmDescontoInss()
        { 
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
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

                var descontoInss = Inss.Calcula(salario);
                lblResultado.Text = "R$" + descontoInss.ToString("F2");
                panel1.Visible = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            
    

            
            
             
            







        }   

    }
}
