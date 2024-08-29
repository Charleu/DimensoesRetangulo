using System;
namespace DimensoesRetangulo
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public Retangulo( double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalculaArea()
        {
            return Altura * Largura;
        }

        public double CalculaPerimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }

        public double CalculaDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}