using AreaFigurasGeometricas.Entities.Enums;
using System;
using System.Globalization;

namespace AreaFigurasGeometricas.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Círculo {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
