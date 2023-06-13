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
    }
}
