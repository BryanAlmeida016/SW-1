using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        private bool Ligada { get; set; } 
        private string? Cor { get; set; }
        private int Potencia { get; set; }

        public void ligar()
        { Ligada = true; }

        public void desligar()
        { Ligada = false; }

        public bool estaLigada() 
        { return Ligada; }

        public void maisPotencia()
        {
            Potencia =+ 12;
        }

        public void menosPotencia()
        {
            Potencia = -12;
        }

        public int retornandoPotencia()
        {
            return Potencia;
        }

        public void Azul()
        {
            Cor = "Azul";
        }

        public void Vermelho()
        {
            Cor = "Vermelho";
        }

        public void Verde()
        {
            Cor = "Verde";
        }

        public string qualCor()
        {
            return Cor;
        }
    }
}
