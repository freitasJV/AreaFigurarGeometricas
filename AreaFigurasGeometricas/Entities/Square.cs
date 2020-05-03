using AreaFigurasGeometricas.Entities.Enums;
using System;
using System.Globalization;

namespace AreaFigurasGeometricas.Entities
{
    class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side, Color color) : base(color)
        {
            Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

        public override string ToString()
        {
            return $"Quadrado {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
