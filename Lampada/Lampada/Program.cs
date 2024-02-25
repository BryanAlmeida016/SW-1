namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐INSTANCIA DE UM OBJETO⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();

            //⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐ACESSANDO UM ATRIBUTO PUBLICO DO OBJETO⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐
            lampada1.Ligada = true;
            lampada1.Potencia = 150;
            lampada1.Cor = "Vermelha";

            lampada2.Ligada = false;
            lampada2.Potencia = 10000;
            lampada2.Cor = "amarelow";

            //⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐VISUALIZANDO OS VALORES DE ATRIBUTOS⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐
            Console.WriteLine("ESSA É A LAMPADA 1!!");
            Console.WriteLine("A Lampada está ligada?" + lampada1.Ligada);
            Console.WriteLine("Qual é a cor da Lampada?" + lampada1.Cor);
            Console.WriteLine("Qual é a potencia da Lampada?" + lampada1.Potencia);
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
            Console.WriteLine("ESSA É A LAMPADA 2!!");
            Console.WriteLine("A Lampada está ligada?" + lampada2.Ligada);
            Console.WriteLine("Qual é a cor da Lampada?" + lampada2.Cor);
            Console.WriteLine("Qual é a potencia da Lampada?" + lampada2.Potencia);


        }
    }
}