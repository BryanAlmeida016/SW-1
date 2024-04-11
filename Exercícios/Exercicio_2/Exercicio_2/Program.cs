namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a idade de alguém");
            
            Pessoa p = new Pessoa();
            p.Nome = "Bryan";
            p.DataNasc = new DateTime(2008, 4, 6);
            p.Altura = 1.69f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}