namespace iRh.Windows.Core
{
    public static class AdicionalNoturno
    {
        public static double Calcula(double salario,double horasNoturnasFeitasNoMes)
        {
            double salarioComAdicional;
            double horasDeTrabalho = 220.00;

            var valorPorHora = salario / horasDeTrabalho;
            var valorDoadicional = valorPorHora * 0.20;
            salarioComAdicional = horasNoturnasFeitasNoMes * (valorPorHora + valorDoadicional);

            return salarioComAdicional;
        }
    }
}
