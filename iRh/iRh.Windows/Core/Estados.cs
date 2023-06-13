using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Estados
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public List<Estados> ObterTodosEstados()
        {
            var ListaDeEstados = new List<Estados>();

            ListaDeEstados.Add(new Estados { Nome = "Roraima",Sigla = "RR"});
            ListaDeEstados.Add(new Estados { Nome = "Acre",Sigla = "AC"});
            ListaDeEstados.Add(new Estados { Nome = "Bahia",Sigla = "BA"});
            ListaDeEstados.Add(new Estados { Nome = "Alagoas",Sigla = "AL"});
            ListaDeEstados.Add(new Estados { Nome = "Amazonas",Sigla = "AM"});
            ListaDeEstados.Add(new Estados { Nome = "Ceará", Sigla = "CE" });
            ListaDeEstados.Add(new Estados { Nome = "Destrito Federal", Sigla = "DF" });
            ListaDeEstados.Add(new Estados { Nome = "Esoirito Santo", Sigla = "ES" });
            ListaDeEstados.Add(new Estados { Nome = "Goias", Sigla = "GO" });
            ListaDeEstados.Add(new Estados { Nome = "Maranhâo", Sigla = "MA" });
            ListaDeEstados.Add(new Estados { Nome = "Mato Grosso", Sigla = "MT" });
            ListaDeEstados.Add(new Estados { Nome = "Mato Grosso do Sul", Sigla = "MS" });
            ListaDeEstados.Add(new Estados { Nome = "Minas Gerais", Sigla = "MG" });
            ListaDeEstados.Add(new Estados { Nome = "Pará", Sigla = "PA" });
            ListaDeEstados.Add(new Estados { Nome = "Paraná", Sigla = "PR" });
            ListaDeEstados.Add(new Estados { Nome = "Pernanbuco", Sigla = "PE" });
            ListaDeEstados.Add(new Estados { Nome = "Piaui", Sigla = "PI" });
            ListaDeEstados.Add(new Estados { Nome = "Rio de Janeiro", Sigla = "RJ" });
            ListaDeEstados.Add(new Estados { Nome = "Rio Grande Do Norte", Sigla = "RN" });
            ListaDeEstados.Add(new Estados { Nome = "Rio Grande Do Sul", Sigla = "RS" });
            ListaDeEstados.Add(new Estados { Nome = "Rondônia", Sigla = "RO" });
            ListaDeEstados.Add(new Estados { Nome = "Roraima", Sigla = "Ro" });
            ListaDeEstados.Add(new Estados { Nome = "santa Catarina", Sigla = "SC" });
            ListaDeEstados.Add(new Estados { Nome = "São Paulo", Sigla = "SP" });
            ListaDeEstados.Add(new Estados { Nome = "Sergipe", Sigla = "SE" });
            ListaDeEstados.Add(new Estados { Nome = "Tocantins", Sigla = "TO" });
            return ListaDeEstados;
        }
       
    }
}
