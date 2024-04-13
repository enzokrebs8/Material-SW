namespace InformacoesPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados de uma Pessoa");
            
            Pessoa P = new Pessoa();

            Console.WriteLine(P.Informacoes());
            Console.WriteLine(P.CalcularIdade());
        }
    }
}