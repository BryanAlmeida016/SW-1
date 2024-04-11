namespace Area_Quadrado_Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Área Quadrado/Retângulo");

            Area xyz = new Area();
            
            Console.WriteLine(xyz.Calcular());

            Console.WriteLine(xyz.Dados());
        }
    }
}