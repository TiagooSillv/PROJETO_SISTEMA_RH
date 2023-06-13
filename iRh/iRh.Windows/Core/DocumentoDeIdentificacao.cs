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

        var listaDeDocumentos = new List<DocumentoDeIdentificacao>();

            listaDeDocumentos.Add(new DocumentoDeIdentificacao { Id = 1, Descricao = "RG"});
            listaDeDocumentos.Add(new DocumentoDeIdentificacao { Id = 2, Descricao = "CPF"});
            listaDeDocumentos.Add(new DocumentoDeIdentificacao { Id = 3, Descricao = "CNH"});
            listaDeDocumentos.Add(new DocumentoDeIdentificacao { Id = 4, Descricao = "Passaporte"});
            listaDeDocumentos.Add(new DocumentoDeIdentificacao { Id = 5, Descricao = "Carteira de Trabalho"});
            listaDeDocumentos.Add(new DocumentoDeIdentificacao { Id = 6, Descricao = "Titulo de Eleitor" });

            return listaDeDocumentos;
        }
        
   
    }
}
