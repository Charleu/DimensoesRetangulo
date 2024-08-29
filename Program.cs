using System;

namespace DimensoesRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string separador = new string('.', 40);
            Console.WriteLine("Informe a altura do retângulo:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura do retângulo:");
            double largura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(altura, largura);

            Console.WriteLine(separador);
            Console.WriteLine($"Área do retângulo: {retangulo.CalculaArea().ToString("F2")}");
            Console.WriteLine($"Perímetro do retângulo: {retangulo.CalculaPerimetro().ToString("F2")}");
            Console.WriteLine($"Diagonal do retângulo: {retangulo.CalculaDiagonal().ToString("F2")}");
            Console.WriteLine(separador);
        }
    }
}