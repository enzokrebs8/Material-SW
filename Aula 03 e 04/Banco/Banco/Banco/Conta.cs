using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        private string? agencia { get; set; }
        private string? usuário { get; set; }
        private float saldo { get; set; }
        private float limite { get; set; }

        public void bradesco(string usuário)
        {
            agencia = "Bradesco";
            Console.WriteLine("Você faz parte da agência: " + agencia + ". E seu id é: " + usuário);
        }

        public void sacar(float valorsaque)
        {
            if (valorsaque > saldo + limite)
            {
                Console.WriteLine("Você só pode sacar até R$:" + (saldo + limite));
            }
            else
            {
                saldo -= valorsaque;
                Console.WriteLine("Você fez um saque de R$:" + valorsaque + " seu saldo agora é de R$:" + saldo);
            }
        }

        public void depositar(float valordeposito)
        {
            saldo = saldo + valordeposito;
            Console.WriteLine("Você fez um depósito de R$:" + valordeposito + " seu saldo agora é de R$:" + saldo);
        }

        public float versaldo()
        {
            return saldo;
        }

        public float verlimite()
        {
            return limite;
        }

        public void mudarlimite(float maxlimite)
        {
            limite = maxlimite;
            Console.WriteLine("Você mudou seu limite para R$:" + limite);
        }
    }
}
