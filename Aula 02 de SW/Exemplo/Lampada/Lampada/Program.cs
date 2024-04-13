namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // INSTÂNCIA DE UM OBJETO
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();

            // ACESSADO UM ATRIBUTO PÚBLICO DO OBJETO
            lampada1.Ligada = true;
            lampada1.Potencia = 150;
            lampada1.Cor = "Vermelha";

            lampada2.Ligada = false;
            lampada2.Potencia = 100;
            lampada2.Cor = "Azul";

            // VISUALIZANDO OS VALORES DE ATRIBUTOS
            Console.WriteLine("Essa é a Lâmpada 1");
            Console.WriteLine("A lâmpada está ligada? " +  lampada1.Ligada);
            Console.WriteLine("Qual é a potência da lâmpada? " + lampada1.Potencia + "w");
            Console.WriteLine("Qual é a cor da lâmpada? " + lampada1.Cor);
            Console.WriteLine();
            Console.WriteLine("Essa é a Lâmpada 2");
            Console.WriteLine("A lâmpada está ligada? " + lampada2.Ligada);
            Console.WriteLine("Qual é a potência da lâmpada? " + lampada2.Potencia + "w");
            Console.WriteLine("Qual é a cor da lâmpada? " + lampada2.Cor);
            Console.WriteLine();
            Console.WriteLine("Qual é a cor da lâmpada? " + lampada1.Cor);
        }
    }
}