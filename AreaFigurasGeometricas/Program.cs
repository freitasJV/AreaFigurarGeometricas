using AreaFigurasGeometricas.Entities;
using AreaFigurasGeometricas.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AreaFigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Shape> list = new List<Shape>();

                Console.Write("Digite o número de figuras desejadas: ");
                int n = int.Parse(Console.ReadLine());

                while (n > 0)
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"Figura #{i}:");
                        Console.WriteLine("Digite r para Retângulo, c para Círculo, q para Quadrado, tra para Trapézio ou tri para Triângulo:");
                        string escolha = Console.ReadLine();

                        Console.Write("Color (Black/Blue/Red): ");
                        Color color = Enum.Parse<Color>(Console.ReadLine());

                        double widht, side, radius, biggestBase, smallestBase, height, b;

                        switch (escolha.ToUpper())
                        {
                            case "R":
                                Console.Write("Largura: ");
                                widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                Console.Write("Altura: ");
                                height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                list.Add(new Rectangle(widht, height, color));
                                n--;
                                break;

                            case "C":
                                Console.Write("Raio: ");
                                radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                list.Add(new Circle(radius, color));
                                n--;
                                break;

                            case "Q":
                                Console.Write("Lado: ");
                                side = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                list.Add(new Square(side, color));
                                n--;
                                break;

                            case "TRI":
                                Console.Write("Base: ");
                                b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                Console.Write("Altura: ");
                                height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                list.Add(new Triangle(b, height, color));
                                n--;
                                break;

                            case "TRA":
                                Console.Write("Maior Base: ");
                                biggestBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                Console.Write("Maior Base: ");
                                smallestBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                Console.Write("Altura: ");
                                height = double.Parse(Console.ReadLine());
                                list.Add(new Trapeze(biggestBase, smallestBase, height, color));
                                n--;
                                break;

                            default:
                                Console.WriteLine("Escolha inválida");
                                break;
                        }

                    }

                Console.WriteLine();
                Console.WriteLine("Área das figuras");

                foreach (Shape shape in list)
                {
                    Console.WriteLine(shape);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
