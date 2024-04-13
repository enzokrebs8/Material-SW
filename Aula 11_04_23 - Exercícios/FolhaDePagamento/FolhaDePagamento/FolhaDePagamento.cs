using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public int HED { get; set; }
        public int HEN { get; set; }
        public int ND { get; set; }
        public double FAL { get; set; }
        public double DE { get; set; }
        public double REF { get; set; }
        public double VAL { get; set; }

        public string Informacoes()
        {
            Console.WriteLine("Qual é o nome do(a) funcionário(a)?");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual é o salário deste(a) feuncionário(a)?");
            Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantas horas extras este(a) funcionário(a) horas extras diurnas, fez no mês? ");
            HED = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Quantas horas extras este(a) funcionário(a) horas extras noturnas, fez no mês?");
            HEN = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qaul o número de dependentes associados a este(a) funcionário(a)?");
            ND = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qual foi a quantidade total de faltas (em horas) deste(a) funcionário(a) no mês?");
            FAL = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quais foram os descontos eventuais deste(a) funcionário(a) no mês?");
            DE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi o valor total gasto com refeições na empresa desse(a) funcionário(a) no mês?");
            REF = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi o valor total em vales retirados no mês?");
            VAL = Convert.ToDouble(Console.ReadLine());

            //"Incrementos"
            double horasExtras = HED * (Salario / 160) + (HEN * 1.2) * (Salario / 160);
            double salarioFamilia = ND * (0.05 * 1412); //Salário mínimo vigente

            double salarioBruto = Salario + horasExtras + salarioFamilia;

            //Descontos
            double INAMPS = 0.08 * Salario;
            double Faltas = FAL * (Salario / 160);
            double Refeicoes = REF;
            double Vales = VAL;
            double DescontosEventuais = DE;
            double ImpostoDeRenda = 0.08 * salarioBruto;

            //Desconto Total
            double descontoTotal = INAMPS + Faltas + Refeicoes + Vales + DescontosEventuais + ImpostoDeRenda;

            double salarioLiquido = salarioBruto - descontoTotal;

            string dados = "Funcionário(a): " + Nome + ".";
            dados += "\nSalário atual: R$ " + Salario + ".";
            dados += "\nHoras Extras: R$ " + horasExtras + ".";
            dados += "\nSalário Família: R$ " + salarioFamilia;
            dados += "\nSalário Bruto: R$ " + salarioBruto;
            dados += "\nSalário Líquido: R$ " + salarioLiquido;


            //dados += "Numéro de dependentes: " + ND + ".";
            //dados += "Faltas: " + FAL + ".";
            //dados += "Descontos eventuais: R$ " + DE + ".";
            //dados += "Gasto com refeições na empresa: R$ " + Refeicoes + ".";
            //dados += "Vales retirados durante o mês: " + Vales + " vale(s).";

            //dados += "O valor de seu INAMPS foi de " + INAMPS + ".";
            //dados += "";

            return dados;
        }
    }
}
