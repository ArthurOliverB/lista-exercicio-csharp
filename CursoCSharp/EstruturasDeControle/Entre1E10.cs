using System;
namespace CursoCSharp.EstruturasDeControle {
    public class Entre1E10 {

        public static void Executar() {
            Console.WriteLine("Digite um número: ");
            var numero = int.Parse(Console.ReadLine());

            if(numero > 1 && numero < 10) {
                Console.WriteLine("Numero entre 1 e 10");
            } else {
                Console.WriteLine("Numero não está entre 1 e 10");
            }
        }
    }
}
