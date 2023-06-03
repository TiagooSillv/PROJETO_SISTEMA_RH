using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iRh.Windows.Core
{
    public static class Irrf
    {
        public static double Calcula(double salario)
        {

			double impostoDeRenda = 0;

			if (salario <= 1903.98)
			{
				impostoDeRenda = 0;
			}
			else if(salario <= 2826.65)
			{
				impostoDeRenda = (salario / 100) * 7.5 - 142.80;
				return impostoDeRenda;
			}
			else if (salario <= 3751.05)
			{
				impostoDeRenda = (salario / 100) * 7.5 - 142.80;
				return impostoDeRenda;
			}
			else if (salario <= 4664.68){
				impostoDeRenda = (salario / 100) * 22.5 - 636.13;
			}
			else if(salario > 4664.68)
			{
				impostoDeRenda = (salario / 100) * 27.5 - 869.36;
			}
			return impostoDeRenda;

            /*real desconto_inss,desconto_imposto_de_renda = 0.0
		se(salario <= 1903.98)
		{
			escreva("SUA FAIXA SALÁRIAL ESTÁ ISENTA DO IMPOSTO DE RENDA! (IRRF)\n")
		}
		senao se (salario <= 2826.65)
		{
			desconto_imposto_de_renda = (salario / 100) * 7.5 - 142.80
			desconto_imposto_de_renda = MAT.arredondar(desconto_imposto_de_renda, 2)
			retorne desconto_imposto_de_renda
		}
		senao se (salario <=  3751.05)
		{
			desconto_imposto_de_renda = (salario / 100) * 15 - 354.80
			desconto_imposto_de_renda = MAT.arredondar(desconto_imposto_de_renda, 2)
			retorne desconto_imposto_de_renda
		}
		senao se (salario <= 4664.68 )
		{
			desconto_imposto_de_renda = (salario / 100) * 22.5 - 636.13
			desconto_imposto_de_renda = MAT.arredondar(desconto_imposto_de_renda, 2)
			retorne desconto_imposto_de_renda
		}
		senao se (salario > 4664.68 )
		{
			desconto_imposto_de_renda = (salario / 100) * 27.5 - 869.36
			desconto_imposto_de_renda = MAT.arredondar(desconto_imposto_de_renda, 2)
			retorne desconto_imposto_de_renda
		}
		     retorne desconto_imposto_de_renda
	}*/
        }
    }
}
