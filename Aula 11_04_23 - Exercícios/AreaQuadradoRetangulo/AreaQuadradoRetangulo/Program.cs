namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULE ÁREA DO QUADRO/RETÂNGULO");

            Area xyz = new Area();

            Console.WriteLine(xyz.Calcular());
            Console.WriteLine(xyz.Dados());

        }
    }
}