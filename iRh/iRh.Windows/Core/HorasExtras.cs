using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class HorasExtras
    {
        public static double Calcula(double salario, double horaExtra)
        {
            double salarioComAdicional;
            const double horasDeTrabalho = 220.00;
            var valorPorHora = salario / horasDeTrabalho;
            var valorDoadicional = valorPorHora * 0.20;
            salarioComAdicional = horaExtra * (valorPorHora + valorDoadicional);

            return salarioComAdicional;
        }
    }
}
