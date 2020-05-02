using AreaFigurasGeometricas.Entities.Enums;
using System.Globalization;

namespace AreaFigurasGeometricas.Entities
{
    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height, Color color) : base(color)
        {
            Base = @base;
            Height = height;
        }

        public override double Area()
        {
            return (Base * Height) / 2;
        }

        public override string ToString()
        {
            return $"Triângulo {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
