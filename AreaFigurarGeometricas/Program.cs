using System;
using System.Globalization;

namespace AreaFigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;

            Console.WriteLine("Digite o valor de A, B e C separados por espaços Exemplo: 3.0 4.0 5.2");
            string[] entrada = Console.ReadLine().Split(' ');

            A = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            C = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            circulo = pi * Math.Pow(C, 2);
            trapezio = (C * (A + B)) / 2;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}
