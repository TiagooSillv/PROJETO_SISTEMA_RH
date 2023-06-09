﻿using iRh.Windows.Core;
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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
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
                Thread.Sleep(1);
            }
            progressBar1.Visible = false;
            lblLoading.Visible = false;

            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe o seu salário base por favor!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            if (!rbSolicitouBeneficioSim.Checked)
            {
                if (!rbSolicitouBeneficioNao.Checked)
                {
                    MessageBox.Show("Selecione se você tem ou nao 5 anos de carteira assinada ", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            if (rbSolicitouBeneficioNao.Checked)
            {
                MessageBox.Show("Somente pessoas que possuem no minimo 5 anos de carteira assinada tem direito ao beneficio", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var mesesTrabalhados = double.Parse(cmbMesesTrabalhados.Text);
                var verificador = Pis.Calcula(salario, mesesTrabalhados);
                lblresultado.Text = "R$" + verificador.ToString("F2");
                panel1.Visible = true;

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
    }
}
