using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumDeFotos
{
    internal class Album
    {
        public double NumeroFotos { get; set; }
        public double FotosPagina { get; set; }
        public double Restante { get; set; }

        public double Div { get; set; }

        public string NumeroDePaginas()
        {

            Console.WriteLine("Digite quantas fotos você vai usar");
            NumeroFotos = Convert.ToDouble(Console.ReadLine());
            FotosPagina = 2;

            Restante = NumeroFotos % FotosPagina;
            Div = (NumeroFotos / FotosPagina) - 0.5;

            if (Restante == 1)
            {
                return "Você pode colocar " + Div + " fotos no álbum e sobrará " + Restante + " foto(s)";
            }
            else
            {
                return "Você pode colocar " + NumeroFotos / FotosPagina + " foto por página";
            }
        }
    }
}
