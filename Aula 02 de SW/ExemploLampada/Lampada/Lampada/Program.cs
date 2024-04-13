namespace Lampada_Aula_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //instancia de um objeto:
            Lampada lampada1 = new Lampada();

            lampada1.ligar();
            lampada1.desligar();
            lampada1.cores();
            lampada1.potencia();

            Console.WriteLine("A lâmapada está ligada? " + lampada1.estaLigada());
            Console.WriteLine("Qual é a cor da lâmpada? " + lampada1.qualCor());
            Console.WriteLine("Qual é a potência da lâmpada? " + lampada1.qualPot());
        }
    }
}