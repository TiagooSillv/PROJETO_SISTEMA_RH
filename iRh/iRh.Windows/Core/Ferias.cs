using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Ferias
    {
        public static double Calcula(double salario)
        {
            double valorDoDia = salario / 30;
            var valorFerias = valorDoDia + (salario / 3);
            return valorFerias;
        }

        public static double Calcula(double salario, double vendaDeFerias)
        {
            double valorDoDia = salario / 30;
            var valorFerias = (vendaDeFerias * valorDoDia) + (salario / 3) + vendaDeFerias * valorDoDia;
            return valorFerias;
        }
    }
}
