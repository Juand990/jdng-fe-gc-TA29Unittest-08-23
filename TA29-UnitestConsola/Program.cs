using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA29_UnitestConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int figura = Menu();
            Geometria g = new Geometria(figura);
            switch (g.getId())
            {
                case 1:
                    Console.WriteLine("Un valor para el LADO del cuadrado:");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Cuadrado: " + g.areacuadrado(l));
                    break;
                case 2:
                    Console.WriteLine("Un valor para el RADIO del circulo:");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Circulo: " + g.areacuadrado(r));
                    break;
                case 3:
                    Console.WriteLine("Un valor para el LADO 1 del triangulo:");
                    int l1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Un valor para el LADO 2 del triangulo:");
                    int l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Triangulo: " + g.areatriangulo(l1, l2));
                    break;
                case 4:
                    Console.WriteLine("Un valor para el LADO 1 del rectangulo:");
                    l1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Un valor para el LADO 2 del rectangulo:");
                    l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Rectangulo: " + g.arearectangulo(l1, l2));
                    break;
                case 5:
                    Console.WriteLine("Un valor para el LADO 1 del pentagono:");
                    l1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Un valor para el LADO 2 del pentagono:");
                    l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Pentagono: " + g.areapentagono(l1, l2));
                    break;
                case 6:
                    Console.WriteLine("Un valor para el LADO 1 del rombo:");
                    l1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Un valor para el LADO 2 del rombo:");
                    l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Rombo: " + g.arearombo(l1, l2));
                    break;
                case 7:
                    Console.WriteLine("Un valor para el LADO 1 del romboide:");
                    l1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Un valor para el LADO 2 del romboide:");
                    l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Romboide: " + g.arearomboide(l1, l2));
                    break;
                case 8:
                    Console.WriteLine("Un valor para el LADO 1 del trapecio:");
                    l1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Un valor para el LADO 2 del trapecio:");
                    l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Un valor para el LADO 3 del trapecio:");
                    int l3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Trapecio: " + g.areatrapecio(l1, l2, l3));
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        private static int Menu()
        {
            Console.WriteLine("Elige una opcion:");
            Console.WriteLine("Cuadrado: 1");
            Console.WriteLine("Circulo: 2");
            Console.WriteLine("Triangulo: 3");
            Console.WriteLine("Rectangulo: 4");
            Console.WriteLine("Pentagono: 5");
            Console.WriteLine("Rombo: 6");
            Console.WriteLine("Romboide: 7");
            Console.WriteLine("Trapecio: 8");
            return int.Parse(Console.ReadLine());
        }
    }
}
