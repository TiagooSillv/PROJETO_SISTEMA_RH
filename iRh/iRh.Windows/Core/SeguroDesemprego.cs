using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class SeguroDesemprego
    {
        public static double Calcula(double vezesSolicitadas, double mesesTrabalhados)
        {
            double verificador;
            verificador = 0;
            if (vezesSolicitadas == 0) { 
                if (mesesTrabalhados < 12)
                {
                     
                    return verificador;
                }
                else if (mesesTrabalhados > 11 && mesesTrabalhados < 24)
                {
                    verificador = 4;
                    return verificador;
                }
                else if(mesesTrabalhados > 24)
                {
                    verificador = 5;
                    return verificador;
                }
                return verificador;
            }
            if (vezesSolicitadas == 1)
            {
                if(mesesTrabalhados < 9)
                {
                    verificador = 0;
                    return verificador;
                }
                else if (mesesTrabalhados > 8 && mesesTrabalhados < 12)
                {
                    verificador = 3;
                    return verificador;
                }
                else if (mesesTrabalhados > 11 && mesesTrabalhados < 24)
                {
                    verificador = 4;
                    return verificador;
                }
                else if (mesesTrabalhados > 23)
                {
                    verificador = 5;
                    return verificador;
                }
            }
            if (vezesSolicitadas >= 2)
            {
                if (mesesTrabalhados < 6)
                {
                    verificador = 0;
                    return verificador;
                }
                else if(mesesTrabalhados < 12 && mesesTrabalhados > 5)
                {
                    verificador = 3;
                    return verificador;
                }
                else if (mesesTrabalhados > 11 && mesesTrabalhados < 24)
                {
                    verificador = 4;
                    return  verificador;
                }
                else if (mesesTrabalhados > 23)
                {
                    verificador = 5;
                    return verificador;
                }
            }
            return verificador;
        }
    }
}
