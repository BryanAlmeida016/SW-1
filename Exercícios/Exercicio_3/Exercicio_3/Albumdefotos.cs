using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Albumdefotos
    {
        private int numDePag;
        private int numDeFotos;

        public int NumdePag
        {
            get
            {
                return numDePag;
            }
            set
            {
                numDePag = value;
            }
        }

        public int NumDeFotos
        {
            get
            {
                return numDeFotos;
            }
            set
            {
                numDeFotos = value;
            }
        }

        public string Resposta()
        {
            int numTotal = numDePag * 2;
            string Resultado = "";

            if(numTotal < numDeFotos)
            {
                Resultado = "Você possui mais fotos do que o álbum suporta...";
            }
            else
            {
                Resultado = "O seu álbum aguenta tudo!!";
            }

            return Resultado;
        }
    }
}
