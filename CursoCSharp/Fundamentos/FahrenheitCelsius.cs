using System;

namespace CursoCSharp.Fundamentos {
    public class FahrenheitCelsius {
        public static void Executar() {
            // C = (F - 32)/1,8
            Console.WriteLine("Conversor Fahrenheit -> Celsius");

            Console.WriteLine("Digite a temperatura a ser convertida");
            var entrada = Console.ReadLine();

            double temperatura;
            Double.TryParse(entrada, out temperatura);

            var resultado = (temperatura - 32) / 1.8;

            Console.WriteLine("{0:F2}", resultado);
        }
    }
}
