// See https://aka.ms/new-console-template for more information
using Exercicio_4;

namespace Exercicío_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento p = new Pagamento();
            p.Nome = "Briano";
            p.Sal = 7200;
            p.HED = 0;
            p.HEN = 8;
            p.ND = 0;
            p.Fal = 4;
            p.DE = 3;
            p.REF = 1;
            p.Val = 0;
            Console.WriteLine(p.FolhaDePagamento());
        }
    }
}
