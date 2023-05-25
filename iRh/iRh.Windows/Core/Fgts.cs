using System.Runtime.Remoting.Proxies;

namespace iRh.Windows.Core
{
    internal class Fgts
    {
        public static double Calcula(double salario)
        {


            double valorTotal = (salario / 100) * 8;
            return valorTotal;


        }

    }
}
