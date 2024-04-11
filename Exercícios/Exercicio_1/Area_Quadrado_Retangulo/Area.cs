using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Quadrado_Retangulo
{
    public class Area
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double AreaTotal { get; set; }

        public string Calcular()
        {
            Console.WriteLine("Digite a base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            AreaTotal = Base * Altura;
            string tipo = "";

            if (Base == Altura)
            {
                tipo = "Quadrado";
            }
            else
            {
                tipo = "Retângulo";
            }

            string Resultado = "Sua área é " + AreaTotal;
            Resultado += " e isto é um ";
            Resultado += tipo;

            return Resultado;
        }

        public string Dados()
        {
            string informacao = "O valor da base é " + Base;
            informacao += "\nE o valor da altura é " + Altura;
            return informacao;
        }
    }
}
