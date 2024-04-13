using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada_Aula_01
{
    public class Lampada
    {
        private bool Ligada { get; set; }
        private string? Cor { get; set; }
        private int Potencia { get; set; }

        public void ligar()
        {
            Ligada = true;
        }
        public void desligar()
        {
            Ligada = false;
        }
        
        public bool estaLigada()
        {
            return Ligada;
        }
        public void cores()
        {
            Cor = "Vermelha";
        }

        public string qualCor()
        {
            return Cor;
        }
        public void potencia()
        {
            Potencia = 100;
        }
        public int qualPot()
        {
            return Potencia;
        }

    }
}
