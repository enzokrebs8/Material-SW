using System.Threading.Tasks.Sources;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.depositar(500); //valor inicial
            conta.mudarlimite(900);
            Console.WriteLine("você fez um depósito e está com o saldo de R$:" + conta.versaldo()); //mostra saldo
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine();

            conta.bradesco("Davi Antonio Ramos Araujo");
            Console.WriteLine();
            Console.WriteLine("Seu saldo é de R$" + conta.versaldo() + " e seu limite é de R$:" + conta.verlimite()); //inicio
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            conta.sacar(2000); //saque inválido
            conta.mudarlimite(1500); //mudar limite
            conta.sacar(2000); //saque
            conta.depositar(2500); //depositar

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Seu saldo é de R$" + conta.versaldo() + " e seu limite é de R$:" + conta.verlimite()); //ver saldo

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}