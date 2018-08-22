using System;
namespace CursoCSharp.Fundamentos {
    public class QuadradoCubo {

        public static void Executar() {
            string entrada;
            double numero;

            Console.WriteLine("Ao quadrado e ao Cubo!");

            Console.WriteLine("Insira um número");
            entrada = Console.ReadLine();

            double.TryParse(entrada, out numero);

            Console.WriteLine("Valor ao quadrado: {0}", Math.Pow(numero, 2));
            Console.WriteLine("Valor ao cubo: {0}", Math.Pow(numero, 3));
        }
    }
}
