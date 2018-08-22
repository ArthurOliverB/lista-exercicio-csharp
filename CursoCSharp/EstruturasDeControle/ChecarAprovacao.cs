using System;
namespace CursoCSharp.EstruturasDeControle {
    public class ChecarAprovacao {
        public static void Executar() {

            Console.WriteLine("Digite a primeira nota: ");
            var np1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            var np2 = double.Parse(Console.ReadLine());

            var media = np1 / np2;

            if(media > 7.0) {
                Console.WriteLine("Aprovado!");
            } else if(media < 7.0 && media < 4.0) {
                Console.WriteLine("Recuperação!");
            } else {
                Console.WriteLine("Reprovado!!");
            }
        }
    }
}
