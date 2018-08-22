using System;
namespace CursoCSharp.Fundamentos {
    public class EquacaoSegundoGrau {
        public static void Executar() {
            // ax2 + bx + c = 0
            // x = -b  +- √d / 2*a
            // d = (b*b) + 4 * a * c

            Console.WriteLine("Insira o valor de a: ");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de b: ");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de c: ");
            double c = Double.Parse(Console.ReadLine());

            Console.WriteLine("Equação final: {0}x² + {1}x + {2} = 0", a, b, c);

            double delta = Math.Pow(b, 2) - 4 * a * c ;

            double x1 = (-b + Math.Sqrt(delta)) / 2*a;
            double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine("Valor Delta: " + delta);
            Console.WriteLine("x' = " + x1);
            Console.WriteLine("x''= " + x2);

        }
    }
}
