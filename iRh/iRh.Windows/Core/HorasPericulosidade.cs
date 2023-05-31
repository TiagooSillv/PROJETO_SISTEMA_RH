using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class HorasPericulosidade
    {
        public static double Calcula(double salario, double horasPericulosidade)
        {
            var adicionalPericulosidade = (salario / 220) * 0.30 * horasPericulosidade;
            return adicionalPericulosidade;
        }

    }
}
