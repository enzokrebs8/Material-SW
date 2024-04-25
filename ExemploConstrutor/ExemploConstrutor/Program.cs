namespace ExemploConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo Contrutor de Classe");

            Cliente novo_cliente = new Cliente();

            novo_cliente.Nome = "Enzo";
            novo_cliente.Email = "enzo@gmail.com";
            novo_cliente.Senha = 150249;

            novo_cliente.MostraDados();
        }
    }
}