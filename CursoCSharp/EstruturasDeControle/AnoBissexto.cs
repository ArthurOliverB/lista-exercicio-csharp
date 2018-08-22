using System;
namespace CursoCSharp.EstruturasDeControle {
    public class AnoBissexto {

        public static void Executar() {
            var anoAtual = new DateTime().Year;

            if(anoAtual % 4 == 0) {
                Console.WriteLine("O ano é bissexto");
            } else {
                Console.WriteLine("O ano é não bissexto");
            }
        }
    }
}
