using System;
namespace CursoCSharp.Fundamentos {
    public class AreaTriangulo {

        public static void Executar() {
            // Area = b * h / 2
            int baseTriangulo;
            int alturaTriangulo;
            string entrada;

            Console.WriteLine("Calcular a área do triângulo!");


            Console.WriteLine("Insira a base");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out baseTriangulo);

            Console.WriteLine("Insira a altura");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out alturaTriangulo);

            var resultado = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine("Área do triângulo: {0}", resultado);
        }
    }
}
