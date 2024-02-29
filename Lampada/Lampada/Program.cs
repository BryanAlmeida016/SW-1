namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐INSTANCIA DE UM OBJETO⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐
            Lampada lampada1 = new Lampada();

            lampada1.ligar();
            lampada1.maisPotencia();
            lampada1.Azul();

            Console.WriteLine("A lâmpada está ligada?" + lampada1.estaLigada());
            Console.WriteLine("A lâmpada está em: " + lampada1.retornandoPotencia());
            Console.WriteLine("A lâmpada emite a cor: " + lampada1.qualCor());
        }
    }
}