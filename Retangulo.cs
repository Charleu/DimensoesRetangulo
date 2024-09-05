using System;
namespace DimensoesRetangulo
{
    class Retangulo
    {
        private double _altura;
        private double _largura;

        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public double Largura
        {
            get { return _largura; }
            set { _largura = value; }
        }

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