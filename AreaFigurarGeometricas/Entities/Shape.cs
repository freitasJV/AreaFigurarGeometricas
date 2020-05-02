using AreaFigurasGeometricas.Entities.Enums;

namespace AreaFigurasGeometricas.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
    }
}
