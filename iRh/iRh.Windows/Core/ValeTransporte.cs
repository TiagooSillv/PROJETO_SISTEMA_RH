using System.Runtime.InteropServices;

namespace iRh.Windows.Core
{
    public static class ValeTransporte
    {
        public static double Calcula(double salario)
        {
            double descontoValeTrasporte = 0.0;

            descontoValeTrasporte = salario * 0.06;
            return descontoValeTrasporte;

        }
    }
}
