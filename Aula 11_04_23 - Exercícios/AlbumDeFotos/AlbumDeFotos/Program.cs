using AlbumDeFotos;

namespace AlbumDeFotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando numero de paginas:");
            Console.WriteLine("");

            Album album = new Album();

            Console.WriteLine(album.NumeroDePaginas());

        }
    }
}