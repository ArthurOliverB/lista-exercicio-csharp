using System;
namespace CursoCSharp.Fundamentos {

    public class IMC {
        public static void Executar() {
            // IMC = peso(KG) / Altura * Altura
            double peso;
            double altura;
            string entrada; 

            Console.WriteLine("Calcular IMC");

            Console.WriteLine("Insira seu peso(Kg): ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out peso);

            Console.WriteLine("Insira seu Altura(Cm): ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out altura);

            var resultado = peso / Math.Pow(altura/100, 2);
            Console.WriteLine("Seu IMC é: {0:F2}", resultado);
           
        }
    }
}
