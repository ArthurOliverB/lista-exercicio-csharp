using System;

namespace CursoCSharp.Fundamentos {
    public class CelsiusFahrenheit {
        public static void Executar() {
            Console.WriteLine("Conversor Celsius -> Fahrenheit");

            Console.WriteLine("Digite a temperatura a ser convertida");
            var entrada = Console.ReadLine();

            Double temperatura;
            Double.TryParse(entrada, out temperatura);

            var resultado = (temperatura * 1.8) + 32;
            Console.WriteLine("{0:F2}", resultado);
        }
    }
}
