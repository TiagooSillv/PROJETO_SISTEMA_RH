using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Pis
    {
        public static double Calcula(double salario,double mesesTrabalhados)
        {
            const double salarioMinimo = 1320.00;
            var mediaSalario = salario / mesesTrabalhados;
            if (salario > 1300)
            {
                var resultado = (0);

                return resultado;
            }
            else
            {
                var resultado = (salarioMinimo / mesesTrabalhados) * mesesTrabalhados;

                return resultado;
            }
        }
    }
        
       
}
