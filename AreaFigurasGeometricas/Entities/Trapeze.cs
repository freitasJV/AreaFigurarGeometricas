using AreaFigurasGeometricas.Entities.Enums;
using System.Globalization;

namespace AreaFigurasGeometricas.Entities
{
    class Trapeze : Shape
    {
        public double BiggestBase { get; set; }
        public double SmallestBase { get; set; }
        public double Height { get; set; }

        public Trapeze(double biggestBase, double smallestBase, double height, Color color) : base(color)
        {
            BiggestBase = biggestBase;
            SmallestBase = smallestBase;
            Height = height;
        }

        public override double Area()
        {
            return (Height * (BiggestBase + SmallestBase)) / 2;
        }

        public override string ToString()
        {
            return $"Trapézio {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
