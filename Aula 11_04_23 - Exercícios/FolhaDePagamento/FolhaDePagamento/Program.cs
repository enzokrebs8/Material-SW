namespace FolhaDePagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario pagamento = new Funcionario();

            Console.WriteLine(pagamento.Informacoes());
        }
    }
}