using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class DocumentoDeIdentificacao
    {
        public string Descricao { get; set; }
        public int Id { get; set; }

        public List<DocumentoDeIdentificacao> obterTodosDocumentosDeIdentificacao() {

        var ListaDeDocumentos = new List<DocumentoDeIdentificacao>();

        ListaDeDocumentos.Add(new ListaDeDocumentos){ Descricao = "Carteira de Identidade"}

        }
   
    }
}
