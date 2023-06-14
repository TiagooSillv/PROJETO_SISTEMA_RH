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

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarDocumentos();

        }
        private void CarregarDocumentos()
        {
            var documentos = new DocumentoDeIdentificacao();
            var listaDeDocumentos = documentos.obterTodosDocumentosDeIdentificacao();
            var documentosAZ = listaDeDocumentos.OrderBy(x => x.Descricao).ToList();
            cmbDocumento.Items.Clear();
            cmbDocumento.DataSource = documentosAZ;
            cmbDocumento.DisplayMember = "Descricao";
            cmbDocumento.ValueMember = "Id";
        }
        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();

            var estadosAZ = listaEstados.OrderBy(x => x.Sigla).ToList();
            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAZ;            
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var cepDigitado = txtCep.Text;
            var endereco = new Endereco();
            endereco = endereco.ObterPorCep(cepDigitado);
            if (endereco.Erro)
            {
                MessageBox.Show("Erro!", "Alerta", MessageBoxButtons.OK);
                return;
            }
           
                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Localidade;
                cmbEstados.Text = endereco.Uf;           
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            txtLogradouro.Enabled = false;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.Enabled = false;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro.Enabled = false;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade.Enabled = false;
        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstados.Enabled = false;
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
                int maxLength = 10; // Define o número máximo de caracteres permitidos

            if (txtCep.Text.Length > maxLength)
            {
                txtCep.Text = txtCep.Text.Substring(0, maxLength); // Limita o número de caracteres
                txtCep.SelectionStart = maxLength; // Define a posição do cursor
            }
        }
    }
}
