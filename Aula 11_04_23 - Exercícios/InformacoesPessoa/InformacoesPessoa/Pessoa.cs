using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InformacoesPessoa
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Altura { get; set; }

        public string Informacoes()
        {
            Convert.ToString(Nome = "Enzo");
            Convert.ToDateTime(DataNascimento = new DateTime(2007, 11, 24));
            Convert.ToDouble(Altura = 1.76);


            string dados = ("Olá " + Nome + "!!!");
            dados += ("\nVocê nasceu em: " + DataNascimento);
            dados += ("\nSua altura é: " + Altura);

            return dados;
        }
        public int CalcularIdade()
        {
            int idade = DateTime.Today.Year - DataNascimento.Year;
            if (DateTime.Today.Month < DataNascimento.Month || (DateTime.Today.Month == DataNascimento.Month && DateTime.Today.Day < DataNascimento.Day))
                idade--
                    ;

            return idade;
        }
    }

}
